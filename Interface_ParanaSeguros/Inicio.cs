using Interface_ParanaSeguros.Models;
using Interface_ParanaSeguros.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
namespace Interface_ParanaSeguros
{
    public partial class Inicio : Form
    {
        string[] filenames;
        string[] filenames_cobranzas;

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Multiselect = true;
            ofd.ShowDialog();
            filenames = ofd.FileNames;
            lblpath.Text = ofd.InitialDirectory;

            bool bandera = false;

            foreach (string fn in filenames)
            {
                if (!(Path.GetExtension(fn).Equals(".xml", StringComparison.OrdinalIgnoreCase) && fn.Contains("EMISION")))
                {
                    bandera = true;
                }
            }
            if (!bandera)
            {
                btnProcesar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error, solo pueden procesarse archivos *xml de EMISION");
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            gb_Interfaces.Visible = false;

            lblpath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
            lbl_path_Cobranzas.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();

            ProcessTablaRecibos();
            ActualizarEstadosPoliza();
        }

        private void ActualizarEstadosPoliza()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    var query = from a in DB.Polizas
                                where a.Estado != "Anulada"
                                select new
                                {
                                    Id = a.IdPoliza
                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Polizas modificar = DB.Polizas.Find(item.Id);
                        if (modificar.FechaFin < DateTime.Now.Date)
                        {
                            modificar.Estado = "Vencida";
                            DB.SaveChanges();
                        }
                        else
                        {
                            if (modificar.FechaInicio > DateTime.Now.Date)
                            {
                                modificar.Estado = "Emitida";
                                DB.SaveChanges();
                            }
                            else
                            {
                                modificar.Estado = "Vigente";
                                DB.SaveChanges();
                            }

                        }
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error actualizando estado de póliza \n" + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            //logica del procesamiento de archivos xml
            try
            {
                foreach (string file in filenames)
                {
                    int cantidadoperaciones = 0;
                    int automotoresymotos = 0;
                    int anulaciones = 0;
                    int autovida = 0;
                    int incendio = 0;
                    int ap = 0;
                    int vivienda = 0;

                    XmlDocument archivo = new XmlDocument();
                    archivo.Load(file);

                    foreach (XmlNode elemento in archivo.DocumentElement.ChildNodes[6].ChildNodes)
                    {
                        cantidadoperaciones++;

                        if (elemento.SelectSingleNode("tipo").InnerText == "21")
                        {
                            AnularPoliza(elemento);
                            anulaciones++;
                        }
                        else
                        {   //PROCESAR RAMA AUTOS Y MOTOS
                            if (elemento.Name == "operacion" && ((elemento.ChildNodes[0].InnerText == "4") || (elemento.ChildNodes[0].InnerText == "14")))
                            {
                                automotoresymotos++;

                                if (elemento.SelectSingleNode("tipo").InnerText != "10")
                                {
                                    //logica nuevas operaciones autos y motos
                                    AgregarRefacturacion(elemento);
                                }
                                else
                                {
                                    //logica procesamiento de endosos modificaciones
                                }

                                /*
                                if (elemento.ChildNodes[13].Name == "motivo" && ((elemento.ChildNodes[13].InnerText == "GENERAL") ||
                                    ((elemento.ChildNodes[13].InnerText == "REFACTURACION") || (elemento.ChildNodes[13].InnerText == "SIN ESPECIFICAR"))))
                                {
                                    AgregarRefacturacion(elemento);

                                }
                                */

                            }
                            else
                            {
                                if (elemento.Name == "operacion" && ((elemento.ChildNodes[0].InnerText == "19")))
                                {
                                    autovida++;
                                }
                                else
                                {
                                    if (elemento.Name == "operacion" && ((elemento.ChildNodes[0].InnerText == "12")))
                                    {
                                        ap++;
                                    }
                                    else
                                    {
                                        if (elemento.Name == "operacion" && ((elemento.ChildNodes[0].InnerText == "24")))
                                        {
                                            vivienda++;
                                        }
                                        else
                                        {
                                            if (elemento.Name == "operacion" && ((elemento.ChildNodes[0].InnerText == "1")))
                                            {
                                                incendio++;
                                            }
                                            else
                                            {
                                                //seguir anudando logicas para embarcaciones, cauciones y resto de las ramas
                                            }
                                        }

                                    }

                                }
                            }

                        }
                        //volver a procesar anulaciones por si hay emisión y anulación el mismo día.
                        if (elemento.SelectSingleNode("tipo").InnerText == "21")
                        {
                            AnularPoliza(elemento);
                        }

                    }

                    if (File.Exists(file))
                    {
                        try
                        {
                            File.Delete(file);  // Borra el archivo
                            lblpath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
                            btnProcesar.Enabled = false;

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("No se puede borrar el archivo de interface" + "\n \n" + error.Message);
                        }

                    }
                    int faltan = cantidadoperaciones - (automotoresymotos + anulaciones + autovida + incendio + ap + vivienda);

                    MessageBox.Show("Archivo de interface procesado correctamente \n" + cantidadoperaciones +
                        " operaciones totales. \n " + automotoresymotos + " agregados a su base de datos (autom y motos) \n" +
                        anulaciones + " anulaciones \n" + autovida + " polizas auto-vida \n" + faltan + " faltan procesar");

                    gb_Interfaces.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo procesar el archivo de interface correctamente" + "\n \n" + ex.Message);
            }
        }

        private void AnularPoliza(XmlNode elemento)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    string numeropoliza = int.Parse(elemento.SelectSingleNode("poliza").InnerText).ToString();
                    var query = from a in DB.Polizas
                                where (a.Estado != "Anulada" && a.NumeroPoliza == numeropoliza)
                                select new
                                {
                                    Id = a.IdPoliza
                                };
                    var resultado = query.ToList();

                    if (resultado.Count == 0)
                    {
                        //no hacer nada
                    }
                    else
                    {
                        if (resultado.Count > 1)
                        {
                            MessageBox.Show("Alerta!, polizas duplicadas");
                        }
                        else
                        {
                            Polizas eliminar = DB.Polizas.Find(resultado[0].Id);
                            eliminar.Estado = "Anulada";
                            DB.SaveChanges();
                        }


                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error anulando póliza \n" + ex.Message);
            }
        }

