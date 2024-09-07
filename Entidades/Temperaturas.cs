using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Temperaturas
    {
        public Temperaturas(int id, int numero_sensor, int temperatura, bool estado_Sensor)
        {
            Id = id;
            Numero_sensor = numero_sensor;
            Temperatura = temperatura;
            Estado_Sensor = estado_Sensor;
        }

        public int Id { get; set; }
        public int Numero_sensor { get; set; }
        public int Temperatura {  get; set; }
        public Boolean Estado_Sensor { get; set; }
    }
}
