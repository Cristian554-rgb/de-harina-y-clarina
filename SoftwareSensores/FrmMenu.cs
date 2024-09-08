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
        private int nivelUsuario;

        public FrmMenu(int nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            if (nivelUsuario == 1)
            {
                optUsuarios.Visible = true;
                optTemperaturas.Visible = true;
                optSensores.Visible = true;
            }
            else if (nivelUsuario == 2)
            {
                optUsuarios.Visible = false;
                optTemperaturas.Visible = true;
                optSensores.Visible = true;
            }
            else if (nivelUsuario == 3)
            {
                optUsuarios.Visible = false;
                optTemperaturas.Visible = false;
                optSensores.Visible = true;
            }
        }

        private void optUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            
            fu.Show();
        }

        private void optSensores_Click(object sender, EventArgs e)
        {
            FrmTemperaturas frmTemperaturas = new FrmTemperaturas();
            FrmSensores frmSensores = new FrmSensores(frmTemperaturas);
            frmSensores.Show();
        }

        private void optTemperaturas_Click(object sender, EventArgs e)
        {
            FrmTemperaturas ft = new FrmTemperaturas();
            
            ft.Show();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
