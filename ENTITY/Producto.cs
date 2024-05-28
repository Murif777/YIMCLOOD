using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public Producto() { }
        public Producto(
                        int id, string nombre,
                        string descripcion, int valor
                        ) 
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
        }
        public Producto(
                string nombre,
                string descripcion, int valor
                )
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
        }
    }
}
