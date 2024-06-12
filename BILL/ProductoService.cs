using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class ProductoService : ICrud<Producto>
    {
        ProductoRepository pro_repository=new ProductoRepository();
        public string Registrar(Producto producto)
        {
            try
            {
                return pro_repository.GuardarProductoBD(producto);            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public List<Producto> Consultar()
        {
            try
            {
                return pro_repository.Consultar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar " + ex.Message);
                return null;
            }
        }
        public List<Producto> ConsultarRef(string referencia)
        {
            try
            {
                return pro_repository.ConsultarRef(referencia);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar: " + ex.Message);
                return null;
            }
        }
        public string ActualizarCantidadDisponible(Producto producto)
        {
            try
            {
               return pro_repository.ActualizarCantidadDisponible(producto);

            }
            catch (Exception ex)
            {
              
                return "Error al registrar: " + ex.Message;
            }
        }
        public string EliminarProducto(string referenciaProducto)
        {
            return pro_repository.EliminarProducto(referenciaProducto);
        }

        public string ActualizarProducto(Producto producto)
        {
            
            try
            {
                return pro_repository.ActualizarProducto(producto);
                
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public string ObtenerCantidadDisponiblePorReferencia(string referencia)
        {
            int cantidad = pro_repository.ObtenerCantidadPorReferencia(referencia);
            return cantidad.ToString();
        }
        public string ObtenerPrecioUnitarioPorReferencia(string referenciaProducto)
        {
            return pro_repository.ObtenerPrecioUnitarioPorReferencia(referenciaProducto).ToString("F2");
        }
    }
}
