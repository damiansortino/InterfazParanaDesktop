//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interface_ParanaSeguros.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recibos
    {
        public int IdRecibo { get; set; }
        public Nullable<System.DateTime> FechaCobro { get; set; }
        public decimal Importe { get; set; }
        public System.DateTime fechaalta { get; set; }
        public Nullable<System.DateTime> fechabaja { get; set; }
        public int idcuota { get; set; }
        public string codigobarra { get; set; }
    
        public virtual Cuotas Cuotas { get; set; }
    }
}