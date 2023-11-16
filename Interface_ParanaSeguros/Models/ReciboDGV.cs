using System;

namespace Interface_ParanaSeguros.Models
{
    public class ReciboDGV
    {
        public int IdRecibo { get; set; }
        public DateTime FechaCobro { get; set; }
        public int Rama { get; set; }
        public int Poliza { get; set; }
        public int Endoso { get; set; }
        public decimal Importe { get; set; }
        public int Cuota { get; set; }
        public string Cliente { get; set; }
        public string Vehiculo { get; set; }
        public bool Agregar { get; set; }
        public string barra { get; set; }
        public int idcuota { get; set; }

        public ReciboDGV(Recibos rec)
        {
            using (MartinaPASEntities DB = new MartinaPASEntities())
            {
                Cuotas cuota = DB.Cuotas.Find(rec.idcuota);
                Endosos endoso = DB.Endosos.Find(cuota.idendoso);
                Polizas poliza = DB.Polizas.Find(endoso.idpoliza);

                this.IdRecibo = rec.IdRecibo;
                this.FechaCobro = (DateTime)rec.FechaCobro;
                this.Rama = int.Parse(poliza.Rama);
                this.Poliza = int.Parse(poliza.NumeroPoliza);
                this.Endoso = endoso.endoso;
                this.Importe = rec.Importe;
                this.Cuota = cuota.numero;
                this.Cliente = DB.Clientes.Find(poliza.IdCliente).ApellidoyNombre;
                this.Vehiculo = DB.Bienes.Find(endoso.idbien).Nombre;
                this.barra = rec.codigobarra;
                this.idcuota = rec.idcuota;


                this.Agregar = true;
            }
        }

    }
}
