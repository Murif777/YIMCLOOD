using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }

        public Usuario() { }
        public Usuario( string correoElectronico,string clave )
        {
            CorreoElectronico = correoElectronico;
            Clave = clave;
        }
    }
}
