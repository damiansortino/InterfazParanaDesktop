using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class RecibosCobrados : Form
    {
        List<ReciboDGV> mostrar = new List<ReciboDGV>();

        public RecibosCobrados()
        {
            InitializeComponent();
        }

        List<int> darbaja = new List<int>();

        private void RecibosCobrados_Load(object sender, EventArgs e)
        {
            //MostrarRecibos();
        }

        private void MostrarRecibos()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    var query = from a in DB.Recibos

                                where (a.fechabaja == null)
                                select new
                                {
                                    Id = a.IdRecibo
                                };

                    var result = query.ToList();


                    List<ReciboDGV> lista = new List<ReciboDGV>();

                    foreach (var item in result)
                    {
                        Recibos activo = DB.Recibos.Find(item.Id);
                        ReciboDGV nuevo = new ReciboDGV(activo);
                        lista.Add(nuevo);
                    }

                    lista = lista.OrderBy(ReciboDGV => ReciboDGV.Cliente).ToList();

                    dgv.DataSource = null;
                    dgv.DataSource = lista;
                    dgv.Columns[9].HeaderText = "Rendido";
                    dgv.Columns[10].Visible = false;
                    dgv.Columns[11].Visible = false;
                    dgv.ReadOnly = false;

                    //desactiva el campo "Rendido"
                    foreach (DataGridViewRow item in dgv.Rows)
                    {
                        item.Cells[9].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error actualizando recibos cobrados \n" + ex.Message);
            }

        }

        private void btn_VerTodos_Click(object sender, EventArgs e)
        {
            MostrarRecibos();
            ActivarBtnMarcar();
        }

        private void ActivarBtnMarcar()
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    btn_MarcarRendidos.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error activando el botón 'Marcar como rendidos' \n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime convenio_pasado;

                    DateTime fechaActual = DateTime.Now;
                    int dia = fechaActual.Day;

                    if (dia <= 3)
                    {
                        if (fechaActual.Month == 1)
                        {
                            convenio_pasado = new DateTime(fechaActual.AddYears(-1).Year, fechaActual.AddMonths(-1).Month, 18);
                        }
                        convenio_pasado = new DateTime(fechaActual.Year, fechaActual.AddMonths(-1).Month, 18);
                    }
                    else if (dia > 3 && dia <= 18)
                    {
                        convenio_pasado = new DateTime(fechaActual.Year, fechaActual.Month, 3);
                    }
                    else
                    {
                        convenio_pasado = new DateTime(fechaActual.Year, fechaActual.Month, 18);
                    }


                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id
                                where (b.convenio <= convenio_pasado && a.fechabaja == null && (a.fechabaja == null))
                                select new
                                {
                                    Id = a.IdRecibo
                                };
                    var result = query.ToList();
                    dgv.DataSource = null;

                    List<ReciboDGV> listamostrar = new List<ReciboDGV>();

                    foreach (var item in result)
                    {
                        Recibos rec = DB.Recibos.Find(item.Id);
                        ReciboDGV nuevo = new ReciboDGV(rec);
                        listamostrar.Add(nuevo);
                    }

                    listamostrar = listamostrar.OrderBy(ReciboDGV => ReciboDGV.Cliente).ToList();

                    dgv.DataSource = listamostrar;

                    dgv.Columns[9].HeaderText = "Rendido";
                    dgv.Columns[10].Visible = false;
                    dgv.Columns[11].Visible = false;
                    dgv.ReadOnly = false;

                    //desactiva el campo "Rendido"
                    foreach (DataGridViewRow item in dgv.Rows)
                    {
                        item.Cells[9].Value = false;
                    }

                }

                ActivarBtnMarcar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button Cobrados \n" + ex.Message);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MarcarRendidos_Click(object sender, EventArgs e)
        {
            using (MartinaPASEntities DB = new MartinaPASEntities())
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    if ((bool)item.Cells[9].Value == true)
                    {
                        Recibos actualizar = DB.Recibos.Find(item.Cells[0].Value);
                        actualizar.fechabaja = DateTime.Now;
                        DB.SaveChanges();
                    }
                }

                MessageBox.Show("Recibos Marcados Correctamente");
                btn_MarcarRendidos.Enabled = false;
                dgv.DataSource = null;
            }

        }

        private void btn_ProcesarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                mostrar.Clear();

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.ShowDialog();
                linklabel_Path.Text = ofd.FileName;
                if (Path.GetExtension(linklabel_Path.Text).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    CargarPlanilla();
                }
                else
                {
                    MessageBox.Show("Solo se admiten archivos de tipo Planilla con extención *.csv \n Localice nuevamente el archivo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cargando planilla \n" + ex.Message);
            }


        }

        private void CargarPlanilla()
        {
            try
            {
                List<Recibos> recibos = new List<Recibos>();
                int contador_lineas = 0;



                using (MartinaPASEntities DB = new MartinaPASEntities())
                {

                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id
                                join c in DB.Endosos on b.idendoso equals c.id
                                join d in DB.Polizas on c.idpoliza equals d.IdPoliza
                                where (a.fechabaja == null)
                                select new
                                {
                                    id = a.IdRecibo,
                                    rama = d.Rama,
                                    poliza = d.NumeroPoliza,
                                    endoso = c.endoso,
                                    importe = a.Importe,
                                    cuota = b.numero,
                                    barra = a.codigobarra,
                                    asociada = c.asociada,
                                    suplemento = c.suplemento
                                };
                    var result = query.ToList();

                    List<string> lineas = new List<string>();

                    using (var reader = new StreamReader(linklabel_Path.Text))
                    {
                        reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            lineas.Add(line);
                        }
                    }

                    // revisar aquí el procesador de planillas rendidas

                    foreach (string linea in lineas)
                    {
                        contador_lineas++;

                        var values = linea.Split(';');
                        foreach (var item in result)
                        {
                            if (item.asociada == values[1] && item.cuota == int.Parse(values[4]))
                            {
                                Recibos nuevo = DB.Recibos.Find(item.id);
                                recibos.Add(nuevo);
                            }
                            else
                            {
                                if ((int.Parse(item.poliza) == int.Parse(values[1]) && item.suplemento == int.Parse(values[2]))&&(item.cuota == int.Parse(values[4])))
                                {
                                    Recibos nuevo = DB.Recibos.Find(item.id);
                                    recibos.Add(nuevo);
                                }
                                
                            }
                            
                        }
                    }

                }

                foreach (Recibos rec in recibos)
                {
                    ReciboDGV ver = new ReciboDGV(rec);
                    mostrar.Add(ver);
                }

                dgv.DataSource = null;
                dgv.DataSource = mostrar;
                dgv.Columns[9].HeaderText = "Rendido";
                dgv.Columns[10].Visible = false;
                dgv.Columns[11].Visible = false;
                dgv.ReadOnly = false;

                //desactiva el campo "Rendido"

                if (dgv.Rows.Count > 0)
                {
                    btn_MarcarRendidos.Enabled = true;
                }
                lbl_contador.Text = recibos.Count() + " Recibos listos";
                MessageBox.Show(contador_lineas+" registros encontrados en su planilla");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void linklabel_Path_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (File.Exists(linklabel_Path.Text))
                {
                    MessageBox.Show("Esta funcion estará disponible en la próxima actualización");
                }
                else
                {
                    MessageBox.Show("El archivo no existe o está dañado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Click en LinkLabel \n" + ex.Message);
            }

        }
    }
}
