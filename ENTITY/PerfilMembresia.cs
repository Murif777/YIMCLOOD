using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PerfilMembresia
    {
        public Membresia TipoMembresia { get; set; }
        public string Estado { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafinal { get; set; }
        public int SaldoDebe { get; set; }
        public PerfilMembresia() { }
        public PerfilMembresia(
            Membresia tipomembresia,
            string estado,
            DateTime fechainicio,
            DateTime fechafinal,
            int saldodebe
            ) {
            TipoMembresia= tipomembresia;
            Estado = estado;
            Fechainicio = fechainicio;
            Fechafinal = fechafinal;
            SaldoDebe = saldodebe;
        }
    }
}
