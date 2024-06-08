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
        public string Categoria { get;  set; }
        public byte[] Foto { get;  set; }
        public int? Repeticiones { get; set; }
        public int? Series { get; set; }
        public Ejercicio() { }
        public Ejercicio(string nombre, string descripcion, TimeSpan duracion, string musculo, string categoria, byte[] foto)
        {
            Musculo = musculo;
            Nombre = nombre;
            Descripcion = descripcion;
            Duracion = duracion;
            Categoria = categoria;
            Foto = foto;
        }
        public Ejercicio(string nombre, string descripcion, int repeticiones, int series, string musculo, string categoria, byte[] foto)
        {
            Musculo = musculo;
            Nombre = nombre;
            Descripcion = descripcion;
            Repeticiones = repeticiones;
            Series = series;
            Categoria = categoria;
            Foto = Foto;
        }
    }

}
