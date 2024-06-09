using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EjercicioRepository : ConexionBD
    {
        public string GuardarEjercicioBD(Ejercicio ejercicio)
        {
            string sql = "INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria,Foto) " +
                         "VALUES (@Nombre, @Descripcion, @Duracion, @Repeticiones, @Series, @Musculo, @Categoria, @Foto)";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);

                comando.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", ejercicio.Descripcion);
                comando.Parameters.AddWithValue("@Duracion", ejercicio.Duracion);
                comando.Parameters.AddWithValue("@Repeticiones", ejercicio.Repeticiones.HasValue ? (object)ejercicio.Repeticiones.Value : DBNull.Value);
                comando.Parameters.AddWithValue("@Series", ejercicio.Series.HasValue ? (object)ejercicio.Series.Value : DBNull.Value);
                comando.Parameters.AddWithValue("@Musculo", ejercicio.Musculo);
                comando.Parameters.AddWithValue("@Categoria", ejercicio.Categoria);
                comando.Parameters.AddWithValue("@Foto", ejercicio.Foto);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Ejercicio no guardado";
                }
                if (res != 0)
                {
                    return "Ejercicio guardado";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
            return null;
        }

        public List<Ejercicio> ConsultarEjercicio()
        {
            List<Ejercicio> Ejercicios = new List<Ejercicio>();

            string ssql = $"select * from ejercicios";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Ejercicios.Add(Map(reader));
                }
                Console.WriteLine("se esta llenando");
                return Ejercicios;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lista vacia ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        public List<Ejercicio> ConsultarEjercicioMusculo(string musculo)
        {
            List<Ejercicio> Ejercicios = new List<Ejercicio>();
            string ssql = $"select * from ejercicios where musculo = @musculo";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                // Añadir el parámetro a la consulta
                comando.Parameters.AddWithValue("@musculo", musculo);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Ejercicios.Add(Map(reader));
                }
                Console.WriteLine("se esta llenando");

                return Ejercicios;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lista vacia ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        public List<Ejercicio> ConsultarEjerciciosPorRutina(int rutinaId)
        {
            List<Ejercicio> ejercicios = new List<Ejercicio>();

            string ssql = "SELECT * " +
                  "FROM Rutinas_Ejercicios re " +
                  "INNER JOIN Ejercicios e ON re.Ejercicio_Nombre = e.Nombre " +
                  "WHERE re.Rutina_Id = @rutinaId";

            MySqlConnection conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                comando.Parameters.AddWithValue("@rutinaId", rutinaId);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.Nombre = reader.GetString(2);
                    ejercicio.Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3);
                    ejercicio.Duracion = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4);
                    ejercicio.Repeticiones = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5);
                    ejercicio.Series = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6);
                    ejercicio.Musculo = reader.GetString(7);
                    ejercicio.Categoria = reader.GetString(8);
                    ejercicio.Foto = reader.IsDBNull(9) ? null : (byte[])reader[9];
                }
                return ejercicios;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lista vacía ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        private Ejercicio Map(MySqlDataReader reader)
        {
            Ejercicio ejercicio = new Ejercicio();
            ejercicio.Nombre = reader.GetString(0);
            ejercicio.Descripcion = reader.IsDBNull(1) ? null : reader.GetString(1);
            ejercicio.Duracion = reader.IsDBNull(2) ? (TimeSpan?)null : reader.GetTimeSpan(2);
            ejercicio.Repeticiones = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3);
            ejercicio.Series = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
            ejercicio.Musculo = reader.GetString(5);
            ejercicio.Categoria = reader.GetString(6);
            ejercicio.Foto = reader.IsDBNull(7) ? null : (byte[])reader[7];
            return ejercicio;
        }
    }
}