        private void AgregarRefacturacion(XmlNode elemento)
        {
            try
            {
                //Clientes

                ActualizarClientes(elemento.SelectSingleNode("tomador"));
                ActualizarAutos(elemento.SelectSingleNode("bienes"));
                ActualizarBienes(elemento.SelectSingleNode("bienes"));

                /*
                foreach (XmlNode item in elemento.ChildNodes)
                {
                    if (item.Name == "tomador")
                    {
                        ActualizarClientes(item);
                    }
                    else
                    {
                        if (item.Name == "bienes")
                        {
                            //Autos y bienes
                            ActualizarAutos(item);
                            ActualizarBienes(item);
                        }

                    }
                }
                */

                /*
                //Autos y bienes
                foreach (XmlNode item in elemento.ChildNodes)
                {
                    
                }
                */

                //aqui validamos la existencia de la póliza para evitar errores en la base de datos

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    string policha = elemento.SelectSingleNode("poliza").InnerText;

                    var query = from p in DB.Polizas
                                where (p.NumeroPoliza == policha)

                                select new
                                {
                                    numeropoliza = p.NumeroPoliza,
                                };

                    var resultado = query.ToList();
                    if (resultado.Count != 0)
                    {
                        //no hacer nada
                    }
                    else
                    {
                        NuevaPoliza(elemento);

                    }

                }
                //se crea el endoso
                ActualizarEndosos(elemento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando refacturaciones" + "\n" + ex.Message);
            }

        }

