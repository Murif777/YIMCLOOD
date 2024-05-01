using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public Persona() { }
        public Persona(
            string nombre,
            string apellido,
            string telefono,
            string sexo,
            DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public string Telefono { get;  set; }
        public string Sexo { get;  set; }
        public DateTime FechaNacimiento { get;  set; }
    }
}
