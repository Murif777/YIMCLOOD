using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    { 
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public Persona() { }
        public Persona(
            string cedula,
            string nombre,
            string apellido,
            string telefono,
            string sexo,
            string correo,
            DateTime fechaNacimiento)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Sexo = sexo;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            // Devuelve el nombre del entrenador al convertirlo a una cadena
            return Nombre;
        }
    }
}
