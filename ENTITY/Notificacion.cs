using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string TipoNotificacion { get; set; }
        public string Mensaje { get; set; }
        public Notificacion() { }
        public Notificacion(int id, string tipoNotificacion, string mensaje)
        {
            Id = id;
            TipoNotificacion = tipoNotificacion;
            Mensaje = mensaje;
        }
    }
}
