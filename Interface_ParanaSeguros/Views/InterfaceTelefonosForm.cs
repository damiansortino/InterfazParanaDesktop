using Interface_ParanaSeguros.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class InterfaceTelefonosForm : Form
    {
        public InterfaceTelefonosForm()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.ShowDialog();
                lblpath.Text = ofd.FileName;
                if (Path.GetExtension(lblpath.Text).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    btnProcesar.Enabled = true;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error abriendo el archivo \n" + ex.Message);
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {

                int cantidadoperaciones = 0;
                int encontrados = 0;
                int actualizados = 0;

                // Ruta del archivo de interfaz
                string rutaArchivo = lblpath.Text;


                // Leer el archivo de interfaz
                string[] lineasArchivo = File.ReadAllLines(rutaArchivo);
                cantidadoperaciones = lineasArchivo.Count();


                // Crear una instancia del contexto de Entity Framework
                using (var contexto = new MartinaPASEntities())
                {
                    foreach (string linea in lineasArchivo)
                    {

                        // Leer los campos de cada registro en el archivo de interfaz
                        string dni = int.Parse(linea.Substring(linea.Length - 10).Trim()).ToString();
                        string telefono = linea.Substring(614, 20).Trim();

                        //MessageBox.Show(dni + "\n" +telefono);

                        // Buscar el cliente por DNI en la tabla "Clientes"
                        var cliente = contexto.Clientes.FirstOrDefault(c => c.DNI == dni);

                        if (cliente != null)
                        {
                            encontrados++;
                        }

                        if (cliente != null)
                        {
                            // Verificar si el campo de teléfono es nulo
                            if (string.IsNullOrEmpty(cliente.Telefono))
                            {

                                // Actualizar el campo de teléfono en el objeto cliente y guardar los cambios en la base de datos
                                cliente.Telefono = telefono;
                                contexto.SaveChanges();
                                actualizados++;
                            }
                        }
                    }
                }

                MessageBox.Show("Procesamiento completado correctamente. \n " + cantidadoperaciones + " Registros encontrados \n "
                    + encontrados + " Clientes coincidentes \n " + actualizados + " Clientes actualizados correctamente.");
                this.Close();



                /////////////
                ///
                /*      

         if (File.Exists(lblpath.Text))
         {
             try
             {
                 File.Delete(lblpath.Text);  // Borra el archivo
                 lblpath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
                 btnProcesar.Enabled = false;

             }
             catch (Exception error)
             {
                 MessageBox.Show("No se puede borrar el archivo de interface" + "\n \n" + error.Message);
             }

         }

         MessageBox.Show("Archivo de interface procesado correctamente \n" + cantidadoperaciones +
             " operaciones totales. \n " + automotoresymotos + " agregados a su base de datos (autom y motos) \n" +
             anulaciones + " anulaciones");
         gb_Interfaces.Visible = false;
         */
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo procesar el archivo de interface correctamente" + "\n \n" + ex.Message + ex.StackTrace);
            }

        }
    }
}
