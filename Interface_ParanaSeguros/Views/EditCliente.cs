using Interface_ParanaSeguros.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class EditCliente : Form
    {
        public EditCliente()
        {
            InitializeComponent();
        }

        int idcliente;

        public EditCliente(Clientes editar)
        {
            InitializeComponent();
            try
            {
                idcliente = editar.IdCliente;

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    tb_apellido.Text = editar.ApellidoyNombre;
                    tb_DNI.Text = editar.DNI;
                    if (editar.FechaNacimiento is null)
                    {
                        MessageBox.Show("Debe agregar la fecha de nacimiento del cliente");
                        dtp_FechaNac.Value = DateTime.Now.Date;
                    }
                    else
                    {
                        dtp_FechaNac.Value = editar.FechaNacimiento.Value;
                    }

                    tb_Direccion.Text = editar.Direccion;
                    tb_Tel.Text = editar.Telefono;
                    tb_Ciudad.Text = editar.Ciudad;
                    tb_Provincia.Text = editar.Provincia;
                    tb_Email.Text = editar.email;
                    tb_Cuil.Text = editar.CUIT_CUIL;
                    rt_Observaciones.Text = editar.observaciones;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Iniciando Form Editar Cliente \n" + ex.Message);
            }


        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    Clientes editar = DB.Clientes.Find(idcliente);

                    editar.ApellidoyNombre = tb_apellido.Text;
                    editar.DNI = tb_DNI.Text;
                    editar.FechaNacimiento = dtp_FechaNac.Value;
                    editar.Direccion = tb_Direccion.Text;
                    editar.Telefono = tb_Tel.Text;
                    editar.Ciudad = tb_Ciudad.Text;
                    editar.Provincia = tb_Provincia.Text;
                    editar.email = tb_Email.Text;
                    editar.CUIT_CUIL = tb_Cuil.Text;
                    editar.observaciones = rt_Observaciones.Text;

                    // Adjuntar el objeto cliente al contexto
                    DB.Clientes.Attach(editar);

                    // Marcar el estado del objeto como modificado
                    DB.Entry(editar).State = EntityState.Modified;

                    // Guardar los cambios en la base de datos
                    DB.SaveChanges();

                    MessageBox.Show("Cliente actualizado correctamente");
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Actualizando cliente en base de datos \n" + ex.Message);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
