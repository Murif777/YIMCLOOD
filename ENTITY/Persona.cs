using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    { 
        public int? Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public Persona() { }
        public Persona(
            int? id,
            string cedula,
            string nombre,
            string apellido,
            string telefono,
            string sexo,
            string correo,
            DateTime fechaNacimiento)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Sexo = sexo;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
