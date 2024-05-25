using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PerfilMiembro:Persona
    {
        public PerfilMiembro() { }
        public PerfilMiembro(
            int idPerfil,
            Usuario datosusuario,
            string nombre,
            string apellido,
            string telefono,
            string sexo,
            DateTime fechaNacimiento,
            int peso,
            int estatura,
            List<Asistencia> horarioAsistencias,
            PerfilMembresia  perfilmembresia)
            :base(nombre, apellido, telefono, sexo,fechaNacimiento)
        {
            IdPerfil = idPerfil;
            DatosUsuario = datosusuario;
            Peso = peso;
            Estatura = estatura;
            HorarioAsistencias = horarioAsistencias;
            Perfilmembresia = perfilmembresia;
        }

        public int IdPerfil { get;  set; }
        public Usuario DatosUsuario { get;  set; }
        public int Peso { get;  set; }
        public int Estatura { get;  set; }
        public List<Asistencia> HorarioAsistencias { get;  set; }
        public PerfilMembresia Perfilmembresia { get;  set; }
        public FacturaProducto Factura { get;  set; }
    }
}
