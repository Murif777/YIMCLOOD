using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntrenadorRepository:ConexionBD
    {
        public string GuardarEntrenadorBD(Entrenador entrenador)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            string sql = "INSERT INTO entrenadores(Cedula, Nombre, Apellido, Telefono, Sexo, Correo, FechaNacimiento,TipoMembresia, Foto) " +
                  "VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Sexo, @Correo, @FechaNacimiento,@TipoMembresia, @Foto)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Cedula", entrenador.Cedula);
                comando.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                comando.Parameters.AddWithValue("@Apellido", entrenador.Apellido);
                comando.Parameters.AddWithValue("@Telefono", entrenador.Telefono);
                comando.Parameters.AddWithValue("@Sexo", entrenador.Sexo);
                comando.Parameters.AddWithValue("@Correo", entrenador.Correo);
                comando.Parameters.AddWithValue("@FechaNacimiento", entrenador.FechaNacimiento.ToString("yyyy-MM-dd")); // Formato de fecha de MySQL
                comando.Parameters.AddWithValue("@TipoMembresia", entrenador.TipoMembresia);
                //comando.Parameters.AddWithValue("@Foto", entrenador.Foto);
                comando.ExecuteNonQuery();
                return $"Miembro registrado {usuarioRepository.GuardarUsuarioBD(null,entrenador)}";

            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
                //CerrarConexion();
            }

        }
    }
}
