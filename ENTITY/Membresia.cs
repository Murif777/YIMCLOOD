using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Membresia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public DateTime Duracion { get; set; }
        public Entrenador Entrenador { get; set; }

        public Membresia() { }
        public Membresia(int id, string nombre, string descripcion,
            int valor, DateTime duracion, Entrenador entrenador = null)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
            Duracion = duracion;
            if (nombre.Equals("VIP", StringComparison.OrdinalIgnoreCase))
            {
                Entrenador = entrenador;
            }
        }
    }
}
