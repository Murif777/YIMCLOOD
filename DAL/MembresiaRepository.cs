using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MembresiaRepository:ConexionBD
    {
        public string GuardarMembresiaBD(Membresia membresia)
        {
            string sql = "INSERT INTO membresias(Id, Nombre, Descripcion, Valor, Duracion, Entrenador) " +
                  "VALUES (@Id, @Nombre, @Descripcion, @Valor, @Duracion, @Entrenador)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Id", membresia.Id);
                comando.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", membresia.Descripcion);
                comando.Parameters.AddWithValue("@Valor", membresia.Valor);
                comando.Parameters.AddWithValue("@Duracion", membresia.Duracion);
                comando.Parameters.AddWithValue("@Entrenador", membresia.Entrenador);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Membresia no guardada";
                }
                if (res != 0)
                {
                    return "Membresia guardada";
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
