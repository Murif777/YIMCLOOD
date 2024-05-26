using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class CategoriaEjercicio
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public CategoriaEjercicio() { }
        public CategoriaEjercicio(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
