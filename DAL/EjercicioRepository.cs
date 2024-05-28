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
            string sql = "INSERT INTO ejercicios(Nombre,Descripcion,Categoria,Repeticiones,Duracion) " +
                  "VALUES (@Nombre, @Descripcion,@Categoria,@Repeticiones,@Duracion)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", ejercicio.Descripcion);
                comando.Parameters.AddWithValue("@Categoria", ejercicio.Categoria);
                comando.Parameters.AddWithValue("@Repeticiones", ejercicio.Repeticiones);
                comando.Parameters.AddWithValue("@Duracion", ejercicio.Duracion);
                comando.ExecuteNonQuery();
                return "Ejercicio registrado";
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
