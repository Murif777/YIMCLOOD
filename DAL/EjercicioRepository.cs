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
            string sql = "INSERT INTO ejercicios(Nombre, Descripcion , Duracion , Repeticiones , Series, Musculo,  Categoria, Foto) " +
                  "VALUES (@Nombre, @Descripcion , @Duracion , @Repeticiones , @Series, @Musculo,  @Categoria, @Foto)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", ejercicio.Descripcion);
                comando.Parameters.AddWithValue("@Duracion", ejercicio.Duracion);
                comando.Parameters.AddWithValue("@Repeticiones", ejercicio.Repeticiones);
                comando.Parameters.AddWithValue("@Series", ejercicio.Series);
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
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
                //CerrarConexion();
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

            // Usar parámetros en la consulta SQL para evitar inyección SQL
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

        private Ejercicio Map(MySqlDataReader reader)
        {
            Ejercicio ejercicio = new Ejercicio();
            ejercicio.Nombre = reader.GetString(0);
            ejercicio.Descripcion = reader.GetString(1);
            ejercicio.Duracion = TimeSpan.Parse(reader.GetString(2));
            ejercicio.Repeticiones = int.Parse(reader.GetString(3));
            ejercicio.Series = int.Parse(reader.GetString(4));
            ejercicio.Musculo = reader.GetString(5);
            ejercicio.Categoria = reader.GetString(6);
            ejercicio.Foto = reader.IsDBNull(7) ? null : (byte[])reader[7];
            return ejercicio;
        }
    }
}
