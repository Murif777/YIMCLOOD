using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class NotificacionService : ICrud<Notificacion>
    {
        NotificacionRepository n_repository = new NotificacionRepository();
        public string Registrar(Notificacion notificacion)
        {
            try
            {
                return n_repository.GuardarNotificacionBD(notificacion);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
