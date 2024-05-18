using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BILL
{
    public class UsuarioService
    {
        public static void Conexion(string CorreoElectronico, string Clave)
        {
            string sql = "INSERT INTO usuarios(CorreoElectronico, Clave) VALUES" +
                "('" + CorreoElectronico + "','" + Clave + "')";
            MySqlConnection conexion = ConexionBD.conexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar" + ex.Message);
            }
            finally
            {
                conexion.Close(); 
            }
        }
        public static void login(string CorreoElectronico, string Clave) 
        {
            MySqlDataReader reader= null;
            string sql = "SELECT CorreoElectronico, Clave" +
                " FROM usuarios " +
                "WHERE CorreoElectronico = '" + CorreoElectronico + 
                "' AND Clave = '" + Clave +
                "' LIMIT 1";
            MySqlConnection Conexion = ConexionBD.conexion();
            try
            {
                Conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql,Conexion);
                reader= comando.ExecuteReader();
                if(reader.HasRows)
                {
                    MessageBox.Show("Acesso exitoso");

                }
                else
                {
                    MessageBox.Show("Correo electronico o contraseña incorrectos ");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
            finally 
            {
                Conexion.Close();
            }
        }
    }
}
