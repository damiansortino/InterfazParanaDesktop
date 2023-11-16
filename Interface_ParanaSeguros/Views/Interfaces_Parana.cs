using System;
using System.Windows.Forms;

namespace Interface_ParanaSeguros.Views
{
    public partial class Interfaces_Parana : Form
    {
        public Interfaces_Parana()
        {
            InitializeComponent();
        }

        private void Interfaces_Parana_Load(object sender, EventArgs e)
        {
            lblpath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
            lbl_path_Cobranzas.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

        }
    }
}
