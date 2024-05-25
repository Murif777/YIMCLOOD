using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class FacturaMembresia:Factura
    {
        public FacturaMembresia() { }
        public FacturaMembresia(PerfilMembresia datosMembresia) : base( idfactura, miembro, fechafactura);
        {
            IdFactura = idFactura;
            FechaFactura = fechaFactura;
            DatosMembresia = datosMembresia;

        }

        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public PerfilMembresia DatosMembresia { get; set; }
    }
}
