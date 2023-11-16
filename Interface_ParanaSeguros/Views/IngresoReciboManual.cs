using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class IngresoReciboManual : Form
    {
        public IngresoReciboManual()
        {
            InitializeComponent();
        }

        string polizadigitada = "";
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Poliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Validar ingreso de Enter o Tab
                if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
                {
                    if (ValidarPoliza())
                    {
                        if (ExistePoliza())
                        {
                            LlenarComboEndosos();
                            cb_Endoso.Focus();
                            e.Handled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la póliza");
                            tb_Poliza.Clear();
                            tb_Poliza.Focus();
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("el número de póliza solo admite números, sin espacio, intente nuevamente su búsqueda");
                        tb_Poliza.Clear();
                        tb_Poliza.Focus();
                        e.Handled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando póliza" + ex.Message);
            }
        }

        private void LlenarComboEndosos()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {

                    Polizas polizaencontrada = DB.Polizas.ToList().Find(l => l.NumeroPoliza == polizadigitada);
                    lblCliente.Text = polizaencontrada.Clientes.ApellidoyNombre;

                    var query = from b in DB.Bienes
                                join c in DB.Endosos on b.Id equals c.idbien
                                join d in DB.Polizas on c.idpoliza equals d.IdPoliza
                                where (polizaencontrada.IdPoliza == d.IdPoliza)
                                select new
                                {
                                    Nombre = b.Nombre
                                };

                    var result = query.ToList();
                    lbl_Riesgo.Text = result[0].Nombre;

                    cb_Endoso.DataSource = DB.Endosos.ToList().FindAll(h => h.idpoliza == polizaencontrada.IdPoliza);
                    cb_Endoso.DisplayMember = "endoso";
                    cb_Endoso.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private bool ExistePoliza()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (DB.Polizas.ToList().FindAll(x => x.NumeroPoliza == polizadigitada).Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ValidarPoliza()
        {
            try
            {
                polizadigitada = tb_Poliza.Text.Trim();
                if (true)
                {
                    //codigo validacion de solo numeros sin espacios ni signos
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void cb_Endoso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (polizadigitada != "")
                    {
                        int idendososeleccionado = ((Endosos)cb_Endoso.SelectedItem).id;

                        List<Cuotas> cuotas = DB.Cuotas.ToList().FindAll(x => x.idendoso == idendososeleccionado);

                        cb_Cuota.ValueMember = "id";
                        cb_Cuota.DisplayMember = "numero";
                        cb_Cuota.DataSource = cuotas;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cb_Endoso_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    if (!(polizadigitada == ""))
                    {
                        List<Polizas> poli = DB.Polizas.ToList().FindAll(x => x.NumeroPoliza == polizadigitada);

                        List<Endosos> endosos = DB.Endosos.ToList().FindAll(x => x.idpoliza == poli[0].IdPoliza);
                        cb_Cuota.DataSource = endosos;
                        cb_Cuota.ValueMember = "id";
                        cb_Cuota.DisplayMember = "endoso";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
