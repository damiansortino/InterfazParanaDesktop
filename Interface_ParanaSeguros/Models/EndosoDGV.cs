using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ParanaSeguros.Models
{
    public class EndosoDGV
    {
        public int id { get; set; }
        public int idpoliza { get; set; }
        public int endoso { get; set; }
        public Nullable<int> suplemento { get; set; }
        public Nullable<System.DateTime> fechavigenciadesde { get; set; }
        public Nullable<System.DateTime> fechavigenciahasta { get; set; }
        public int cantidadcuotas { get; set; }
        public int idbien { get; set; }
        public string asociada { get; set; }

        public EndosoDGV(Endosos end)
        {
            id = end.id;
            idpoliza = end.idpoliza;
            endoso = end.endoso;
            suplemento = end.suplemento;
            fechavigenciadesde = end.fechavigenciadesde;
            fechavigenciahasta = end.fechavigenciahasta;
            cantidadcuotas = end.cantidadcuotas;
            idbien = end.idbien;
            asociada = end.asociada;
        }
    }
}
