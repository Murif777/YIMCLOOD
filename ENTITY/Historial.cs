using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Historial
    {
        public Miembro Miembro { get; set; }
        public DayOfWeek DiaDeLaSemana { get; set; }
        public Registro Registro { get; set; }
        public Entrenamiento Entrenamiento { get; set; }
        public Historial() { }
        public Historial(Miembro miembro, DayOfWeek diaDeLaSemana, Registro registro)
        {
            Miembro = miembro;
            DiaDeLaSemana = diaDeLaSemana;
            Registro = registro;
        }
        public Historial(Miembro miembro, DayOfWeek diaDeLaSemana, Entrenamiento entrenamiento)
        {
            Miembro= miembro;
            DiaDeLaSemana = diaDeLaSemana;
            Entrenamiento = entrenamiento;
        }
    }
}
