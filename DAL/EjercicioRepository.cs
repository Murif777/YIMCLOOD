using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
