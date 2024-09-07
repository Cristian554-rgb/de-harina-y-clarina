using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSensores
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void optUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            fu.MdiParent = this;
            fu.Show();
        }

        private void optSensores_Click(object sender, EventArgs e)
        {
            FrmSensores fs = new FrmSensores();
            fs.MdiParent = this;
            fs.Show();
        }

        private void optTemperaturas_Click(object sender, EventArgs e)
        {
            FrmTemperaturas ft = new FrmTemperaturas();
            ft.MdiParent = this;
            ft.Show();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
