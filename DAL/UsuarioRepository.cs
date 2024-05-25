using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository
    {
        public static string GuardarUsuarioBD(string CorreoElectronico, string Clave)
        {
            string sql = "INSERT INTO usuarios(CorreoElectronico, Clave) VALUES" +
                "('" + CorreoElectronico + "','" + Clave + "')";
            MySqlConnection conexion = ConexionBD.conexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                return "Usuario registrado";

            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static string login(string CorreoElectronico, string Clave)
        {
            MySqlDataReader reader = null;
            string sql = "SELECT CorreoElectronico, Clave" +
                " FROM usuarios " +
                "WHERE CorreoElectronico = '" + CorreoElectronico +
                "' AND Clave = '" + Clave +
                "' LIMIT 1";
            MySqlConnection Conexion = ConexionBD.conexion();
            try
            {
                Conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    return "Acesso exitoso";
                }
                else
                {
                    return "Correo electronico o contraseña incorrectos ";
                }
            }
            catch (MySqlException ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                Conexion.Close();
            }
        }
    }
}
