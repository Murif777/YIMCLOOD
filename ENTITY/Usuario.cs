using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int idUsuario, string correoElectronico,string clave ) {
            IdUsuario = idUsuario;
            CorreoElectronico = correoElectronico;
            Clave = clave;
        }

        public int IdUsuario { get;  set; }
        public string CorreoElectronico { get;  set;}
        public string Clave { get;  set; }
    }
}
