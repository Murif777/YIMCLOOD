using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Entrenador:Persona
    {
        public Entrenador() { }
        public Entrenador(
            int identrenador,
            Usuario datosusuario,
            string nombre,
            string apellido,
            string telefono,
            string sexo,
            DateTime fechaNacimiento,
            List<Asistencia> horarioAsistencias)
            :base(nombre,apellido,telefono,sexo,fechaNacimiento)
        {
            IdEntrenador = identrenador;
            DatosUsuario = datosusuario;
            HorarioAsistencias = horarioAsistencias;
        }

        public int IdEntrenador { get;  set; }
        public Usuario DatosUsuario { get;  set; }
        public List<Asistencia> HorarioAsistencias { get;  set; }
    }
}
