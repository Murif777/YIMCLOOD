using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
