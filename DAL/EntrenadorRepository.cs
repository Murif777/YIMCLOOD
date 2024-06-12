using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
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
            string sql = "INSERT INTO entrenadores(Cedula, Nombre, Apellido, Telefono, Sexo, Correo_Electronico, Fecha_Nacimiento, Foto) " +
                  "VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Sexo, @Correo, @FechaNacimiento, @Foto)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                //comando.Parameters.AddWithValue("@Id", entrenador.Id);
                comando.Parameters.AddWithValue("@Cedula", entrenador.Cedula);
                comando.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                comando.Parameters.AddWithValue("@Apellido", entrenador.Apellido);
                comando.Parameters.AddWithValue("@Telefono", entrenador.Telefono);
                comando.Parameters.AddWithValue("@Sexo", entrenador.Sexo);
                comando.Parameters.AddWithValue("@Correo", entrenador.Correo);
                comando.Parameters.AddWithValue("@FechaNacimiento", entrenador.FechaNacimiento.ToString("yyyy-MM-dd")); 
                comando.Parameters.AddWithValue("@Foto", entrenador.Foto);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Entrenador no guardado";
                }
                if (res != 0)
                {
                    return $"Entrenador registrado";

                }
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
            return null;

        }
        public List<Entrenador> Consultar()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();

            string ssql = $"select * from entrenadores";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    entrenadores.Add(Map(reader));
                }
                return entrenadores;
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        public List<Entrenador> ConsultarCed(string cedula)
        {

            List<Entrenador> entrenadores = new List<Entrenador>();

            string ssql = $"SELECT * FROM entrenadores WHERE Cedula = {cedula}";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    entrenadores.Add(Map(reader));
                }
                if (entrenadores == null)
                {
                    Console.WriteLine("lista vacia");
                    return null;
                }
                return entrenadores;
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        private Entrenador Map(MySqlDataReader reader)
        {
            Entrenador entrenador = new Entrenador();
            entrenador.Cedula = reader.GetString(reader.GetOrdinal("Cedula"));
            entrenador.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
            entrenador.Apellido = reader.GetString(reader.GetOrdinal("Apellido"));
            entrenador.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
            entrenador.Sexo = reader.GetString(reader.GetOrdinal("Sexo"));
            entrenador.Correo = reader.GetString(reader.GetOrdinal("Correo_Electronico"));
            entrenador.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("Fecha_Nacimiento"));

            if (!reader.IsDBNull(reader.GetOrdinal("Foto")))
            {
                entrenador.Foto = (byte[])reader["Foto"];
            }
            else
            {
                entrenador.Foto = null;
            }

            return entrenador;
        }
        public string EliminarEntrenador(string cedulaEntrenador)
        {
            MySqlConnection conexionBd = null;
            MySqlTransaction transaction = null;

            try
            {
                conexionBd = conexion();
                conexionBd.Open();
                transaction = conexionBd.BeginTransaction();

                string sqlEliminarMembresiasUsuarios = "DELETE FROM Membresias_Usuarios WHERE Correo_Usuario IN (SELECT Correo_Electronico FROM Usuarios WHERE Ced_Entrenador = @CedulaEntrenador)";
                using (MySqlCommand comandoEliminarMembresiasUsuarios = new MySqlCommand(sqlEliminarMembresiasUsuarios, conexionBd, transaction))
                {
                    comandoEliminarMembresiasUsuarios.Parameters.AddWithValue("@CedulaEntrenador", cedulaEntrenador);
                    comandoEliminarMembresiasUsuarios.ExecuteNonQuery();
                }


                string sqlEliminarUsuarios = "DELETE FROM Usuarios WHERE Ced_Entrenador = @CedulaEntrenador";
                using (MySqlCommand comandoEliminarUsuarios = new MySqlCommand(sqlEliminarUsuarios, conexionBd, transaction))
                {
                    comandoEliminarUsuarios.Parameters.AddWithValue("@CedulaEntrenador", cedulaEntrenador);
                    comandoEliminarUsuarios.ExecuteNonQuery();
                }


                string sqlEliminarEntrenador = "DELETE FROM Entrenadores WHERE Cedula = @CedulaEntrenador";
                using (MySqlCommand comandoEliminarEntrenador = new MySqlCommand(sqlEliminarEntrenador, conexionBd, transaction))
                {
                    comandoEliminarEntrenador.Parameters.AddWithValue("@CedulaEntrenador", cedulaEntrenador);
                    int filasAfectadas = comandoEliminarEntrenador.ExecuteNonQuery();


                    if (filasAfectadas == 0)
                    {

                        transaction.Rollback();
                        return "Entrenador no encontrado";
                    }
                }

                transaction.Commit();
                return "Entrenador eliminado correctamente";
            }
            catch (MySqlException ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                return "Error al eliminar el entrenador: " + ex.Message;
            }
            finally
            {
                if (conexionBd != null)
                {
                    conexionBd.Close();
                }
            }
        }

        public string ActualizarEntrenador(Entrenador entrenador)
        {
            string query = "UPDATE Entrenadores SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono," +
                           " Sexo=@Sexo, Correo_Electronico=@Correo, " +
                           "Fecha_Nacimiento=@FechaNacimiento, Foto=@Foto WHERE Cedula=@Cedula";

            MySqlConnection conexionBd = conexion(); 

            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(query, conexionBd);
                comando.Parameters.AddWithValue("@Cedula", entrenador.Cedula);
                comando.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                comando.Parameters.AddWithValue("@Apellido", entrenador.Apellido);
                comando.Parameters.AddWithValue("@Telefono", entrenador.Telefono);
                comando.Parameters.AddWithValue("@Sexo", entrenador.Sexo);
                comando.Parameters.AddWithValue("@Correo", entrenador.Correo);
                comando.Parameters.AddWithValue("@FechaNacimiento", entrenador.FechaNacimiento);
                comando.Parameters.AddWithValue("@Foto", entrenador.Foto);

                int res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Entrenador no actualizado";
                }
                return "Entrenador actualizado exitosamente";
            }
            catch (MySqlException ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }




    }
}
