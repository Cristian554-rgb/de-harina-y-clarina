using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
namespace SoftwareSensores
{
    public partial class FrmTemperaturas : Form
    {
        Funciones f = new Funciones();
   

        public FrmTemperaturas()
        {
            InitializeComponent();
          
        }
        public void ActualizarTemperatura1(float temperatura)
        {
            lblTemperatura1.Text = temperatura.ToString("F2"); // Ajusta según el control que uses
        }

        public void ActualizarTemperatura2(float temperatura)
        {
            lblTemperatura2.Text = temperatura.ToString("F2"); // Ajusta según el control que uses
        }
        // Método para borrar la temperatura del primer sensor
        public void BorrarTemperatura1()
        {
            lblTemperatura1.Text = string.Empty;
        }

        // Método para borrar la temperatura del segundo sensor
        public void BorrarTemperatura2()
        {
            lblTemperatura2.Text = string.Empty;
        }
        

        public void MostrarActivos(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from V_Temps_Activados where Numero_Sensor like '%{filtro}%'", "Temperaturas").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarGeneral(DataGridView tabla, string filtro)
        {
            
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from V_Temps_General where Numero_Sensor like '%{filtro}%'", "Temperaturas").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        private void btnHt_Click(object sender, EventArgs e)
        {
            btnHt.Click += new EventHandler(btnHt_Click);
            MostrarGeneral(dtgvHt, "");
        }
           
    }
}
