using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int id, string username, string password, string nombre, string apellido, string nivel)
        {
            Id = id;
            Username = username;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Nivel = nivel;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nivel { get; set; }
    }
}
