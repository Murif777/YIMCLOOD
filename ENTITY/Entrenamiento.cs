using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Entrenamiento
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public List<Rutina> Rutinas { get; set; }
        public Entrenamiento() { }
        public Entrenamiento( DateTime horainicio,DateTime horafinal, List<Rutina> rutinas)
        {
            HoraInicio = horainicio;
            HoraFinal = horafinal;
            Rutinas = rutinas;
        }
        public TimeSpan Duracion()
        {
            return  HoraFinal-HoraInicio;
        }
    }
}
