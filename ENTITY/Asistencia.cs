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
            List<DayOfWeek> diasDeLaSemana,
            DateTime fechallegada,
            DateTime? fechasalida)
        {
            DiasDeLaSemana = diasDeLaSemana ?? new List<DayOfWeek>();
            HoraLlegada = fechallegada;
            HoraSalida = fechasalida;
        }

        public List<DayOfWeek> DiasDeLaSemana { get; set; }
        public DateTime HoraLlegada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public void RegistrarSalida(DateTime horaSalida)
        {
            HoraSalida = horaSalida;
        }
    }
}
