using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntramientoRepository:ConexionBD
    {
        public string GuardarEntrenamientoBD(Entrenamiento entrenamiento)
        {
            string sql = "INSERT INTO entrenamientos(HoraInicio,HoraFinal,Tiempo,Rutinas) " +
                  "VALUES (@HoraInicio,@HoraFinal,@Tiempo,@Rutinas)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@HoraInicio", entrenamiento.HoraInicio);
                comando.Parameters.AddWithValue("@HoraFinal", entrenamiento.HoraFinal);
                comando.Parameters.AddWithValue("@Tiempo", entrenamiento.Duracion());
                comando.Parameters.AddWithValue("@Rutinas", entrenamiento.Rutinas);
                comando.ExecuteNonQuery();
                return "Entrenamiento registrado";

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
