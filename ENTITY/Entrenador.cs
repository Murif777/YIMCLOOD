using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Entrenador:Persona
    {
        public byte[] Foto { get;  set; }

        public Entrenador() { }
        public Entrenador(
            string cedula, string nombre,
            string apellido, string telefono, string sexo,
            string correo, DateTime fechaNacimiento, byte[] foto)
            : base(cedula, nombre, apellido, telefono, sexo, correo, fechaNacimiento)
        {
            Foto = foto;
        }
        public override string ToString()
        {
            // Devuelve el nombre del entrenador al convertirlo a una cadena
            return Nombre;
        }

    }

}
