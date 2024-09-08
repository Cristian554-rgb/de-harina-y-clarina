using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace SoftwareSensores
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin ml;
        public static string Username = "";
        public static int Id = 0;

        public FrmLogin()
        {
            ml = new ManejadorLogin();
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string[] r = new string[2];
            r = ml.validar(txtUsuario.Text, txtclave.Text);
            if (r[0].Equals("correcto"))
            {
                this.Hide();
                int nivelUsuario = int.Parse(r[1]);

                FrmMenu menu = new FrmMenu(nivelUsuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Problema de credenciales, verifique sus datos o hable con administracion.");
            }

        }
        private int ObtenerIDUsuario(string nick)
        {
            return ml.ObtenerIDUsuario(nick);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
