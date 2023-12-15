using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
