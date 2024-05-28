using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class ProductoService
    {
        ProductoRepository p_repository=new ProductoRepository();
        public string Registrar(Producto producto)
        {
            try
            {
                return p_repository.GuardarProductoBD(producto);            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
