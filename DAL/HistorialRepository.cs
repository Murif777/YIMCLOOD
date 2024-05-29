using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HistorialRepository:ConexionBD
    {
        public string GuardarHistorialBD(Historial historial)
        {
            string sql = "INSERT INTO historiales(Miembro, DiaDeLaSemana, Registro ,Entrenamiento) " +
                  "VALUES (@Miembro, @DiaDeLaSemana, @Registro, @Entrenamiento)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Miembro", historial.Miembro);
                comando.Parameters.AddWithValue("@DiaDeLaSemana", historial.DiaDeLaSemana);
                comando.Parameters.AddWithValue("@Registro", historial.Registro);
                comando.Parameters.AddWithValue("@Entrenamiento", historial.Entrenamiento);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Historial no guardado";
                }
                if (res != 0)
                {
                    return "Historial guardado";
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
