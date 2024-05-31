using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PNotificacionRepository:ConexionBD
    {
        public string GuardarPNotificacionBD(PerfilNotificacion pNotificacion)
        {
            string sql = "INSERT INTO perfilNotificacion(TipoNotificacion, DatosMiembro) " +
                  "VALUES (@TipoNotificacion, @DatosMiembro)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@TipoNotificacion", pNotificacion.TipoNotificacion);
                comando.Parameters.AddWithValue("@DatosMiembro", pNotificacion.DatosMiembro);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Perfil notificacion no guardada";
                }
                if (res != 0)
                {
                    return "Perfil notificacion guardadaa";
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

