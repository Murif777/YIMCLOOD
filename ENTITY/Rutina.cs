using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Rutina
    {
        public Miembro Miembro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
        public Rutina() { }
        public Rutina(string nombre, string descripcion, List<Ejercicio> ejercicios)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Ejercicios = ejercicios;
        }
        public Rutina(Miembro miembro, string nombre, string descripcion, List<Ejercicio> ejercicios)
        {
            Miembro = miembro;
            Nombre = nombre;
            Descripcion = descripcion;
            Ejercicios = ejercicios;
        }
    }
}
