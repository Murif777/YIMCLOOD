using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacturaRepository:ConexionBD
    {
        public string GuardarFacturaBD(Factura factura)
        {
            string sqlFactura = "INSERT INTO Facturas(Cedula_Miembro, Fecha_Factura,Precio_Total) " +
                                "VALUES (@Cedula_Miembro, @Fecha_Factura,@Precio_Total); SELECT LAST_INSERT_ID();";

            string sqlFacturaProducto = "INSERT INTO Facturas_Productos(Id_Factura, Referencia_Producto, Cantidad, Precio_Total) " +
                                        "VALUES (@Id_Factura, @Referencia_Producto, @Cantidad, @Precio_Total)";

            var conexionBd = conexionBD();

            MySqlTransaction transaction = null;

            try
            {
                // conexionBd.Open();
                transaction = conexionBd.BeginTransaction();

                // Insertar en la tabla Facturas y obtener el ID generado
                MySqlCommand comandoFactura = new MySqlCommand(sqlFactura, conexionBd, transaction);
                comandoFactura.Parameters.AddWithValue("@Cedula_Miembro", factura.Miembro.Cedula);
                comandoFactura.Parameters.AddWithValue("@Fecha_Factura", factura.FechaFactura);
                comandoFactura.Parameters.AddWithValue("@Precio_Total", factura.Precio_Total);
                int facturaId = Convert.ToInt32(comandoFactura.ExecuteScalar());

                // Insertar en la tabla Facturas_Productos
                foreach (var producto in factura.Productos)
                {
                    MySqlCommand comandoFacturaProducto = new MySqlCommand(sqlFacturaProducto, conexionBd, transaction);
                    comandoFacturaProducto.Parameters.AddWithValue("@Id_Factura", facturaId);
                    comandoFacturaProducto.Parameters.AddWithValue("@Referencia_Producto", producto.Referencia);
                    comandoFacturaProducto.Parameters.AddWithValue("@Cantidad", producto.CantidadDisponible);
                    comandoFacturaProducto.Parameters.AddWithValue("@Precio_Total", producto.Valor);

                    comandoFacturaProducto.ExecuteNonQuery();
                }

                transaction.Commit();
                return "Factura guardada con éxito";
            }
            catch (MySqlException ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                return "Error al guardar la factura: " + ex.Message;
            }
            finally
            {
               // // conexionBd.Close();
            }
        }
        public List<Factura> ConsultarTodo()
        {
            List<Factura> facturas = new List<Factura>();
            string sql = @"
        SELECT 
            f.Id AS FacturaId, 
            f.Cedula_Miembro, 
            f.Fecha_Factura, 
            f.Precio_Total AS FacturaPrecioTotal,
            m.Cedula, 
            m.Nombre, 
            m.Apellido, 
            m.Telefono, 
            m.Sexo, 
            m.Fecha_Nacimiento, 
            m.Correo_Electronico, 
            m.Peso, 
            m.Estatura, 
            m.Foto AS MiembroFoto,
            fp.Referencia_Producto, 
            fp.Cantidad, 
            fp.Precio_Total AS ProductoPrecioTotal,
            p.Nombre AS ProductoNombre, 
            p.Descripcion, 
            p.Valor, 
            p.Cantidad_Disponible, 
            p.Foto AS ProductoFoto
        FROM Facturas f
        JOIN Miembros m ON f.Cedula_Miembro = m.Cedula
        JOIN Facturas_Productos fp ON f.Id = fp.Id_Factura
        JOIN Productos p ON fp.Referencia_Producto = p.Referencia";
            var conexionBd = conexionBD();

            try
            {
                // conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MapearDatosFactura(reader, facturas);
                    }
                    return facturas;

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error "+ex.Message);
                return null;
            }
        }
        public List<Factura> ConsultarCed(string cedula)
        {
            List<Factura> facturas = new List<Factura>();
            string sql = @"
        SELECT 
            f.Id AS FacturaId, 
            f.Cedula_Miembro, 
            f.Fecha_Factura, 
            f.Precio_Total AS FacturaPrecioTotal,
            m.Cedula, 
            m.Nombre, 
            m.Apellido, 
            m.Telefono, 
            m.Sexo, 
            m.Fecha_Nacimiento, 
            m.Correo_Electronico, 
            m.Peso, 
            m.Estatura, 
            m.Foto AS MiembroFoto,
            fp.Referencia_Producto, 
            fp.Cantidad, 
            fp.Precio_Total AS ProductoPrecioTotal,
            p.Nombre AS ProductoNombre, 
            p.Descripcion, 
            p.Valor, 
            p.Cantidad_Disponible, 
            p.Foto AS ProductoFoto
        FROM Facturas f
        JOIN Miembros m ON f.Cedula_Miembro = m.Cedula
        JOIN Facturas_Productos fp ON f.Id = fp.Id_Factura
        JOIN Productos p ON fp.Referencia_Producto = p.Referencia
        WHERE m.Cedula = @Cedula";
            var conexionBd = conexionBD();

            try
            {
                // conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Cedula", cedula);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MapearDatosFactura(reader, facturas);
                    }
                    return facturas;

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error " + ex.Message);
                return null;
            }
        }
        private void MapearDatosFactura(MySqlDataReader reader, List<Factura> facturas)
        {
            int facturaId = Convert.ToInt32(reader["FacturaId"]);

            // Obtener la información del miembro
            Miembro miembro = new Miembro
            {
                Cedula = reader["Cedula"].ToString(),
                Nombre = reader["Nombre"].ToString(),
                Apellido = reader["Apellido"].ToString(),
                Telefono = reader["Telefono"].ToString(),
                Sexo = reader["Sexo"].ToString(),
                FechaNacimiento = Convert.ToDateTime(reader["Fecha_Nacimiento"]),
                Correo= reader["Correo_Electronico"].ToString(),
                Peso = Convert.ToInt32(reader["Peso"]),
                Estatura = Convert.ToInt32(reader["Estatura"]),
                Foto = reader["MiembroFoto"] as byte[]
            };

            // Obtener la información del producto
            Producto producto = new Producto
            {
                Referencia = reader["Referencia_Producto"].ToString(),
                Nombre = reader["ProductoNombre"].ToString(),
                Descripcion = reader["Descripcion"].ToString(),
                Valor = Convert.ToInt32(reader["Valor"]),
                CantidadDisponible = Convert.ToInt32(reader["Cantidad"]),
                Foto = reader["ProductoFoto"] as byte[]
            };

            // Verificar si la factura ya existe en la lista
            Factura factura = facturas.FirstOrDefault(f => f.Id == facturaId);
            if (factura == null)
            {
                factura = new Factura(
                    facturaId,
                    miembro,
                    Convert.ToDateTime(reader["Fecha_Factura"]),
                    new List<Producto> { producto },
                    Convert.ToDouble(reader["FacturaPrecioTotal"])
                );
                facturas.Add(factura);
            }
            else
            {
                factura.Productos.Add(producto);
            }
        }



    }
}
