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
        public string GuardarUsuarioBD(Miembro miembro, Entrenador entrenador)
        {

            string sql = "INSERT INTO usuarios(CorreoElectronico, Clave) VALUES" +
                "(@Correo,@Clave)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                if (entrenador == null) 
                {
                    comando.Parameters.AddWithValue("@Correo", miembro.DatosUsuario.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Clave", miembro.DatosUsuario.Clave);
                }
                if(miembro==null) 
                {
                    comando.Parameters.AddWithValue("@Correo", entrenador.DatosUsuario.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Clave", entrenador.DatosUsuario.Clave);
                }
                comando.ExecuteNonQuery();
                return "Usuario registrado";

            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        public string ActualizaUsuarioBD(Usuario usuario)
        {
            return null;//agregar actualizar
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
                //AbrirConexion();
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
                //CerrarConexion();
            }
        }
    }
}
