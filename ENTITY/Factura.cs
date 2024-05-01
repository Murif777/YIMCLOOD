using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public Factura() { }
        public Factura(
            int idfactura,
            DateTime fechafactura,
            List<Producto> productos)
        {
            IdFactura = idfactura;
            FechaFactura = fechafactura;
            Productos = productos;        
        }

        public int IdFactura { get;  set; }
        public DateTime FechaFactura { get;  set; }
        public List<Producto> Productos { get;  set; }
    }
}
