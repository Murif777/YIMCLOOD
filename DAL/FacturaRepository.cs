using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                //CerrarConexion();
            }
            return null;

        }
    }
}
