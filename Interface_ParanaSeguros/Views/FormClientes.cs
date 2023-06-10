using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                btn_Editar.Enabled = false;
                ActualizarDGVClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error FormClientes_Load \n" + ex.Message);
            }
        }

        private void ActualizarDGVClientes()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    dgv.DataSource = null;
                    dgv.DataSource = DB.Clientes.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Actualizando clientes \n" + ex.Message);
            }


        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            ActualizarDGVClientes();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    Clientes nuevo = (Clientes)dgv.CurrentRow.DataBoundItem;
                    EditarClienteSel(nuevo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Seleccionando cliente \n" + ex.Message);
            }


        }

        private void EditarClienteSel(Clientes nuevo)
        {
            try
            {
                EditCliente formeditcliente = new EditCliente(nuevo);
                formeditcliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (btn_Editar.Enabled == false)
                {
                    btn_Editar.Enabled = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_poliza.Checked == true)
                {

                    List<Clientes> dtFiltrado = new List<Clientes>();

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells["ApellidoyNombre"].Value.ToString().Contains(tb_filtro.Text.ToUpper().Trim()))
                        {
                            Clientes encontrado = (Clientes)row.DataBoundItem;
                            dtFiltrado.Add(encontrado);
                        }
                    }



                    if (dtFiltrado.Count < 1)
                    {
                        MessageBox.Show("No se encontraron Clientes");
                    }
                    else
                    {
                        dgv.DataSource = dtFiltrado;
                    }

                }
                else
                {
                    if (radio_cliente.Checked == true)
                    {
                        List<Clientes> dtFiltrado = new List<Clientes>();

                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (int.Parse(row.Cells["DNI"].Value.ToString()) == int.Parse(tb_filtro.Text.Trim()))
                            {
                                Clientes encontrado = (Clientes)row.DataBoundItem;
                                dtFiltrado.Add(encontrado);
                            }
                        }


                        if (dtFiltrado.Count < 1)
                        {
                            MessageBox.Show("No se encontraron Clientes");
                        }
                        else
                        {
                            dgv.DataSource = dtFiltrado;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btn Filtrar evento Click \n" + ex.Message);
            }
        }

        private void tb_filtro_MouseClick(object sender, MouseEventArgs e)
        {
            tb_filtro.Text = "";
        }

        private void tb_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_filtrar.PerformClick();
                e.Handled = true;
            }
        }
    }
}
