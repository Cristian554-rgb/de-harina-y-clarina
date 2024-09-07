using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Manejador
{
    public class ManejadorLogin
    {
        Funciones f = new Funciones();
        public string[] validar(string Username, string Password)
        {
            
            string[] resultado = new string[2];

            DataSet r = f.Mostrar($"call validar('{Username}'," +
                $"'{Sha1(Password)}')", "usuarios");

            
            if (r.Tables.Count > 0 && r.Tables[0].Rows.Count > 0)
            {
                DataTable dt = r.Tables[0];
                resultado[0] = dt.Rows[0]["rs"].ToString();
                resultado[1] = dt.Rows[0]["Nivel"].ToString();
            }
            else
            {
                // Manejar el caso en el que no se encuentren datos
                resultado[0] = "Error: No se encontraron datos";
                resultado[1] = "";
            }

            return resultado;

            /*DataTable dt = r.Tables[0];
            resultado[0] = dt.Rows[0]["rs"].ToString();
            resultado[1] = dt.Rows[0]["Nivel"].ToString();
            return resultado;*/
        }

        public int ObtenerIDUsuario(string user)
        {
            string query = $"SELECT Id FROM usuarios WHERE user = '{user}'";
            string idUsuarioStr = f.ObtenerDato(query, "usuarios", "Id");
            int idUsuario = 0;
            int.TryParse(idUsuarioStr, out idUsuario);
            return idUsuario;
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            byte[] textoOriginal = ASCIIEncoding.Default.GetBytes(texto);
            byte[] hash = sha1.ComputeHash(textoOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
