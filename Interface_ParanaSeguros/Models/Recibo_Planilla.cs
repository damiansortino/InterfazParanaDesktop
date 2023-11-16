using System.Windows.Forms;

namespace Interface_ParanaSeguros.Models
{
    class Recibo_Planilla
    {
        public string rama { get; set; }
        public string poliza { get; set; }
        public string endoso { get; set; }
        public string importe { get; set; }
        public string cuota { get; set; }
        public Recibo_Planilla(object objeto)
        {
            DataGridViewRow obj = (DataGridViewRow)objeto;
            rama = obj.Cells[2].Value.ToString();
            poliza = obj.Cells[3].Value.ToString();
            endoso = obj.Cells[4].Value.ToString();
            importe = obj.Cells[5].Value.ToString().Replace(",", ".");
            cuota = obj.Cells[6].Value.ToString();
        }

    }
}
