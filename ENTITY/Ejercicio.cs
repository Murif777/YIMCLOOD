using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ejercicio
    {
        public string Musculo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan? Duracion { get; set; }
        public int? Repeticiones { get; set; }
        public int? Series { get; set; }
        public CategoriaEjercicio Categoria { get; set; }
        public Ejercicio() { }
        public Ejercicio(string musculo, string nombre, string descripcion,CategoriaEjercicio categoria, TimeSpan duracion)
        {
            Musculo = musculo;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Duracion = duracion;
        }
        public Ejercicio(string musculo, string nombre, string descripcion, CategoriaEjercicio categoria, int repeticiones, int series)
        {
            Musculo = musculo;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Repeticiones = repeticiones;
            Series = series;
        }
    }

}
