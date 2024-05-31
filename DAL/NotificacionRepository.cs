using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NotificacionRepository:ConexionBD
    {
        public string GuardarNotificacionBD(Notificacion notificacion)
        {
            string sql = "INSERT INTO notificaciones(Id,TipoNotificacion,Mensaje) " +
                  "VALUES (@Id, @TipoNotificacion, @Mensaje)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Id", notificacion.Id);
                comando.Parameters.AddWithValue("@TipoNotificacion", notificacion.TipoNotificacion);
                comando.Parameters.AddWithValue("@Mensaje", notificacion.Mensaje);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Notificacion no guardada";
                }
                if (res != 0)
                {
                    return "Notificacion guardada";
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
