using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class AvisosVTO : Form
    {
        List<Cliente_VtoDGV> clientes = new List<Cliente_VtoDGV>();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public AvisosVTO()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AvisosVTO_Load(object sender, EventArgs e)
        {
            dtp_fecha.Value = DateTime.Now.Date;
            dtp_Vto_Cuota.Value = DateTime.Now.Date;
            btn_ActualizarTelefono.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                text_Mensaje.Text = "Hola @nombrecliente!, ya podés descargar tu refacturación de póliza que corresponde" +
                    " al vehículo @bienasegurado, para bajar el cupón de pago hacé click aquí ==> @enlacecupon o" +
                    " buscá en mi oficina la versión en papel." + " Podés descargar una constancia de cobertura haciendo click aquí ==> " +
                    "@enlacetarjeta. Saludos! - Damián Sortino - Productor Asesor de Seguros";

                clientes.Clear();

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime fechaespecifica = dtp_fecha.Value.Date;

                    var query = from a in DB.Cuotas
                                join b in DB.Endosos on a.idendoso equals b.id
                                join c in DB.Polizas on b.idpoliza equals c.IdPoliza
                                join d in DB.Bienes on b.idbien equals d.Id

                                where (((a.vencimiento == fechaespecifica) && a.numero == 1) && (c.Estado == "vigente" || c.Estado == "Emitida"))
                                select new
                                {
                                    IdPoliza = c.IdPoliza,
                                    IdBien = d.Id,
                                    IdCuota = a.id,
                                    IdEndoso = b.id
                                };
                    var result = query.ToList();


                    foreach (var item in result)
                    {
                        Cliente_VtoDGV nuevo = new Cliente_VtoDGV(item.IdPoliza, item.IdBien, item.IdCuota, item.IdEndoso);
                        clientes.Add(nuevo);
                    }

                    lbl_Avisos.Text = clientes.Count + " Avisos listos para enviar";
                    dgv.DataSource = null;
                    dgv.DataSource = clientes;
                    dgv.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error buscando refacturaciones \n" + ex.Message);
            }
        }

        private void btn_BuscarVtoCuota_Click(object sender, EventArgs e)
        {
            try
            {
                text_Mensaje.Text = "Hola @nombrecliente!, " +
                    "te recuerdo que hoy vence la cuota de tu seguro correspondiente al vehículo @bienasegurado." +
                    " Si ya pagaste, no hagas caso de este mensaje. Saludos!. Damián Sortino - Productor Asesor de Seguros.";

                clientes.Clear();

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime fechaespecifica = dtp_Vto_Cuota.Value.Date;

                    var query = from a in DB.Cuotas
                                join b in DB.Endosos on a.idendoso equals b.id
                                join c in DB.Polizas on b.idpoliza equals c.IdPoliza
                                join d in DB.Bienes on b.idbien equals d.Id

                                where ((a.vencimiento == fechaespecifica) && (c.Estado == "Vigente" || c.Estado == "Emitida"))
                                select new
                                {
                                    IdPoliza = c.IdPoliza,
                                    IdBien = d.Id,
                                    IdCuota = a.id,
                                    IdEndoso = b.id
                                };
                    var result = query.ToList();


                    foreach (var item in result)
                    {
                        Cuotas evaluarpagada = DB.Cuotas.Find(item.IdCuota);

                        if (evaluarpagada.pagada == false)
                        {
                            Cliente_VtoDGV nuevo = new Cliente_VtoDGV(item.IdPoliza, item.IdBien, item.IdCuota, item.IdEndoso);
                            clientes.Add(nuevo);
                        }
                    }

                    lbl_Avisos.Text = clientes.Count + " avisos listos para enviar.";
                    dgv.DataSource = null;
                    dgv.DataSource = clientes;
                    dgv.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error buscando vencimientos de cuota \n" + ex.Message);
            }
        }

        private void btn_EnviarMsjs_Click(object sender, EventArgs e)
        {
            try
            {
                string url;

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    foreach (DataGridViewRow item in dgv.Rows)
                    {
                        Cliente_VtoDGV cliente = (Cliente_VtoDGV)item.DataBoundItem;

                        if (cliente.Enviar == true)
                        {
                            string mensaje = text_Mensaje.Text;

                            mensaje = mensaje.Replace("@nombrecliente", cliente.Asegurado);
                            mensaje = mensaje.Replace("@bienasegurado", cliente.BienAsegurado);
                            if (cliente.Cuota == 1)
                            {
                                string polizacliente = cliente.Poliza;
                                int endosocliente = cliente.Endoso;
                                int cuotacliente = cliente.Cuota;

                                string poli = cliente.Poliza.ToString();

                                var query = from a in DB.Endosos
                                            join b in DB.Polizas on a.idpoliza equals b.IdPoliza
                                            join c in DB.Cuotas on a.id equals c.idendoso
                                            where (b.NumeroPoliza == polizacliente) && (a.endoso == endosocliente && c.numero == cuotacliente)
                                            select new
                                            {
                                                Id = a.id,
                                                Sup = a.suplemento,
                                                Rama = b.Rama
                                            };

                                var result = query.ToList();

                                string suple = DB.Endosos.Find(result[0].Id).suplemento.ToString();
                                string rama = result[0].Rama;

                                string certificado = $"https://productores.paranaseguros.com.ar/PARANA_COMERCIAL_PROD/servlet/ar.com.glmsa.seguros.comercial.apcertifaut1web?P8375,1," + rama + "," + poli + "," + suple + ",1,2";
                                string cupon = $"https://productores.paranaseguros.com.ar/PARANA_COMERCIAL_PROD/servlet/ar.com.glmsa.seguros.comercial.apciedia03web?1,0,,0," + rama + "," + poli + "," + suple + ",0,M,S,CMPOLWEBMP_MOVIMIENTOS,FIL,S";

                                mensaje = mensaje.Replace("@enlacecupon", cupon);
                                mensaje = mensaje.Replace("@enlacetarjeta", certificado);
                            }

                            string cel_cli = DB.Clientes.Find(DB.Polizas.ToList().Find(x => x.NumeroPoliza == cliente.Poliza).IdCliente).Telefono;
                            url = $"https://wa.me/+549{cel_cli}?text={Uri.EscapeDataString(mensaje)}";

                            System.Diagnostics.Process.Start(url);
                        }

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas enviando mensajes \n" + ex.Message);
            }

        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (dgv.Columns[e.ColumnIndex].Name == "Poliza" && e.Value != null)
                    {

                        string poliza = e.Value.ToString();
                        int Idcliente = DB.Polizas.ToList().Find(x => x.NumeroPoliza == poliza).IdCliente;
                        string telcliente = DB.Clientes.Find(Idcliente).Telefono;

                        if (telcliente is null || telcliente.Length <= 4)
                        {
                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(38, 237, 228); // Color de fondo RGB (174, 214, 12)
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error dibujando datagridview \n" + ex.Message);
            }
        }

        private void btn_ActualizarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    int idcliente = DB.Polizas.ToList().Find(x => x.NumeroPoliza == dgv.CurrentRow.Cells[0].Value.ToString()).IdCliente;
                    EditCliente editarcliente = new EditCliente(DB.Clientes.Find(idcliente));
                    editarcliente.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btn actualziar teléfono \n" + ex.Message);
            }
        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_ActualizarTelefono.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                dgv.Rows[e.RowIndex].ReadOnly = true;
                dgv.Rows[e.RowIndex].Cells["Enviar"].ReadOnly = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Tildar_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    item.Cells[item.Cells.Count - 1].Value = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en btn destildar \n" + ex.Message);
            }
        }

        private void btn_Destildar_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    item.Cells[item.Cells.Count - 1].Value = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en btn destildar \n" + ex.Message);
            }
        }

        private void btn_EnviarDirectamente_Click(object sender, EventArgs e)
        {
            try
            {
                btn_BuscarVtoCuota.PerformClick();
                btn_EnviarMsjs.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
