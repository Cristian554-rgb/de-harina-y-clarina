using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSensores
{
    public partial class FrmSensores : Form
    {
        private FrmTemperaturas frmTemperaturas;
        private Random random = new Random();

        public FrmSensores(FrmTemperaturas temperaturas)
        {
            InitializeComponent();

            frmTemperaturas = temperaturas;
            frmTemperaturas.Hide(); // Oculta el formulario al inicio
            timerSensor1.Stop();
            timerSensor2.Stop();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            btnActivar.BackColor = Color.Green;
            timerSensor1.Start();

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            btnDesactivar.BackColor = Color.Red;
            timerSensor1.Stop();
            frmTemperaturas.BorrarTemperatura1();

        }


        private void btnActivar2_Click(object sender, EventArgs e)
        {
            btnActivar2.BackColor = Color.Green;
            timerSensor2.Start();
        }

        private void btnDesactivar2_Click(object sender, EventArgs e)
        {
            btnDesactivar2.BackColor = Color.Red;
            timerSensor2.Stop();
            frmTemperaturas.BorrarTemperatura2();

        }


        private float ObtenerTemperaturaAleatoria()
        {
            // Genera una temperatura aleatoria entre 20 y 30 grados Celsius
            return (float)(20 + random.NextDouble() * 10); // Ajusta el rango según tus necesidades
        }


        private void timerSensor1_Tick(object sender, EventArgs e)
        {
            float temperatura = ObtenerTemperaturaAleatoria();
            frmTemperaturas.ActualizarTemperatura1(temperatura);
        }
        private void timerSensor2_Tick(object sender, EventArgs e)
        {
            float temperatura = ObtenerTemperaturaAleatoria();
            frmTemperaturas.ActualizarTemperatura2(temperatura);
        }
    }
}
