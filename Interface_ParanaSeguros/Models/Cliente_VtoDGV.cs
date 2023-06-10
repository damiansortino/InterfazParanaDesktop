using System;

namespace Interface_ParanaSeguros.Models
{
    public class Cliente_VtoDGV
    {
        public string Poliza { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public string Asegurado { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Endoso { get; set; }
        public int Cuota { get; set; }
        public string BienAsegurado { get; set; }
        public bool Enviar { get; set; }


        public Cliente_VtoDGV()
        {


        }

        public Cliente_VtoDGV(int idpoliza, int idbien, int idcuota, int idendoso)
        {
            using (MartinaPASEntities DB = new MartinaPASEntities())
            {
                Polizas capturada = DB.Polizas.Find(idpoliza);
                Poliza = capturada.NumeroPoliza;
                VigenciaDesde = capturada.FechaInicio.Value;
                VigenciaHasta = capturada.FechaFin.Value;
                Asegurado = DB.Clientes.Find(capturada.IdCliente).ApellidoyNombre;
                Vencimiento = DB.Cuotas.Find(idcuota).vencimiento;
                Endoso = DB.Endosos.Find(idendoso).endoso;
                Cuota = DB.Cuotas.Find(idcuota).numero;
                BienAsegurado = DB.Bienes.Find(idbien).Nombre;
                Enviar = true;
            }



        }

    }
}
