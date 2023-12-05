using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class PolizasForm : Form
    {
        public PolizasForm()
        {
            InitializeComponent();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (cboxFiltroMostrar.Text == "Todas")
                    {
                        BuscarPoliza("Todas");
                    }
                    else
                    {
                        
                        if (cboxFiltroMostrar.Text == "Vigentes")
                        {
                            BuscarPoliza("Vigentes");
                        }
                        else
                        {
                            if (cboxFiltroMostrar.Text == "Anuladas")
                            {
                                BuscarPoliza("Anuladas");
                            }
                            else
                            {
                                if (cboxFiltroMostrar.Text == "Vencidas")
                                {
                                    BuscarPoliza("Vencidas");
                                }
                                else
                                {
                                    if (cboxFiltroMostrar.Text == "Emitidas")
                                    {
                                        BuscarPoliza("Emitidas");
                                    }

                                }
                            }

                        }

                    }
                }

                dgvPolizas.Columns[0].Visible = false; //número de id
                dgvPolizas.Columns[3].HeaderText = "Póliza";
                dgvPolizas.Columns[7].Visible = false; // idcliente

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Buscando póliza \n" + ex.Message);
            }
        }

        private void BuscarPoliza(string v)
        {
            try
            {
                string busquedapor = "";

                if(v == "Todas")
                {
                    busquedapor = "Todas";
                }
                else
                {
                    if (v == "Emitidas")
                    {
                        busquedapor = "Emitida";
                    }
                    else
                    {
                        if (v == "Vigentes")
                        {
                            busquedapor = "Vigente";
                        }
                        else
                        {
                            if (v == "Anuladas")
                            {
                                busquedapor = "Anulada";
                            }
                            else
                            {
                                busquedapor = "Vencida";
                            }
                        }
                    }
                }

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (radio_ApellidoNombre.Checked == true)
                    {
                        List<PolizaDGV> dtFiltrado = new List<PolizaDGV>();

                        string filtro = tb_filtro.Text.ToUpper().Trim();
                        List<Clientes> clientes = DB.Clientes.ToList().FindAll(x => x.ApellidoyNombre.Contains(filtro));

                        foreach (Polizas item in DB.Polizas.ToList())
                        {
                            foreach (Clientes encon in clientes)
                            {
                                if (item.IdCliente == encon.IdCliente)
                                {
                                    dtFiltrado.Add(new PolizaDGV(item));
                                }
                            }

                        }

                        if (dtFiltrado.Count < 1)
                        {
                            MessageBox.Show("No se encontraron Clientes");
                            dgvPolizas.DataSource = null;
                        }
                        else
                        {
                            dtFiltrado = EliminarDuplicado(dtFiltrado);

                            if (busquedapor != "Todas")
                            {
                                dtFiltrado = dtFiltrado.FindAll(x => x.Estado == busquedapor);
                            }

                            dgvPolizas.DataSource = dtFiltrado;
                        }

                    }

                    else
                    {
                        if (radio_DNI.Checked == true)
                        {
                            List<PolizaDGV> dtFiltrado = new List<PolizaDGV>();

                            string filtrito = tb_filtro.Text.ToUpper().Trim();

                            List<Clientes> clientes = DB.Clientes.ToList().FindAll(x => x.DNI.Contains(filtrito));


                            foreach (Polizas item in DB.Polizas.ToList())
                            {
                                foreach (Clientes cli in clientes)
                                {
                                    if (cli.IdCliente == item.IdCliente)
                                    {
                                        dtFiltrado.Add(new PolizaDGV(item));
                                    }
                                }
                            }

                            if (dtFiltrado.Count < 1)
                            {
                                MessageBox.Show("No se encontraron Clientes");
                                dgvPolizas.DataSource = null;
                            }
                            else
                            {
                                dtFiltrado = EliminarDuplicado(dtFiltrado);

                                if (busquedapor != "Todas")
                                {
                                    dtFiltrado = dtFiltrado.FindAll(x => x.Estado == busquedapor);
                                }

                                dgvPolizas.DataSource = dtFiltrado;
                            }
                        }
                        if (radioPatente.Checked == true)
                        {
                            List<PolizaDGV> dtFiltrado = new List<PolizaDGV>();

                            string patente = tb_filtro.Text.Trim().ToUpper();

                            List<Autos> autos = DB.Autos.ToList().FindAll(x => x.Dominio.Contains(patente));
                            if (autos.Count >= 1)
                            {
                                //logicacon autos encontrados

                                var query = from a in DB.Polizas
                                            join b in DB.Endosos on a.IdPoliza equals b.idpoliza
                                            join c in DB.Bienes on b.idbien equals c.Id
                                            where (c.Nombre.Contains(patente))
                                            select new
                                            {
                                                Id = a.IdPoliza
                                            };
                                var result = query.ToList();

                                foreach (var resultado in result)
                                {
                                    dtFiltrado.Add(new PolizaDGV(DB.Polizas.Find(resultado.Id)));
                                }
                                if (dtFiltrado.Count < 1)
                                {
                                    MessageBox.Show("No se encontraron pólizas");
                                    dgvPolizas.DataSource = null;
                                }
                                else
                                {
                                    dtFiltrado = EliminarDuplicado(dtFiltrado);

                                    if (busquedapor != "Todas")
                                    {
                                        dtFiltrado = dtFiltrado.FindAll(x => x.Estado == busquedapor);
                                    }

                                    dgvPolizas.DataSource = dtFiltrado;
                                }
                            }
                            else
                            {
                                //no hay vehículos encontrados
                                MessageBox.Show("No hay vehículos con esa patente en su base de datos");
                                dgvPolizas.DataSource = null;
                            }



                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<PolizaDGV> EliminarDuplicado(List<PolizaDGV> listaconduplicados)
        {
            try
            {
                List<PolizaDGV> sinduplicados = new List<PolizaDGV>();

                foreach (PolizaDGV elemento in listaconduplicados)
                {
                    bool bandera = false;
                    foreach (PolizaDGV item in sinduplicados)
                    {
                        if (item.IdPoliza == elemento.IdPoliza)
                        {
                            bandera = true;
                        }
                    }
                    if (bandera == false)
                    {
                        sinduplicados.Add(elemento);
                    }
                }
                return sinduplicados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando duplicados \n" + ex.Message);
                return new List<PolizaDGV>();
            }
        }

        private void tb_filtro_MouseClick(object sender, MouseEventArgs e)
        {
            tb_filtro.Clear();
        }

        private void tb_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn_filtrar.PerformClick();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en eventos del tb_Filtro \n" + ex.Message);
            }
        }

        private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PolizaDGV seleccionada = (PolizaDGV)dgvPolizas.CurrentRow.DataBoundItem;
                List<EndosoDGV> endosos = new List<EndosoDGV>();

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    foreach (Endosos item in DB.Endosos)
                    {
                        if (item.idpoliza == seleccionada.IdPoliza)
                        {
                            endosos.Add(new EndosoDGV(item));
                        }
                    }
                }

                if (endosos.Count>=1)
                {
                    endosos = endosos.OrderBy(Endosos => Endosos.fechavigenciadesde).ToList();
                    dgvEndosos.DataSource = endosos;
                    dgvEndosos.Columns["idbien"].Visible = false;
                    dgvEndosos.Columns["idpoliza"].Visible = false;
                }
                else
                {
                    dgvEndosos.DataSource = null;
                    MessageBox.Show("No se encontraron endosos en la póliza seleccionada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PolizasForm_Load(object sender, EventArgs e)
        {

        }

        

        private void dgvEndosos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    List<CuotasDGV> mostrar = new List<CuotasDGV>();
                    int endoso_sel = ((EndosoDGV)dgvEndosos.CurrentRow.DataBoundItem).id;
                    List<Cuotas> cuotas = DB.Cuotas.ToList().FindAll(x => x.idendoso == endoso_sel);
                    foreach (Cuotas item in cuotas)
                    {
                        mostrar.Add(new CuotasDGV(item));
                    }

                    dgvPagos.DataSource = null;
                    dgvPagos.DataSource = mostrar;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPagos.DataSource != null)
                {
                    foreach (Control item in gbox_Botones.Controls)
                    {
                        if (item.Enabled == false && item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Cupones_Click(object sender, EventArgs e)
        {
            try
            {
                string rama = ((PolizaDGV)dgvPolizas.CurrentRow.DataBoundItem).Rama;
                string poli = ((PolizaDGV)dgvPolizas.CurrentRow.DataBoundItem).NumeroPoliza;
                string suple = ((EndosoDGV)dgvEndosos.CurrentRow.DataBoundItem).suplemento.ToString();
                
                string url = $"https://productores.paranaseguros.com.ar/PARANA_COMERCIAL_PROD/servlet/ar.com.glmsa.seguros.comercial.apciedia03web?1,0,,0," + rama + "," + poli + "," + suple + ",0,M,S,CMPOLWEBMP_MOVIMIENTOS,FIL,S"; ;
                
                btn_Cupones.Enabled = false;
                System.Diagnostics.Process.Start(url);

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Certificado_Click(object sender, EventArgs e)
        {
            try
            {
                string rama = ((PolizaDGV)dgvPolizas.CurrentRow.DataBoundItem).Rama;
                string poli = ((PolizaDGV)dgvPolizas.CurrentRow.DataBoundItem).NumeroPoliza;
                string suple = ((EndosoDGV)dgvEndosos.CurrentRow.DataBoundItem).suplemento.ToString();

                string url = $"https://productores.paranaseguros.com.ar/PARANA_COMERCIAL_PROD/servlet/ar.com.glmsa.seguros.comercial.apcertifaut1web?P8375,1," + rama + "," + poli + "," + suple + ",1,2";
                
                btn_Certificado.Enabled = false;
                System.Diagnostics.Process.Start(url);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
