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
        private string servidor = "localhost";
        private string bd = "yimclood";
        private string usuario = "root";
        private string password = "123456";
        public MySqlConnection conexion()
        {
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
        public bool AbrirConexion()
        {
            if (conexion().State != ConnectionState.Open)
            {
                conexion().Open();
                return true;
            }
            return false;
        }
        public void CerrarConexion()
        {
            conexion().Close();
        }
    }
}
