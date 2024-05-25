using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class FacturaProducto
    {
        public FacturaProducto() { }
        public FacturaProducto(
            List<Producto> productos)
        {
            IdFactura = idfactura;
            Miembro = miembro;
            FechaFactura = fechafactura;
            Productos = productos;        
        }

        public int IdFactura { get;  set; }
        public PerfilMiembro Miembro { get;  set; }
        public DateTime FechaFactura { get;  set; }
        public List<Producto> Productos { get;  set; }
    }
}
