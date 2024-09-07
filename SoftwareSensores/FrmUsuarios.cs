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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public FrmUsuarios()
        {
            mu = new ManejadorUsuarios();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (FrmBuscarUsuarios.Id > 0)
            {
                mu.Modificar(txtUsername, txtPassword, txtNombre, txtApellidos, cmbNivel, FrmBuscarUsuarios.Id);
            }
            else
            {
                mu.Guardar(txtUsername, txtPassword, txtNombre, txtApellidos, cmbNivel);
            }
            Close();
        }
    }
}
