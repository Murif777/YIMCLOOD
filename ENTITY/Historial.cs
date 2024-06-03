using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Historial
    {
        public int Id { get; private set; }
        public Miembro Miembro { get; set; }
        public DayOfWeek  DiaDeLaSemana { get; set; }
        public Registro Registro { get; set; }
        public Rutina Rutina { get; set; }
        public Historial() { }
        public Historial(int id,Miembro miembro, DayOfWeek diaDeLaSemana, Registro registro)
        {
            Id = id;
            Miembro = miembro;
            DiaDeLaSemana = diaDeLaSemana;
            Registro = registro;
        }
        public Historial(int id, Miembro miembro, DayOfWeek diaDeLaSemana, Rutina rutina)
        {
            Id = id;
            Miembro= miembro;
            DiaDeLaSemana = diaDeLaSemana;
            Rutina = rutina;
        }
    }
}
