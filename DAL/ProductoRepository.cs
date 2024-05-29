using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoRepository:ConexionBD
    {
        public string GuardarProductoBD(Producto producto)
        {
            string sql = "INSERT INTO productos(Id, Nombre, Descripcion, Valor) " +
                  "VALUES (@Id, @Nombre, @Descripcion, @Valor)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Id", producto.Id);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Valor", producto.Valor);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Producto no guardado";
                }
                if (res != 0)
                {
                    return "Producto guardado";
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
