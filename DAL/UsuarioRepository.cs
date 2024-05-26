using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository:ConexionBD
    {
        public string GuardarUsuarioBD(Usuario usuario)
        {
            string sql = "INSERT INTO usuarios(CorreoElectronico, Clave) VALUES" +
                "('" + usuario.CorreoElectronico + "','" + usuario.Clave + "')";
            try
            {
                AbrirConexion();
                MySqlCommand comando = new MySqlCommand(sql,conexion());
                comando.ExecuteNonQuery();
                return "Usuario registrado";
            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public string login(Usuario usuario)
        {
            MySqlDataReader reader = null;
            string sql = "SELECT CorreoElectronico, Clave" +
                " FROM usuarios " +
                "WHERE CorreoElectronico = '" + usuario.CorreoElectronico +
                "' AND Clave = '" + usuario.Clave +
                "' LIMIT 1";
            try
            {
                AbrirConexion();
                MySqlCommand comando = new MySqlCommand(sql, conexion());
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
                CerrarConexion();
            }
        }
    }
}
