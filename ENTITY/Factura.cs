using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public int Id { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<Producto> Productos { get; set; }
        public double Precio_Total { get;  set; }

        public Factura() { }
        public Factura(int id, Miembro miembro, DateTime fechafactura, List<Producto> productos, double precio_Total)
        {
            Id = id;
            Miembro = miembro;
            FechaFactura = fechafactura;
            Productos = productos;
            Precio_Total = precio_Total;
        }
    }
}
