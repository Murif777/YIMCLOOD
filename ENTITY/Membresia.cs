using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Membresia
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public TimeSpan Duracion { get; set; }
        public Entrenador Entrenador { get; set; }
        public Membresia() { }
        public Membresia(string nombre, string descripcion,
            int valor, TimeSpan duracion, Entrenador entrenador)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
            Duracion = duracion;
            Entrenador = entrenador;
        }
        public int ObtenerDuracionEnDias()
        {
            return (int)Duracion.TotalDays;
        }
        public override string ToString()
        {
            // Devuelve el nombre del entrenador al convertirlo a una cadena
            return Nombre;
        }
    }
}
