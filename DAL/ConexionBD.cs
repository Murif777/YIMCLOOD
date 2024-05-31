using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionBD
    {
        private string servidor = "127.0.0.1";
        private string bd = "yimclood";
        private string usuario = "root";
        private string password = "123456";
        public  MySqlConnection conexion()
        {
            string cadenaConexion = $"Server={servidor};" +
                $"Database={bd};" +
                $"Uid={usuario};" +
                $"Pwd={password};";

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
