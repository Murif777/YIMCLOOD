using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaRepository:ConexionBD
    {
        public string GuardarCategoriaBD(CategoriaEjercicio categoria)
        {
            string sql = "INSERT INTO categorias(Nombre,Descripcion,Valor) " +
                  "VALUES (@Nombre, @Descripcion, @Valor)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                comando.ExecuteNonQuery();
                return "Categoria registrada";

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