        private void ActualizarBienes(XmlNode elemento)
        {
            try
            {
                bool flota = false;
                if (elemento.ChildNodes.Count > 1)
                {
                    flota = true;
                }

                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    DateTime nuevodesde, nuevohasta;
                    nuevodesde = DateTime.Parse(elemento.ChildNodes[0].ChildNodes[7].InnerText);
                    nuevohasta = DateTime.Parse(elemento.ChildNodes[0].ChildNodes[8].InnerText);


                    if (flota == false)
                    {
                        string patente = elemento.ChildNodes[0].SelectSingleNode("auto").SelectSingleNode("dominio").InnerText;
                        var query_bienes = from g in DB.Bienes
                                           join f in DB.Autos on g.idAuto equals f.Id
                                           where ((g.Desde == nuevodesde && g.Hasta == nuevohasta) && (f.Dominio == patente))
                                           select new
                                           {
                                               idbienes = g.Id
                                           };

                        var results = query_bienes.ToList();


                        if (results.Count() < 1)
                        {

                            XmlNode bieninterfaz = elemento.ChildNodes[0];

                            Bienes nuevobien = new Bienes();
                            nuevobien.Item = int.Parse(bieninterfaz.ChildNodes[0].InnerText);



                            nuevobien.Nombre = bieninterfaz.ChildNodes[1].InnerText;
                            nuevobien.idAuto = DB.Autos.OrderByDescending(x => x.Id).FirstOrDefault().Id;


                            nuevobien.Domicilio = "";
                            nuevobien.Ubicacion = "";
                            nuevobien.Ciudad = bieninterfaz.ChildNodes[4].InnerText;
                            nuevobien.Provincia = bieninterfaz.ChildNodes[5].InnerText;
                            nuevobien.Acreedor = "";
                            nuevobien.Desde = DateTime.Parse(bieninterfaz.ChildNodes[7].InnerText).Date;
                            nuevobien.Hasta = DateTime.Parse(bieninterfaz.ChildNodes[8].InnerText).Date;

                            DB.Bienes.Add(nuevobien);
                            DB.SaveChanges();
                        }

                    }
                    else
                    {
                        /*
                        XmlNode bieninterfaz = elemento.ChildNodes[0];
                        Bienes nuevobien = new Bienes();
                        nuevobien.Item = int.Parse(bieninterfaz.ChildNodes[0].InnerText);

                        nuevobien.Nombre = "Flota";
                        //nuevobien.idAuto = DB.Autos.OrderByDescending(x => x.Id).FirstOrDefault().Id;

                        nuevobien.Domicilio = "";
                        nuevobien.Ubicacion = "";
                        nuevobien.Ciudad = bieninterfaz.ChildNodes[4].InnerText;
                        nuevobien.Provincia = bieninterfaz.ChildNodes[5].InnerText;
                        nuevobien.Acreedor = "";
                        nuevobien.Desde = DateTime.Parse(bieninterfaz.ChildNodes[7].InnerText).Date;
                        nuevobien.Hasta = DateTime.Parse(bieninterfaz.ChildNodes[8].InnerText).Date;

                        DB.Bienes.Add(nuevobien);
                        DB.SaveChanges();
                        */
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Actualizando bienes" + "\n" + ex.Message);
            }
        }

        private int CantidadCuotas(XmlNode elemento)
        {
            int cantidad = 0;
            foreach (XmlNode cuota in elemento.ChildNodes)
            {
                cantidad++;
            }
            return cantidad;
        }

        private void NuevaPoliza(XmlNode elemento)
        {
            try
            {
                Polizas nueva = new Polizas();
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    string dni = "";

                    foreach (XmlNode nodo in elemento.ChildNodes)
                    {
                        if (nodo.Name == "tomador")
                        {
                            dni = nodo.ChildNodes[1].InnerText;
                        }
                    }

                    var query = from d in DB.Clientes
                                where (d.DNI == dni)
                                select new
                                {
                                    clienteid = d.IdCliente
                                };

                    var result = query.ToList();
                    nueva.IdCliente = result[0].clienteid;


                    foreach (XmlNode nodo in elemento.ChildNodes)
                    {
                        if (nodo.Name == "ramo")
                        {
                            nueva.Rama = nodo.InnerText;
                        }
                        if (nodo.Name == "poliza")
                        {
                            nueva.NumeroPoliza = nodo.InnerText;
                        }
                        if (nodo.Name == "desde")
                        {
                            nueva.FechaInicio = DateTime.Parse(nodo.InnerText);
                        }
                        if (nodo.Name == "fin")
                        {
                            nueva.FechaFin = DateTime.Parse(nodo.InnerText);
                        }
                    }
                    nueva.Estado = "Emitida";
                    if (nueva.FechaInicio >= DateTime.Now.Date)
                    {
                        nueva.Estado = "Vigente";
                    }
                    DB.Polizas.Add(nueva);
                    DB.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando pólizas" + "\n" + ex.Message);
            }
        }

        private void ActualizarAutos(XmlNode item)
        {

            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    foreach (XmlNode bien in item.ChildNodes)
                    {
                        foreach (XmlNode auto in bien.ChildNodes)
                        {
                            if (auto.Name == "auto")
                            {
                                string domin = auto.ChildNodes[3].InnerText;

                                var query_autos = from f in DB.Autos
                                                  where f.Dominio == domin
                                                  select new
                                                  {
                                                      idauto = f.Id
                                                  };
                                var result_auto = query_autos.ToList();

                                if (result_auto.Count != 0)
                                {
                                    //se encontró el auto, no se hace nada
                                }
                                else
                                {
                                    Autos nuevo = new Autos();
                                    nuevo.MarcaModelo = bien.ChildNodes[1].InnerText;
                                    nuevo.Dominio = auto.ChildNodes[3].InnerText;
                                    nuevo.Anio = int.Parse(auto.ChildNodes[2].InnerText);
                                    nuevo.Chasis = auto.ChildNodes[4].InnerText;
                                    nuevo.Motor = auto.ChildNodes[5].InnerText;
                                    nuevo.Tipo = auto.ChildNodes[6].InnerText;
                                    nuevo.Uso = auto.ChildNodes[7].InnerText;
                                    nuevo.GNC = auto.ChildNodes[8].InnerText;
                                    nuevo.Color = "otro";
                                    DB.Autos.Add(nuevo);
                                    DB.SaveChanges();
                                }

                            }




                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando autos" + "\n" + ex.Message);
            }
        }

        private void ActualizarEndosos(XmlNode item)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    //validar la existencia del endoso

                    string poli = item.SelectSingleNode("poliza").InnerText;
                    int endo = int.Parse(item.SelectSingleNode("endoso").InnerText);
                    string aso = item.SelectSingleNode("asociada").InnerText;

                    var queryendosos = from a in DB.Endosos
                                       join b in DB.Polizas on a.idpoliza equals b.IdPoliza

                                       where (b.NumeroPoliza == poli) && (a.endoso == endo)

                                       select new
                                       {
                                           idendoso = a.id
                                       };

                    var resultendosos = queryendosos.ToList();

                    // MessageBox.Show("poliza "+ item.SelectSingleNode("poliza").InnerText + "\n endoso "+ item.SelectSingleNode("endoso").InnerText + "\n asociada "+ item.SelectSingleNode("asociada").InnerText);

                    if (resultendosos.Count == 0)
                    {
                        Endosos nuevo = new Endosos();
                        nuevo.idpoliza = DB.Polizas.ToList().Find(x => x.NumeroPoliza == item.ChildNodes[1].InnerText).IdPoliza;
                        nuevo.endoso = int.Parse(item.ChildNodes[2].InnerText);
                        nuevo.fechavigenciadesde = DateTime.Parse(item.ChildNodes[5].InnerText).Date;
                        nuevo.fechavigenciahasta = DateTime.Parse(item.ChildNodes[6].InnerText).Date;

                        foreach (XmlNode nodos in item.ChildNodes)
                        {
                            if (nodos.Name == "cuotas")
                            {
                                nuevo.cantidadcuotas = CantidadCuotas(nodos);
                            }
                        }

                        nuevo.idbien = DB.Bienes.OrderByDescending(x => x.Id).FirstOrDefault().Id;
                        string asoc = item.SelectSingleNode("asociada").InnerText;
                        nuevo.asociada = asoc;
                        nuevo.suplemento = int.Parse(item.SelectSingleNode("suplemento").InnerText);
                        DB.Endosos.Add(nuevo);
                        DB.SaveChanges();


                        //se crean las cuotas de la refacturacion

                        foreach (XmlNode nodito in item.ChildNodes)
                        {
                            if (nodito.Name == "cuotas")
                            {
                                int cantidad = CantidadCuotas(nodito);
                                ActualizarCuotas(nodito, cantidad);
                            }
                        }

                    }
                    else
                    {
                        if (resultendosos.Count == 1)
                        {
                            //si encuentra el endoso
                            //no hacer nada
                        }
                        else
                        {
                            MessageBox.Show("Error Endoso");
                        }



                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error actualizando endosos" + "\n" + ex.Message);
            }

        }

        private void ActualizarCuotas(XmlNode item, int cantidad)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        Cuotas nuevacuota = new Cuotas();
                        nuevacuota.numero = int.Parse(item.ChildNodes[i].ChildNodes[0].InnerText);
                        nuevacuota.vencimiento = DateTime.Parse(item.ChildNodes[i].ChildNodes[1].InnerText).Date;
                        nuevacuota.convenio = DateTime.Parse(item.ChildNodes[i].ChildNodes[2].InnerText).Date;

                        string monto = item.ChildNodes[i].ChildNodes[3].InnerText.Replace(".", ",");

                        nuevacuota.valor = decimal.Parse(monto);

                        nuevacuota.pagada = false;
                        nuevacuota.idendoso = DB.Endosos.OrderByDescending(x => x.id).FirstOrDefault().id;
                        DB.Cuotas.Add(nuevacuota);
                        DB.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al agregar cuotas a la base de datos (ActualizarCuotas())" + "\n" + ex.Message);
            }
        }

