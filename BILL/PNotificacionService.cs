using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class PNotificacionService : ICrud<PerfilNotificacion>
    {
        PNotificacionRepository pn_repository = new PNotificacionRepository();
        public string Registrar(PerfilNotificacion pNotificacon)
        {
            try
            {
                return pn_repository.GuardarPNotificacionBD(pNotificacon);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
