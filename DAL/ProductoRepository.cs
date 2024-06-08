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
            string sql = "INSERT INTO productos(Referencia, Nombre, Descripcion, Valor,Cantidad, Foto) " +
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
                comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
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

            string ssql = "select * from productos";

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
            producto.Cantidad = int.Parse(reader.GetString(4));
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
                        using (MySqlCommand comando = new MySqlCommand(sql, conexionBd, transaction))
                        {
                            comando.Parameters.AddWithValue("@Referencia", referenciaProducto);
                            comando.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return "Producto eliminado exitosamente";
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        return "Error al intentar eliminar el Producto: " + ex.Message;
                    }
                }
            }
        
            //MySqlConnection conexionBd = new MySqlConnection();
            //conexionBd = conexion();
            //try
            //{
            //    conexionBd.Open();
            //    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
            //    comando.Parameters.AddWithValue("@Referencia", referenciaProducto);
            //    var res = comando.ExecuteNonQuery();

                //    if (res == 0)
                //    {
                //        return "Producto no encontrado";
                //    }
                //    else
                //    {
                //        return "Producto eliminado correctamente";
                //    }
                //}
                //catch (MySqlException ex)
                //{
                //    return "Error al eliminar el producto: " + ex.Message;
                //}
                //finally
                //{
                //    conexionBd.Close();
                //}
        }
        public void ActualizarProducto(Producto producto)
        {
            string query = "UPDATE Productos SET Nombre=@Nombre," +
                " Descripcion=@Descripcion, Valor=@Valor, Cantidad=@Cantidad," +
                " Foto=@Foto WHERE Referencia=@Referencia";
            using (MySqlConnection conexionBd = conexion())
            {
                conexionBd.Open();
                using (MySqlTransaction transaction = conexionBd.BeginTransaction())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conexionBd, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Referencia", producto.Referencia);
                            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                            cmd.Parameters.AddWithValue("@Valor", producto.Valor);
                            cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                            cmd.Parameters.AddWithValue("@Foto", producto.Foto);

                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al intentar actualizar el producto: " + ex.Message);
                    }
                }
            }
        }
        public int ObtenerCantidadPorReferencia(string referenciaProducto)
        {
            int cantidadDisponible = 0;

            string query = "SELECT Cantidad FROM Productos WHERE Referencia = @Referencia";

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
