using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public Miembro DatosMiembro { get;  set; }
        public Entrenador DatosEntrenador { get;  set; }
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }

        public Usuario() { }
        public Usuario( Miembro miembro)
        {
            DatosMiembro = miembro;
            CorreoElectronico = miembro.Correo;
            Clave = miembro.Cedula;
        }
        public Usuario(Entrenador entrenador)
        {
            DatosEntrenador = entrenador;
            CorreoElectronico = entrenador.Correo;
            Clave = entrenador.Cedula;
        }
        public Usuario(string correoElectronico, string clave)
        {
            CorreoElectronico = correoElectronico;
            Clave = clave;
        }
    }
}
