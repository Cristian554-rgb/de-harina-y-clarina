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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace SoftwareSensores
{
    public partial class FrmBuscarUsuarios : Form
    {
        ManejadorUsuarios mu;
        int fila = 0, columna = 0;
        public static int Id = 0, Nivel = 0;
        public static string Username = "", pass = "", Nombre = "", Apellido = "";

        private void dtgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        Id = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(Id, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString()); dtgvUsuarios.Visible = false;
                    }
                    break;
                case 5:
                    {
                        Id = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        Username = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                        pass = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                        Nombre = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                        Apellido = dtgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                        Nivel = int.Parse(dtgvUsuarios.Rows[fila].Cells[5].Value.ToString());


                        FrmUsuarios de = new FrmUsuarios();
                        de.ShowDialog();
                        dtgvUsuarios.Visible = false;
                    }
                    break;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true;
            mu.Mostrar(dtgvUsuarios, txtNombre.Text);
        }

        public FrmBuscarUsuarios()
        {
            mu = new ManejadorUsuarios();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Id = 0; Username = ""; pass = ""; Nombre = ""; Apellido = ""; Nivel = 0; 
            FrmUsuarios fu = new FrmUsuarios();
            fu.ShowDialog();
            txtNombre.Focus();
        }
    }
}
