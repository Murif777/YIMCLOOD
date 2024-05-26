using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Miembro : Persona
    {
        public Usuario DatosUsuario { get; set; }
        public int Peso { get; set; }
        public int Estatura { get; set; }
        public PerfilMembresia TipoMembresia { get; set; }
        public byte[] Foto { get; set; }
        public Miembro() { }
        public Miembro(
                            int id, string cedula, string nombre,
                            string apellido, string telefono, string sexo,
                            string correo, DateTime fechaNacimiento, int peso,
                            int estatura, PerfilMembresia tipomembresia, byte[] foto
                            ) : base(
                                      id, cedula, nombre,
                                      apellido, telefono, sexo,
                                      correo, fechaNacimiento
                                      )
        {
            DatosUsuario = new Usuario(correo, cedula);
            Peso = peso;
            Estatura = estatura;
            TipoMembresia = tipomembresia;
            Foto = foto;
        }
    }
}
