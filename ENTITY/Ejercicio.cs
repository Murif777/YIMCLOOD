using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ejercicio
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan? Duracion { get; set; }
        public int? Repeticiones { get; set; }
        public CategoriaEjercicio Categoria { get; set; }
        public Ejercicio() { }
        public Ejercicio(string nombre, string descripcion,CategoriaEjercicio categoria, TimeSpan duracion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Duracion = duracion;
        }
        public Ejercicio(string nombre, string descripcion, CategoriaEjercicio categoria, int repeticiones)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Repeticiones = repeticiones;
        }
    }

}
