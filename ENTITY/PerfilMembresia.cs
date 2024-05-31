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
        public bool Pagado { get; set; }
        public Usuario DatosUsuario { get;  set; }
        public TimeSpan DuracionAcumulada { get; set; } // Nuevo campo para duración acumulada
        public TimeSpan TiempoRestante { get; set; } // Nuevo campo para tiempo restante

        public PerfilMembresia() { }
        public PerfilMembresia(
            Usuario usuario,
            Membresia tipomembresia,
            string estado,
            DateTime fechainicio,
            DateTime fechafinal,
            int saldodebe,
            bool pagado,
            TimeSpan duracionAcumulada,
            TimeSpan tiempoRestante
            ) {
             DatosUsuario = usuario;
            TipoMembresia= tipomembresia;
            Estado = estado;
            Fechainicio = fechainicio;
            Fechafinal = fechafinal;
            SaldoDebe = saldodebe;
            Pagado = pagado;
            DuracionAcumulada = duracionAcumulada;
            TiempoRestante = tiempoRestante;
        }
    }
}
