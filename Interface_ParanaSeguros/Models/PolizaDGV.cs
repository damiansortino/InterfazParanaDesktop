using System;
using System.Linq;

namespace Interface_ParanaSeguros.Models
{
    class PolizaDGV
    {

        public int IdPoliza { get; set; }
        public string Estado { get; set; }
        public string Rama { get; set; }
        public string NumeroPoliza { get; set; }
        public string Asegurado { get; set; }
        public DateTime? Vig_Desde { get; set; }
        public DateTime? Vig_Hasta { get; set; }
        public int IdCliente { get; set; }
        public string InfoAdicional { get; set; }
        public PolizaDGV(Polizas poli)
        {
            using (MartinaPASEntities DB = new MartinaPASEntities())
            {
                IdPoliza = poli.IdPoliza;
                Estado = poli.Estado;
                Rama = poli.Rama;
                NumeroPoliza = poli.NumeroPoliza;
                Vig_Desde = poli.FechaInicio;
                Vig_Hasta = poli.FechaFin;
                IdCliente = poli.IdCliente;
                Asegurado = DB.Clientes.Find(poli.IdCliente).ApellidoyNombre;

                if (poli.Rama == "4" || poli.Rama == "14")
                {
                    this.InfoAdicional = DB.Bienes.Find((DB.Endosos.ToList().FindAll(x => x.idpoliza == poli.IdPoliza).FirstOrDefault().idbien)).Nombre;
                }
                else
                {
                    this.InfoAdicional = "";
                }

            }
        }

    }
}
