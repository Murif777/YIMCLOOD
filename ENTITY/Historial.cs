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
        public DateTime  Fecha { get; set; }
        public Registro Registro { get; set; }
        public Historial() { }
        public Historial(int id,Miembro miembro, DateTime fecha, Registro registro)
        {
            Id = id;
            Miembro = miembro;
            Fecha = fecha;
            Registro = registro;
        }
    }
}
