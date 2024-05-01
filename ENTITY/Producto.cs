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
        public Producto() { }
        public Producto(
            int idproducto,
            string nombre,
            string descripcion,
            int valor
            ) {
            Idproducto = idproducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
        }

        public int Idproducto { get;  set; }
        public string Nombre { get;  set; }
        public string Descripcion { get;  set; }
        public int Valor { get;  set; }
    }
}
