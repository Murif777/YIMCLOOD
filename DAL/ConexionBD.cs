using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionBD
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "YIMCLOOD";
            string usuario = "usuario";
            string password = "654321";

            string cadenaConexion = "Database=" + bd
            + "; Data Source=" + servidor 
            + "; User Id= " + usuario 
            + "; Password=" + password +"";
            try
            {
                MySqlConnection conexionBd = new MySqlConnection(cadenaConexion);
                return conexionBd;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                return null;
            }
        }
    }
}
