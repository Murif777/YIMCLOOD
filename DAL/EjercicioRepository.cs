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
    public class EjercicioRepository:ConexionBD
    {
        public string GuardarEjercicioBD(Ejercicio ejercicio)
        {
            string sql = "INSERT INTO ejercicios(Nombre, Descripcion , Duracion , Repeticiones , Categoria) " +
                  "VALUES (@Nombre, @Descripcion, @Duracion, @Repeticiones, @Categoria)";
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
                comando.Parameters.AddWithValue("@Categoria", ejercicio.Categoria);
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
                return Ejercicios;
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

        private Ejercicio Map(MySqlDataReader reader)
        {
            Ejercicio ejercicio = new Ejercicio();
            ejercicio.Nombre = reader.GetString(0);
            ejercicio.Descripcion = reader.GetString(1);
            ejercicio.Duracion =TimeSpan.Parse(reader.GetString(2));
            ejercicio.Repeticiones = int.Parse(reader.GetString(3));
            ejercicio.Categoria.Nombre = reader.GetString(4);
            return ejercicio;
        }
    }
}
