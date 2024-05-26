using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PerfilNotificacion
    {
        public Notificacion TipoNotificacion { get; set; }
        public Miembro DatosMiembro { get; set; }

        public PerfilNotificacion() { }
        public PerfilNotificacion(
            Notificacion tipoNotificacion,
            Miembro datosMiembro)
        {
            TipoNotificacion = tipoNotificacion;
            DatosMiembro = datosMiembro;
        }
    }
}
