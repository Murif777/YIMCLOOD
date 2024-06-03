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
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int Cantidad { get; set; }
        public byte[] Foto { get; set; }

        public Producto() { }
        public Producto(
                        string referencia, string nombre,
                        string descripcion, int valor, int cantidad, byte[] foto
                        ) 
        {
            Referencia =referencia;
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
            Cantidad = cantidad;
            Foto = foto;
        }
    }
}
