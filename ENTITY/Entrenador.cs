using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Entrenador:Persona
    {
        public Usuario DatosUsuario { get; set; }
        public PerfilMembresia TipoMembresia { get; set; }
        public Entrenador() { }
        public Entrenador(
            int id, string cedula, string nombre,
            string apellido, string telefono, string sexo,
            string correo, DateTime fechaNacimiento,PerfilMembresia tipomembresia)
            :base(id,cedula,nombre,apellido,telefono,sexo,correo,fechaNacimiento)
        {
            DatosUsuario = new Usuario(correo, cedula);
            TipoMembresia = tipomembresia;
        }//agregar foto 
        public Entrenador(
            string cedula, string nombre,
            string apellido, string telefono, string sexo,
            string correo, DateTime fechaNacimiento, PerfilMembresia tipomembresia)
            : base(null, cedula, nombre, apellido, telefono, sexo, correo, fechaNacimiento)
        {
            DatosUsuario = new Usuario(correo, cedula);
            TipoMembresia = tipomembresia;
        }
    }
}
