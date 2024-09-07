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
        public string[] validar(string _User, string _pass)
        {
            
            string[] resultado = new string[2];

            DataSet r = f.Mostrar($"call p_validar('{_User}'," +
                $"'{Sha1(_pass)}')", "usuarios");
            DataTable dt = r.Tables[0];
            resultado[0] = dt.Rows[0]["rs"].ToString();
            resultado[1] = dt.Rows[0]["Nivel"].ToString();
            return resultado;
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
