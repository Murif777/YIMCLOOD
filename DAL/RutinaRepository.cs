using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RutinaRepository:ConexionBD
    {
        public string GuardarRutinaBD(Rutina rutina)
        {
            string sql = "INSERT INTO rutinas(Nombre,Descripcion,Ejercicios) " +
                  "VALUES (@Nombre, @Descripcion, @Ejercicios)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", rutina.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", rutina.Descripcion);
                comando.Parameters.AddWithValue("@Ejercicios", rutina.Ejercicios);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Rutina no guardada";
                }
                if (res != 0)
                {
                    return "Rutina guardada";
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
