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
      


    }
}
