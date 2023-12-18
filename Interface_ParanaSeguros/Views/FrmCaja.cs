using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class FrmCaja : Form
    {
        private static FrmCaja instance;

        public static FrmCaja Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public FrmCaja()
        {
            InitializeComponent();
        }

        private void btn_Cobrar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ExisteCajaAbierta())
                {
                    FrmCobrar_Caja nuevocobro = new FrmCobrar_Caja();
                    nuevocobro.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Debe iniciar caja primero");
                    btn_IniciarCaja.PerformClick();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private bool ExisteCajaAbierta()
        {
            /// programar esto
            return true;
        }
    }
}
