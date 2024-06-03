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
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            string sql = "INSERT INTO facturas(Id, Miembro, FechaFactura, Membresia, Productos) " +
                  "VALUES (@Id, @Miembro, @FechaFactura, @Membresia, @Productos)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Id", factura.Id);
                comando.Parameters.AddWithValue("@Miembro", factura.Miembro);
                comando.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                comando.Parameters.AddWithValue("@Membresia", factura.Membresia);
                comando.Parameters.AddWithValue("@Productos", factura.Productos);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Factura no guardada";
                }
                if (res != 0)
                {
                    return "Factura guardada";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
            return null;

        }
        public List<Factura> ConsultarFacturasMembresia()
        {
            List<Factura> Facturas = new List<Factura>();

            string ssql = $"select * from facturas_membresias";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Facturas.Add(MapMembresia(reader));
                }
                return Facturas;
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

        private Factura MapMembresia(MySqlDataReader reader)
        {
            Factura Factura = new Factura();
            Factura.Id = int.Parse(reader.GetString(0));
            Factura.FechaFactura =DateTime.Parse(reader.GetString(1));
            Factura.Miembro.Correo = reader.GetString(2);
            return Factura;
        }
        public List<Factura> ConsultarFacturasProductos()
        {
            List<Factura> Facturas = new List<Factura>();
            Dictionary<int, Factura> facturaDict = new Dictionary<int, Factura>();

            string sql = @"SELECT f.Id, f.Cedula_Miembro, f.Fecha_Factura, fp.Referencia_Producto, fp.Cantidad, p.Nombre, p.Descripcion, p.Valor
                   FROM Factura f
                   JOIN Facturas_Productos fp ON f.Id = fp.Id_Factura
                   JOIN Productos p ON fp.Referencia_Producto = p.Referencia";

            using (MySqlConnection conexionBd = conexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                    conexionBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idFactura = reader.GetInt32("Id");
                            if (!facturaDict.TryGetValue(idFactura, out var factura))
                            {
                                factura = new Factura();

                                factura.Id = idFactura;
                                factura.Miembro.Cedula = reader.GetString("Cedula_Miembro"); // Asegúrate de que esto es correcto según tu estructura Miembro
                                factura.FechaFactura = reader.GetDateTime("Fecha_Factura");
                                factura.Productos = new List<Producto>();
                                
                                facturaDict[idFactura] = factura;
                                Facturas.Add(factura);
                            }

                            Producto producto = new Producto
                            {
                                Referencia = reader.GetString("Referencia_Producto"),
                                Nombre = reader.GetString("Nombre"),
                                Descripcion = reader.GetString("Descripcion"),
                                Valor = reader.GetInt32("Valor"),
                                Cantidad = reader.GetInt32("Cantidad")
                            };

                            factura.Productos.Add(producto);
                        }
                    }
                    return Facturas;
                }
                catch (MySqlException ex)
                {
                    
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        private Factura MapProducto(MySqlDataReader reader)
        {
            var factura = new Factura();

            factura.Id = int.Parse(reader.GetString("Id"));
            factura.Miembro.Cedula = reader.GetString("Cedula_Miembro"); // Asegúrate de que esto es correcto según tu estructura Miembro
            factura.FechaFactura = DateTime.Parse(reader.GetString("Fecha_Factura"));
            factura.Productos = new List<Producto>();
                new Producto
                {
                    Referencia = reader.GetString("Referencia_Producto"),
                    Nombre = reader.GetString("Nombre"),
                    Descripcion = reader.GetString("Descripcion"),
                    Valor = int.Parse(reader.GetString("Valor")),
                    Cantidad = int.Parse(reader.GetString("Cantidad"))
                };
            return factura;
        }

    }
}
