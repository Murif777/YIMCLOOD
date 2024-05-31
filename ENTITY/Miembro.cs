using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Miembro : Persona
    {
        public int Peso { get; set; } = 0;
        public int Estatura { get; set; } = 0;
        public byte[] Foto { get; set; } = null;
        public Miembro()
        {
        }
        public Miembro(
                     string cedula, string nombre,
                    string apellido, string telefono, string sexo,
                    string correo, DateTime fechaNacimiento, int peso,
                    int estatura, byte[] foto
                    ) : base(
                               cedula, nombre,
                              apellido, telefono, sexo,
                              correo, fechaNacimiento
                              )
        {
            Peso = peso;
            Estatura = estatura;
            Foto = foto;
        }
    }
}
