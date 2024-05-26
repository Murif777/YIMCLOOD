using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Rutina
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Ejercicio> Ejercicios { get; private set; }
        public Rutina() { }
        public Rutina(string nombre, string descripcion, List<Ejercicio> ejercicios)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Ejercicios = ejercicios;
        }
    }
}
