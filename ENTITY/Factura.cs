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
        public Factura(int idfactura,PerfilMiembro miembro,DateTime fechafactura)
        {
            IdFactura = idfactura;
            Miembro = miembro;
            FechaFactura = fechafactura;
        }
        public int IdFactura { get; set; }
        public PerfilMiembro Miembro { get; set; }
        public DateTime FechaFactura { get; set; }
    }
}
