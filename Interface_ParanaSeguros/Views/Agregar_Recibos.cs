using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class Agregar_Recibos : Form
    {
        public Agregar_Recibos()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        List<Recibos> lista = new List<Recibos>();
        List<ReciboDGV> mostrar = new List<ReciboDGV>();

        private void tb_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (ComprobarLectura())
                {
                    if (ComprobarBarra())
                    {
                        if (ExistePolizaInterfaz())
                        {

                            AgregarReciboDGV(tb_barra.Text);

                            ActualizarDGV();

                            tb_barra.Clear();
                            tb_barra.Focus();

                            e.Handled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró información en la interfaz");
                            tb_barra.Clear();
                            tb_barra.Focus();
                            e.Handled = true;
                        }

                    }
                    else
                    {
                        tb_barra.Clear();
                        tb_barra.Focus();
                        MessageBox.Show("No se reconoce el comprobante, intente nuevamente");
                    }
                }
                else
                {
                    e.Handled = true;
                    tb_barra.Clear();
                    tb_barra.Focus();
                    MessageBox.Show("Lectura incorrecta, intente nuevamente");
                }


            }
        }
        private void ActualizarDGV()
        {
            try
            {
                mostrar.Clear();
                foreach (Recibos item in lista)
                {
                    mostrar.Add(new ReciboDGV(item));

                }
                dgv_Recibos.DataSource = null;
                dgv_Recibos.DataSource = mostrar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mostrando recibos \n" + ex.Message);
            }
        }
        private void AgregarReciboDGV(string text)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    var query_existe_recibo = from h in DB.Recibos
                                              where (h.codigobarra == text)
                                              select new
                                              {
                                                  Recibo = h.IdRecibo
                                              };
                    var result_existe_Recibo = query_existe_recibo.ToList();
                    if (result_existe_Recibo.Count == 1)
                    {
                        MessageBox.Show("Error, este recibo se encuentra en su base de datos \n");
                    }
                    else
                    {

                        string endoso_asociada = int.Parse(text.Substring(22, 8)).ToString();
                        int endosobarra = int.Parse(text.Substring(30, 6));
                        int numcuota = int.Parse(text.Substring(36, 2));
                        decimal importe_recibo = decimal.Parse(text.Substring(6, 6) + "." + text.Substring(12, 2));

                        var query = from a in DB.Cuotas
                                    join b in DB.Endosos on a.idendoso equals b.id
                                    join c in DB.Polizas on b.idpoliza equals c.IdPoliza

                                    where ((b.asociada == endoso_asociada || ((c.NumeroPoliza == endoso_asociada) && (b.endoso == endosobarra)))
                                    && a.numero == numcuota)
                                    select new
                                    {
                                        Id_Cuota = a.id,

                                    };
                        var result = query.ToList();

                        Recibos nuevo = new Recibos();
                        nuevo.codigobarra = text;
                        nuevo.FechaCobro = DateTime.Now;
                        nuevo.Importe = decimal.Parse(text.Substring(5, 7) + "," + text.Substring(12, 2));
                        nuevo.fechaalta = DateTime.Now;
                        nuevo.idcuota = result[0].Id_Cuota;

                        lista.Add(nuevo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregando recibo" + "\n \n" + ex.Message);
            }

        }
        private bool ExistePolizaInterfaz()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (tb_barra.Text.Substring(20, 2) == "22" || tb_barra.Text.Substring(20, 2) == "12")
                    {
                        MessageBox.Show("Todavía no se admiten recibos de ramas varias");
                        return false;
                    }
                    else
                    {
                        //poliza en barra
                        string endoso_asociada = int.Parse(tb_barra.Text.Substring(22, 8)).ToString();
                        //endoso en barra
                        int endosobarra = int.Parse(tb_barra.Text.Substring(30, 6));
                        // numero cuota barra
                        int numcuota = int.Parse(tb_barra.Text.Substring(36, 2));

                        var query = from b in DB.Cuotas
                                    join c in DB.Endosos on b.idendoso equals c.id
                                    join d in DB.Polizas on c.idpoliza equals d.IdPoliza
                                    where (c.asociada == endoso_asociada || ((d.NumeroPoliza == endoso_asociada) && (c.endoso == endosobarra)))
                                    && (b.numero == numcuota)

                                    select new
                                    {
                                        id = b.id
                                    };

                        var result = query.ToList();

                        if (result.Count == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, cuota no encontrada" + "\n \n" + ex.Message);
            }
            return false;
        }
        private bool ComprobarLectura()
        {
            if (tb_barra.TextLength != 40)
            {
                tb_barra.Clear();
                tb_barra.Focus();
                return false;

            }
            else
            {
                if (tb_barra.Text.Substring(0, 6) != "094330")
                {
                    tb_barra.Clear();
                    tb_barra.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private bool ComprobarBarra()
        {
            if (tb_barra.Text.Substring(0, 6) == "094330")
            {
                return true;
            }
            else
            {
                tb_barra.Clear();
                return false;
            }
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (dgv_Recibos.RowCount < 1)
            {
                MessageBox.Show("Ingrese recibos al listado primero");
            }
            else
            {
                AgregarRecibosDB();
            }
        }

        private void AgregarRecibosDB()
        {
            try
            {
                foreach (ReciboDGV rec in mostrar)
                {

                    if (rec.Agregar == true)
                    {
                        Recibos nuevorecibo = new Recibos();
                        nuevorecibo.codigobarra = rec.barra;
                        nuevorecibo.fechaalta = DateTime.Now;
                        nuevorecibo.FechaCobro = DateTime.Now;
                        nuevorecibo.idcuota = rec.idcuota;
                        nuevorecibo.Importe = rec.Importe;
                        using (MartinaPASEntities DB = new MartinaPASEntities())
                        {

                            Recibos prueba = DB.Recibos.ToList().Find(x => x.idcuota == nuevorecibo.idcuota);
                            var query_existe = from f in DB.Recibos
                                               where (f.idcuota == nuevorecibo.idcuota)
                                               select new
                                               {

                                               };
                            var result_existe = query_existe.ToList();

                            if (result_existe.Count == 0)
                            {
                                Cuotas marcar = DB.Cuotas.Find(nuevorecibo.idcuota);
                                marcar.pagada = true;
                                DB.Recibos.Add(nuevorecibo);
                                DB.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("El siguiente recibo ya existe en su base de datos," +
                                    " no es necesario agregar la cobranza nuevamente: " + "\n \n" + rec.Cliente + "\n" + rec.Vehiculo);
                            }
                        }
                    }
                }

                dgv_Recibos.DataSource = null;
                mostrar.Clear();
                lista.Clear();
                MessageBox.Show("Recibos agregados correctamente a su base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas para agregar recibos a la base de datos" + "\n \n" + ex.Message);
            }
        }

        private void btn_IngresoManual_Click(object sender, EventArgs e)
        {
            IngresoReciboManual form = new IngresoReciboManual();
            form.ShowDialog();
        }
    }
}