        private void ActualizarClientes(XmlNode item)
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    string dniclientesearch = item.SelectSingleNode("dni").InnerText;

                    var query_cliente = from f in DB.Clientes
                                        where f.DNI == dniclientesearch
                                        select new
                                        {
                                            idcliente = f.IdCliente
                                        };

                    var resultado_clientes = query_cliente.ToList();

                    if (resultado_clientes.Count != 0)
                    {

                    }
                    else
                    {
                        Clientes nuevo = new Clientes();
                        nuevo.ApellidoyNombre = item.ChildNodes[0].InnerText;
                        nuevo.DNI = item.ChildNodes[1].InnerText;
                        nuevo.CUIT_CUIL = item.ChildNodes[3].InnerText;
                        nuevo.Direccion = item.ChildNodes[4].InnerText;
                        nuevo.Ciudad = item.ChildNodes[6].InnerText + " - " + item.ChildNodes[5].InnerText;
                        nuevo.Provincia = item.ChildNodes[7].InnerText;
                        DB.Clientes.Add(nuevo);
                        DB.SaveChanges();
                    }

                    /*

                    foreach (XmlNode dni in item.ChildNodes)
                    {
                        if (dni.Name == "dni")
                        {
                            Clientes prueba = DB.Clientes.ToList().Find(x => x.DNI.Trim() == dni.InnerText.Trim());
                            if (prueba != null)
                            {
                                return;
                            }
                            else
                            {
                                Clientes nuevo = new Clientes();
                                nuevo.ApellidoyNombre = item.ChildNodes[0].InnerText;
                                nuevo.DNI = item.ChildNodes[1].InnerText;
                                nuevo.CUIT_CUIL = item.ChildNodes[3].InnerText;
                                nuevo.Direccion = item.ChildNodes[4].InnerText;
                                nuevo.Ciudad = item.ChildNodes[6].InnerText + " - " + item.ChildNodes[5].InnerText;
                                nuevo.Provincia = item.ChildNodes[7].InnerText;
                                DB.Clientes.Add(nuevo);
                                DB.SaveChanges();
                            }
                        }
                    }

                    */


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error actualizando clientes" + "\n" + ex.Message);
            }
        }

        private void btn_AgregarRecibos_Click(object sender, EventArgs e)
        {
            Agregar_Recibos AgregarDB = new Agregar_Recibos();
            AgregarDB.ShowDialog();
        }

        private void btn_Examinar_2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Multiselect = true;
            ofd.ShowDialog();
            lbl_path_Cobranzas.Text = ofd.InitialDirectory;
            filenames_cobranzas = ofd.FileNames;
            btn_Procesar_Cobranzas.Enabled = false;

            bool bandera_cobranzas = false;

            foreach (string fnc in filenames_cobranzas)
            {
                if (!(Path.GetExtension(fnc).Equals(".xml", StringComparison.OrdinalIgnoreCase) && fnc.Contains("COBRANZA")))
                {
                    bandera_cobranzas = true;
                }
            }
            if (!bandera_cobranzas)
            {
                btn_Procesar_Cobranzas.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error, solo pueden procesarse archivos *xml de COBRANZAS");
            }

        }


        private void btn_Procesar_Cobranzas_Click(object sender, EventArgs e)
        {
            //logica del procesamiento de archivos xml
            try
            {
                ProcessTablaRecibos();

                foreach (string fnc in filenames_cobranzas)
                {
                    int contador = 0;
                    XmlDocument archivo = new XmlDocument();
                    archivo.Load(fnc);

                    var registros = archivo.GetElementsByTagName("cobranza");


                    List<XmlNode> pagosinterface = new List<XmlNode>();
                    foreach (XmlNode item in registros)
                    {
                        if ((item.SelectSingleNode("tipo").InnerText == "ND") && ((item.SelectSingleNode("ramo").InnerText == "4") || (item.SelectSingleNode("ramo").InnerText == "14")))
                        {
                            pagosinterface.Add(item);
                        }
                    }

                    using (MartinaPASEntities DB = new MartinaPASEntities())
                    {
                        var cuotas_query = from t1 in DB.Cuotas
                                           join t2 in DB.Endosos on t1.idendoso equals t2.id
                                           join t3 in DB.Polizas on t2.idpoliza equals t3.IdPoliza
                                           select new
                                           {
                                               idcuota = t1.id,
                                               numero = t1.numero,
                                               endoso = t2.endoso,
                                               poliza = t3.NumeroPoliza,
                                               pagada = t1.pagada
                                           };
                        var resultados = cuotas_query.ToList();

                        foreach (var cuota in resultados)
                        {
                            if (cuota.pagada != true)
                            {
                                foreach (XmlNode cobranza in pagosinterface)
                                {
                                    if (((cuota.poliza == cobranza.SelectSingleNode("poliza").InnerText)
                                        && (cuota.endoso == int.Parse(cobranza.SelectSingleNode("endoso").InnerText)))
                                        && (cuota.numero == int.Parse(cobranza.SelectSingleNode("cuota").InnerText)))
                                    {
                                        Cuotas actualizar = DB.Cuotas.Find(cuota.idcuota);
                                        actualizar.pagada = true;
                                        DB.SaveChanges();
                                        contador++;
                                    }
                                }
                            }

                        }
                    }

                    if (File.Exists(fnc))
                    {
                        try
                        {
                            File.Delete(fnc);  // Borra el archivo
                            lbl_path_Cobranzas.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
                            btnProcesar.Enabled = false;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("No se puede borrar el archivo de interface" + "\n \n" + error.Message);
                        }

                    }

                    MessageBox.Show("Cobranza actualizada correctamente, se han agregado " + contador + " registros a su base de datos");
                    gb_Interfaces.Visible = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("no se pudo procesar el archivo de interface correctamente" + "\n \n" + ex.Message);
            }
        }


        private void ProcessTablaRecibos()
        {
            try
            {
                using (MartinaPASEntities DB = new MartinaPASEntities())
                {
                    var query = from t in DB.Cuotas
                                join h in DB.Recibos on t.id equals h.idcuota
                                where (t.pagada == false)
                                select new
                                {
                                    idcuota = t.id
                                };
                    var result = query.ToList();

                    foreach (var item in result)
                    {
                        Cuotas actualizar = DB.Cuotas.Find(item.idcuota);
                        actualizar.pagada = true;
                        DB.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error procesando tabla Recibos \n" + ex.Message);
            }
        }

        private void btn_GenerarPlanillas_Click(object sender, EventArgs e)
        {
            Planillas_Cobranzas nueva = new Planillas_Cobranzas();
            nueva.ShowDialog();
        }

        private void btn_Interfaces_Click(object sender, EventArgs e)
        {
            gb_Interfaces.Visible = true;
        }

        private void btn_ActualizarRendidos_Click(object sender, EventArgs e)
        {
            try
            {
                RecibosCobrados cobrados = new RecibosCobrados();
                cobrados.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Abriendo Form 'RecibosCobrados' \n" + ex.Message);
            }
        }

        private void gb_Interfaces_Leave(object sender, EventArgs e)
        {
            gb_Interfaces.Visible = false;
        }

        private void btn_AvisosVTO_Click(object sender, EventArgs e)
        {
            try
            {
                AvisosVTO nuevo = new AvisosVTO();
                nuevo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error abriendo módulo Vencimientos \n" + ex.Message);
            }
        }





        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Clientes_Form clientes = new Clientes_Form();
            clientes.ShowDialog();
        }



        private void btn_Polizas_Click(object sender, EventArgs e)
        {
            try
            {
                PolizasForm polizas = new PolizasForm();
                polizas.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Caja_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrmCaja.Instance == null || FrmCaja.Instance.IsDisposed)
                {
                    FrmCaja.Instance = new FrmCaja();
                    FrmCaja.Instance.Show();
                }
                else
                {
                    FrmCaja.Instance.WindowState = FormWindowState.Maximized;
                    FrmCaja.Instance.BringToFront();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
    }
}
