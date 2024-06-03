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
    public class EntrenamientoRepository:ConexionBD
    {
        public string GuardarEntrenamientoBD(Entrenamiento entrenamiento)
        {
            string sql = "INSERT INTO entrenamientos(HoraInicio, HoraFinal, Rutinas) " +
                  "VALUES (@HoraInicio, @HoraFinal, @Rutinas)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@HoraInicio", entrenamiento.HoraInicio);
                comando.Parameters.AddWithValue("@HoraFinal", entrenamiento.HoraFinal);
                comando.Parameters.AddWithValue("@Rutinas", entrenamiento.Rutinas);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Entrenamiento no guardado";
                }
                if (res != 0)
                {
                    return "Entrenamiento guardado";
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
        //public List<Entrenamiento> ConsultarEntremiento()
        //{
        //    List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

        //    string ssql = $"select * from entrenamientos";

        //    MySqlConnection conexionBd = new MySqlConnection();
        //    conexionBd = conexion();

        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
        //        conexionBd.Open();
        //        var reader = comando.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            entrenamientos.Add(Map(reader));
        //        }
        //        return entrenamientos;
        //    }
        //    catch (MySqlException)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        conexionBd.Close();
        //    }
        //}

        //private Entrenamiento Map(MySqlDataReader reader)
        //{
        //    Entrenamiento Entrenamiento = new Entrenamiento();
        //    Entrenamiento.Id = reader.GetString(0);
        //    Entrenamiento.HoraInicio = reader.GetString(1);
        //    Entrenamiento.HoraFinal = reader.GetString(2);
        //    Entrenamiento.Rutinas = reader.GetString(3);
        //    Entrenamiento.Sexo = reader.GetString(4);
        //    entrenador.Correo = reader.GetString(5);
        //    string fechaNacimientoString = reader.GetString(6);
        //    DateTime fechaNacimiento;
        //    if (DateTime.TryParseExact(fechaNacimientoString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimiento))
        //    {
        //        entrenador.FechaNacimiento = fechaNacimiento;
        //    }
        //    return entrenador;
        //}
    }
}
