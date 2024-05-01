using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Asistencia
    {
        public Asistencia() { }
        public Asistencia(
            DateTime fechallegada,
            DateTime? fechasalida) 
        {
            HoraLlegada = fechallegada;
            HoraSalida = fechasalida;
        }

        public DateTime HoraLlegada { get;  set; }
        public DateTime? HoraSalida { get;  set; }
        public void RegistrarSalida(DateTime horaSalida)
        {
            HoraSalida = horaSalida;
        }
    }
}
