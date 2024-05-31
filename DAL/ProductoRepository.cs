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
            string sql = "INSERT INTO productos(Referencia, Nombre, Descripcion, Valor, Foto) " +
                  "VALUES (@Referencia, @Nombre, @Descripcion, @Valor, @Foto)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Referencia", producto.Referencia);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Valor", producto.Valor);
                comando.Parameters.AddWithValue("@Foto", producto.Foto);
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
