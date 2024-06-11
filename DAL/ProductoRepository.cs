using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoRepository:ConexionBD
    {
        public string GuardarProductoBD(Producto producto)
        {
            string sql = "INSERT INTO productos(Referencia, Nombre, Descripcion, Valor,Cantidad_Disponible, Foto) " +
                  "VALUES (@Referencia, @Nombre, @Descripcion, @Valor,@Cantidad, @Foto)";
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
                comando.Parameters.AddWithValue("@Cantidad", producto.CantidadDisponible);
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
        public List<Producto> Consultar()
        {
            List<Producto> productos = new List<Producto>();

            string ssql = "SELECT * FROM productos";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(Map(reader));

                }
                if (productos==null)
                {
                    Console.WriteLine("lista vacia");
                    return null;
                }
                return productos;
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        public string ActualizarCantidadDisponible(Producto producto)
        {
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            string sql = "UPDATE Productos SET Cantidad_Disponible = @Cantidad_Disponible WHERE Referencia = @Referencia";

            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Cantidad_Disponible", producto.CantidadDisponible);
                comando.Parameters.AddWithValue("@Referencia", producto.Referencia);
                comando.ExecuteNonQuery();
                return "Stock actualizado";
            }
            catch (MySqlException ex)
            {
                return "Error al actualizar la cantidad disponible del producto: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        public List<Producto> ConsultarRef(string referencia)
        {
            List<Producto> productos = new List<Producto>();

            string ssql = $"SELECT * FROM productos WHERE Referencia = {referencia}";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(Map(reader));

                }
                if (productos == null)
                {
                    Console.WriteLine("lista vacia");
                    return null;
                }
                return productos;
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        private Producto Map(MySqlDataReader reader)
        {
            Producto producto = new Producto();
            producto.Referencia = reader.GetString(0);
            producto.Nombre = reader.GetString(1);
            producto.Descripcion = reader.GetString(2);
            producto.Valor = int.Parse(reader.GetString(3));
            producto.CantidadDisponible = int.Parse(reader.GetString(4));
            byte[] foto = null;
            var stream = reader.GetStream(5);
            if (stream != null)
            {
                using (stream)
                {
                    if (stream != null)
                    {
                        long bytesToRead = stream.Length;
                        foto = new byte[bytesToRead];
                        stream.Read(foto, 0, (int)bytesToRead);
                    }
                }
            }
            else
            {
                foto = null;
            }
            producto.Foto = foto;
            return producto;
        }
        public string EliminarProducto(string referenciaProducto)
        {
            string sql = "DELETE FROM Productos WHERE Referencia = @Referencia";

            using (MySqlConnection conexionBd = conexion())
            {
                conexionBd.Open();
                using (MySqlTransaction transaction = conexionBd.BeginTransaction())
                {
                    try
                    {
                        // Eliminar de Productos
                        using (MySqlCommand comando = new MySqlCommand(sql, conexionBd, transaction))
                        {
                            comando.Parameters.AddWithValue("@Referencia", referenciaProducto);
                            comando.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                        return "Producto eliminado exitosamente";
                    }
                    catch (MySqlException ex)
                    {
                        // Rollback transaction
                        transaction.Rollback();
                        return "Error al intentar eliminar el Producto: " + ex.Message;
                    }
                    finally
                    {
                        conexionBd.Close();
                    }
                }
            }
        }

        public string ActualizarProducto(Producto producto)
        {
            string query = "UPDATE Productos SET Nombre=@Nombre, " +
                "Descripcion=@Descripcion, Valor=@Valor, Cantidad_Disponible=@Cantidad, " +
                "Foto=@Foto WHERE Referencia=@Referencia";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexionBd);
                cmd.Parameters.AddWithValue("@Referencia", producto.Referencia);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Valor", producto.Valor);
                cmd.Parameters.AddWithValue("@Cantidad", producto.CantidadDisponible);
                cmd.Parameters.AddWithValue("@Foto", producto.Foto);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Producto no actualizado";
                }
                return "Producto actualizado exitosamente";
            }
            catch (MySqlException ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        public int ObtenerCantidadPorReferencia(string referenciaProducto)
        {
            int cantidadDisponible = 0;

            string query = "SELECT Cantidad_Disponible FROM Productos WHERE Referencia = @Referencia";

            using (MySqlConnection conexionBd = conexion())
            {
                conexionBd.Open();

                MySqlCommand command = new MySqlCommand(query, conexionBd);
                command.Parameters.AddWithValue("@Referencia", referenciaProducto);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    cantidadDisponible = Convert.ToInt32(result);
                }
            }

            return cantidadDisponible;
        }

        public decimal ObtenerPrecioUnitarioPorReferencia(string referenciaProducto)
        {
            decimal precioUnitario = 0m;

            string query = "SELECT Valor FROM Productos WHERE Referencia = @Referencia";

            using (MySqlConnection conexionBd = conexion())
            {
                conexionBd.Open();

                MySqlCommand command = new MySqlCommand(query, conexionBd);
                command.Parameters.AddWithValue("@Referencia", referenciaProducto);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    precioUnitario = Convert.ToDecimal(result);
                }
            }

            return precioUnitario;
        }

    }
}
