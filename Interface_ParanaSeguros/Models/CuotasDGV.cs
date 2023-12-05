using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ParanaSeguros.Models
{
    public class CuotasDGV
    {
        public int id { get; set; }
        public int numero { get; set; }
        public DateTime vencimiento { get; set; }
        public DateTime convenio { get; set; }
        public decimal valor { get; set; }
        public bool pagada { get; set; }

        public CuotasDGV(Cuotas cuota)
        {
            this.id = cuota.id;
            this.numero = cuota.numero;
            this.vencimiento = cuota.vencimiento;
            this.convenio = cuota.convenio;
            this.valor = cuota.valor;
            this.pagada = cuota.pagada;
        }
    }
}
