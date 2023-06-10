using Interface_ParanaSeguros.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class Planillas_Cobranzas : Form
    {
        List<ReciboDGV> mostrar = new List<ReciboDGV>();

        public Planillas_Cobranzas()
        {
            InitializeComponent();
        }

        private void Planillas_Cobranzas_Load(object sender, EventArgs e)
        {
            btn_GenerarPlanilla.Enabled = false;
        }
        private void btn_Cobrados_Click(object sender, EventArgs e)
        {
            mostrar.Clear();

            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    var query = from a in DB.Recibos

                                join b in DB.Cuotas on a.idcuota equals b.id
                                join c in DB.Endosos on b.idendoso equals c.id
                                join d in DB.Polizas on c.idpoliza equals d.IdPoliza
                                join f in DB.Clientes on d.IdCliente equals f.IdCliente
                                join g in DB.Bienes on c.idbien equals g.Id


                                where (a.fechabaja == null)

                                select new
                                {
                                    Id = a.IdRecibo

                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Recibos recibo = DB.Recibos.Find(item.Id);
                        ReciboDGV registroDG = new ReciboDGV(recibo);
                        mostrar.Add(registroDG);
                    }

                    dgv.DataSource = null;
                    dgv.DataSource = mostrar;
                    dgv.ReadOnly = false;
                    groupBox1.Visible = true;

                    //llenar labels
                    decimal suma = 0;
                    foreach (ReciboDGV valor in mostrar)
                    {
                        suma = suma + valor.Importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                ActivarFiltrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button Cobrados \n" + ex.Message);
            }

        }

        private void ActivarFiltrado()
        {
            try
            {
                if (dgv.Rows.Count >= 5)
                {
                    gb_filtro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error aplicando el filtrado \n" + ex.Message);
            }
        }

        private void btn_ProxConvenio_Click(object sender, EventArgs e)
        {
            mostrar.Clear();
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime proximoconvenio;

                    DateTime fechaActual = DateTime.Now;
                    int dia = fechaActual.Day;

                    if (dia <= 3)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 3);
                    }
                    else if (dia > 3 && dia <= 18)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 18);
                    }
                    else
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.AddMonths(1).Month, 3);
                    }


                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id

                                where (b.convenio <= proximoconvenio && a.fechabaja == null)
                                select new
                                {
                                    Id = a.IdRecibo

                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Recibos recibo = DB.Recibos.Find(item.Id);
                        ReciboDGV registroDG = new ReciboDGV(recibo);
                        mostrar.Add(registroDG);
                    }


                    dgv.DataSource = null;
                    dgv.DataSource = mostrar;
                    groupBox1.Visible = true;


                    //llenar labels
                    decimal suma = 0;
                    foreach (ReciboDGV valor in mostrar)
                    {
                        suma = suma + valor.Importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                dgv.ReadOnly = false;
                ActivarFiltrado();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button \n" + ex.Message);
            }

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_poliza.Checked == true)
                {
                    // Crear una nueva tabla para almacenar las filas encontradas
                    DataTable dtFiltrado = new DataTable();

                    // Clonar la estructura de columnas del DataGridView
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        dtFiltrado.Columns.Add(col.Name, col.ValueType);
                    }

                    // Agregar las filas que coinciden con el valor de búsqueda a la tabla
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells["Poliza"].Value.ToString() == tb_filtro.Text)
                        {
                            DataRow dr = dtFiltrado.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dr[cell.ColumnIndex] = cell.Value;
                            }
                            dtFiltrado.Rows.Add(dr);
                        }
                    }

                    // Asignar la tabla filtrada como origen de datos del DataGridView
                    //dgv.DataSource = dtFiltrado;

                    // Ahora tienes una lista de los valores de las filas que contienen el valor buscado en la columna especificada                   

                    if (dtFiltrado.Rows.Count < 1)
                    {
                        MessageBox.Show("No se encontraron recibos");
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
                        // Crear una nueva tabla para almacenar las filas encontradas
                        DataTable dtFiltrado = new DataTable();

                        // Clonar la estructura de columnas del DataGridView
                        foreach (DataGridViewColumn col in dgv.Columns)
                        {
                            dtFiltrado.Columns.Add(col.Name, col.ValueType);
                        }

                        // Agregar las filas que coinciden con el valor de búsqueda a la tabla
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.Cells["Cliente"].Value.ToString().Contains(tb_filtro.Text.ToUpper().Trim()))
                            {
                                DataRow dr = dtFiltrado.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dr[cell.ColumnIndex] = cell.Value;
                                }
                                dtFiltrado.Rows.Add(dr);
                            }
                        }

                        // Ahora tienes una lista de los valores de las filas que contienen el valor buscado en la columna especificada                   

                        if (dtFiltrado.Rows.Count < 1)
                        {
                            MessageBox.Show("No se encontraron recibos");
                        }
                        else
                        {
                            dgv.DataSource = dtFiltrado;
                        }
                    }
                    else
                    {
                        // busqueda por patente

                        // Crear una nueva tabla para almacenar las filas encontradas
                        DataTable dtFiltrado = new DataTable();

                        // Clonar la estructura de columnas del DataGridView
                        foreach (DataGridViewColumn col in dgv.Columns)
                        {
                            dtFiltrado.Columns.Add(col.Name, col.ValueType);
                        }

                        // Agregar las filas que coinciden con el valor de búsqueda a la tabla
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.Cells["Vehiculo"].Value.ToString().Contains(tb_filtro.Text.ToUpper().Trim()))
                            {
                                DataRow dr = dtFiltrado.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dr[cell.ColumnIndex] = cell.Value;
                                }
                                dtFiltrado.Rows.Add(dr);
                            }
                        }

                        if (dtFiltrado.Rows.Count < 1)
                        {
                            MessageBox.Show("No se encontraron recibos");
                        }
                        else
                        {
                            dgv.DataSource = dtFiltrado;
                        }
                    }
                }

                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                gb_filtro.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btn Filtrar evento Click \n" + ex.Message);
            }

        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgv.ReadOnly = false;
            // Obtén el objeto que se está editando
            ReciboDGV editar = (ReciboDGV)dgv.Rows[e.RowIndex].DataBoundItem;

            // Actualiza la propiedad booleana
            if (e.ColumnIndex == dgv.Columns["Agregar"].Index)
            {
                editar.Agregar = (bool)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void tb_filtro_MouseClick(object sender, MouseEventArgs e)
        {
            tb_filtro.Text = "";
            tb_filtro.Focus();
        }

        private void tb_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_filtrar.PerformClick();
                e.Handled = true;
            }
        }

        private void btn_fdc_Click(object sender, EventArgs e)
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
                                join c in DB.Endosos on b.idendoso equals c.id
                                join d in DB.Polizas on c.idpoliza equals d.IdPoliza
                                join f in DB.Clientes on d.IdCliente equals f.IdCliente
                                join g in DB.Bienes on c.idbien equals g.Id
                                join h in DB.Cuotas on a.idcuota equals h.id
                                where (b.convenio <= convenio_pasado && a.fechabaja == null)
                                select new
                                {
                                    Fecha_de_cobro = a.fechaalta,
                                    Rama = d.Rama,
                                    Poliza = d.NumeroPoliza,
                                    Endoso = c.endoso,
                                    importe = a.Importe,
                                    Cuota = h.numero,
                                    VtoCliente = b.vencimiento,
                                    VtoConvenio = b.convenio,
                                    Cliente = f.ApellidoyNombre,
                                    Auto = g.Nombre,
                                    Agregar = true
                                };
                    var result = query.ToList();
                    dgv.DataSource = null;
                    dgv.DataSource = result;
                    groupBox1.Visible = true;


                    //llenar labels
                    decimal suma = 0;
                    foreach (var valor in result)
                    {
                        suma = suma + valor.importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }

                dgv.ReadOnly = false;
                ActivarFiltrado();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button Cobrados \n" + ex.Message);
            }
        }

        private void btn_GenerarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                btn_GenerarPlanilla.Enabled = false;

                List<Recibo_Planilla> recibos_rendir = new List<Recibo_Planilla>();

                foreach (DataGridViewRow item in dgv.Rows)
                {
                    if ((bool)item.Cells[9].Value == true)
                    {
                        Recibo_Planilla nuevo = new Recibo_Planilla(item);
                        recibos_rendir.Add(nuevo);
                    }
                }

                //////////////////////////////////////////////////

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";
                saveFileDialog1.Title = "Guardar archivo CSV";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var lineas = new List<string>();
                    var linea = "rama;poliza;endoso;importe;cuota";
                    lineas.Add(linea);

                    foreach (var recibo in recibos_rendir)
                    {
                        var lineaitera = $"{recibo.rama};{recibo.poliza};{recibo.endoso};{recibo.importe};{recibo.cuota}";
                        lineas.Add(lineaitera);
                    }
                    File.WriteAllLines(saveFileDialog1.FileName, lineas);

                    dgv.DataSource = null;
                    MessageBox.Show("Archivo guardado exitosamente.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando planilla \n" + ex.Message);
            }
        }

        private void btn_ActualizarRendidos_Click(object sender, EventArgs e)
        {
            RecibosCobrados cobrados = new RecibosCobrados();
            cobrados.ShowDialog();
        }

        private void btn_UltimasCuotas_Click(object sender, EventArgs e)
        {
            mostrar.Clear();
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime proximoconvenio;

                    DateTime fechaActual = DateTime.Now;
                    int dia = fechaActual.Day;

                    if (dia <= 3)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 3);
                    }
                    else if (dia > 3 && dia <= 18)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 18);
                    }
                    else
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.AddMonths(1).Month, 3);
                    }


                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id
                                join c in DB.Endosos on b.idendoso equals c.id

                                where ((b.convenio <= proximoconvenio && a.fechabaja == null) && (c.cantidadcuotas == b.numero))
                                select new
                                {
                                    Id = a.IdRecibo

                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Recibos recibo = DB.Recibos.Find(item.Id);
                        ReciboDGV registroDG = new ReciboDGV(recibo);
                        mostrar.Add(registroDG);
                    }


                    dgv.DataSource = null;
                    dgv.DataSource = mostrar;
                    groupBox1.Visible = true;


                    //llenar labels
                    decimal suma = 0;
                    foreach (ReciboDGV valor in mostrar)
                    {
                        suma = suma + valor.Importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                dgv.ReadOnly = false;
                ActivarFiltrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button \n" + ex.Message);
            }
        }

        private void btn_menos3_Click(object sender, EventArgs e)
        {
            mostrar.Clear();
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime proximoconvenio;

                    DateTime fechaActual = DateTime.Now;
                    int dia = fechaActual.Day;

                    if (dia <= 3)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 3);
                    }
                    else if (dia > 3 && dia <= 18)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 18);
                    }
                    else
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.AddMonths(1).Month, 3);
                    }


                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id

                                where ((b.convenio <= proximoconvenio && a.fechabaja == null) && (a.Importe <= 3000))
                                select new
                                {
                                    Id = a.IdRecibo

                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Recibos recibo = DB.Recibos.Find(item.Id);
                        ReciboDGV registroDG = new ReciboDGV(recibo);
                        mostrar.Add(registroDG);
                    }


                    dgv.DataSource = null;
                    dgv.DataSource = mostrar;
                    groupBox1.Visible = true;


                    //llenar labels
                    decimal suma = 0;
                    foreach (ReciboDGV valor in mostrar)
                    {
                        suma = suma + valor.Importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                dgv.ReadOnly = false;
                ActivarFiltrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button \n" + ex.Message);
            }
        }

        private void btn_menos1_Click(object sender, EventArgs e)
        {
            mostrar.Clear();
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime proximoconvenio;

                    DateTime fechaActual = DateTime.Now;
                    int dia = fechaActual.Day;

                    if (dia <= 3)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 3);
                    }
                    else if (dia > 3 && dia <= 18)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 18);
                    }
                    else
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.AddMonths(1).Month, 3);
                    }


                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id

                                where ((b.convenio <= proximoconvenio && a.fechabaja == null) && (a.Importe <= 1000))
                                select new
                                {
                                    Id = a.IdRecibo

                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Recibos recibo = DB.Recibos.Find(item.Id);
                        ReciboDGV registroDG = new ReciboDGV(recibo);
                        mostrar.Add(registroDG);
                    }


                    dgv.DataSource = null;
                    dgv.DataSource = mostrar;
                    groupBox1.Visible = true;


                    //llenar labels
                    decimal suma = 0;
                    foreach (ReciboDGV valor in mostrar)
                    {
                        suma = suma + valor.Importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                dgv.ReadOnly = false;
                ActivarFiltrado();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button \n" + ex.Message);
            }

        }

        private void btn_menos10_Click(object sender, EventArgs e)
        {
            mostrar.Clear();
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime proximoconvenio;

                    DateTime fechaActual = DateTime.Now;
                    int dia = fechaActual.Day;

                    if (dia <= 3)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 3);
                    }
                    else if (dia > 3 && dia <= 18)
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.Month, 18);
                    }
                    else
                    {
                        proximoconvenio = new DateTime(fechaActual.Year, fechaActual.AddMonths(1).Month, 3);
                    }


                    var query = from a in DB.Recibos
                                join b in DB.Cuotas on a.idcuota equals b.id

                                where ((b.convenio <= proximoconvenio && a.fechabaja == null) && (a.Importe <= 10000))
                                select new
                                {
                                    Id = a.IdRecibo

                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Recibos recibo = DB.Recibos.Find(item.Id);
                        ReciboDGV registroDG = new ReciboDGV(recibo);
                        mostrar.Add(registroDG);
                    }


                    dgv.DataSource = null;
                    dgv.DataSource = mostrar;
                    groupBox1.Visible = true;


                    //llenar labels
                    decimal suma = 0;
                    foreach (ReciboDGV valor in mostrar)
                    {
                        suma = suma + valor.Importe;
                    }

                    lbl_Suma.Text = "Total $ " + suma.ToString();

                    lbl_CantidadRecibos.Text = result.Count().ToString() + " Recibos listos para agregar";

                    //fin llenar labels
                }
                if (dgv.Rows.Count > 0)
                {
                    btn_GenerarPlanilla.Enabled = true;

                }
                dgv.ReadOnly = false;
                ActivarFiltrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en button \n" + ex.Message);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
