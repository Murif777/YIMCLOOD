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

        private Entrenador Map(MySqlDataReader reader)
        {
            Entrenador entrenador = new Entrenador();
            entrenador.Cedula = reader.GetString(0);
            entrenador.Nombre = reader.GetString(1);
            entrenador.Apellido = reader.GetString(2);
            entrenador.Telefono = reader.GetString(3);
            entrenador.Sexo = reader.GetString(4);
            entrenador.Correo = reader.GetString(5);
            string fechaNacimientoString = reader.GetString(6);
            DateTime fechaNacimiento;
            if (DateTime.TryParseExact(fechaNacimientoString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimiento))
            {
                entrenador.FechaNacimiento = fechaNacimiento;
            }
            return entrenador;
        }
        public Entrenador ObtenerEntrenadorPorCed(string  Cedula)
        {
            Entrenador entrenador = null;
            string ssql = $"SELECT * FROM entrenadores WHERE Cedula = {Cedula}";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    entrenador = new Entrenador
                    {
                        Cedula = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Sexo = reader.GetString(4),
                        Correo = reader.GetString(5),
                        FechaNacimiento = reader.GetDateTime(6)
                    };
                }
            }
            catch (MySqlException )
            {
                return null;
            }
            finally
            {
                conexionBd.Close();
            }

            return entrenador;
        }
        public Entrenador ObtenerEntrenadorPorCedu(string cedula)
        {
            string ssql = "SELECT * FROM entrenadores WHERE Cedula = @Cedula";
            using (var conexionBd = conexion())
            {
                try
                {
                    conexionBd.Open();
                    MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                    comando.Parameters.AddWithValue("@Cedula", cedula);
                    var reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        return Map(reader);
                    }
                    return null;
                }
                catch (MySqlException)
                {
                    return null;
                }
            }
        }

    }
}
