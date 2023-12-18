using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class FrmCobrar_Caja : Form
    {
        public FrmCobrar_Caja()
        {
            InitializeComponent();
        }

        List<ReciboDGV> listado = new List<ReciboDGV>();


        Recibos reciboleido = new Recibos();


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (ComprobarLectura())
                    {
                        if (ComprobarBarra())
                        {
                            if (ExisteCuota())
                            {
                                CargarDatosRebibo();
                                btn_Ok_Recibo.Focus();
                            }
                            else
                            {
                                CargarLeidoNoEncontrado();
                                gb_noencontro.Visible = true;
                                btn_Ok_Recibo.Focus();
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
                        MessageBox.Show("Lectura incorrecta, intente nuevamente");
                    }

                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarLeidoNoEncontrado()
        {
            try
            {
                string importe = tb_barra.Text.Substring(6, 6) + "." + tb_barra.Text.Substring(12, 2);

                reciboleido = new Recibos();
                reciboleido.codigobarra = tb_barra.Text;
                reciboleido.FechaCobro = DateTime.Now;
                reciboleido.Importe = decimal.Parse(importe);
                reciboleido.fechaalta = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDatosRebibo()
        {
            try
            {
                string poliza = tb_barra.Text.Substring(22, 8);
                string endoso_suplemento = tb_barra.Text.Substring(30, 6);
                string importe = tb_barra.Text.Substring(6, 6) + "." + tb_barra.Text.Substring(12, 2);
                string cuota = tb_barra.Text.Substring(36, 2);
                string rama = tb_barra.Text.Substring(20, 2);


                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    var query_existe_recibo = from h in DB.Recibos
                                              where (h.codigobarra == tb_barra.Text)
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

                        string endoso_asociada = int.Parse(tb_barra.Text.Substring(22, 8)).ToString();
                        int endosobarra = int.Parse(tb_barra.Text.Substring(30, 6));
                        int numcuota = int.Parse(tb_barra.Text.Substring(36, 2));
                        decimal importe_recibo = decimal.Parse(tb_barra.Text.Substring(6, 6) + "." + tb_barra.Text.Substring(12, 2));

                        var query = from a in DB.Cuotas
                                    join b in DB.Endosos on a.idendoso equals b.id
                                    join c in DB.Polizas on b.idpoliza equals c.IdPoliza

                                    where ((b.asociada == endoso_asociada || ((c.NumeroPoliza == endoso_asociada) && (b.endoso == endosobarra)))
                                    && a.numero == numcuota)
                                    select new
                                    {
                                        Id_Cuota = a.id,
                                        Id_Poliza = c.IdPoliza
                                    };
                        var result = query.ToList();


                        reciboleido = new Recibos();
                        reciboleido.codigobarra = tb_barra.Text;
                        reciboleido.FechaCobro = DateTime.Now;
                        reciboleido.Importe = importe_recibo;
                        reciboleido.fechaalta = DateTime.Now;
                        reciboleido.idcuota = result[0].Id_Cuota;

                        Polizas polizaencontrada = DB.Polizas.Find(result[0].Id_Poliza);

                        lbl_Cliente.Text = polizaencontrada.Clientes.ApellidoyNombre;
                        lbl_Rama.Text = polizaencontrada.Rama;
                        lbl_poliza_asociada.Text = polizaencontrada.NumeroPoliza;
                        lbl_endoso_suplemento.Text = endoso_asociada;
                        lbl_importe.Text = importe;
                        lbl_cuota.Text = cuota;
                        lbl_vto.Text = DB.Cuotas.Find(result[0].Id_Cuota).vencimiento.ToString();
                    }
                }
                btn_Ok_Recibo.Focus();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ExisteCuota()
        {
            try
            {
                if (tb_barra.Text.Substring(20, 2) == "22" || tb_barra.Text.Substring(20, 2) == "12")
                {
                    MessageBox.Show("Todavía no se admiten recibos de ramas varias");
                    return false;
                }
                else
                {
                    using (MartinaPASEntities DB = new MartinaPASEntities())
                    {//poliza en barra
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
                MessageBox.Show(ex.Message);
                return false;
            }
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

        private void btn_Ok_Recibo_Click(object sender, EventArgs e)
        {
            try
            {
                ReciboDGV agregar = new ReciboDGV(reciboleido);
                listado.Add(agregar);
                dgv_agregados.DataSource = null;
                dgv_agregados.DataSource = listado;
                gb_noencontro.Visible = false;
                tb_barra.Focus();
                tb_barra.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
