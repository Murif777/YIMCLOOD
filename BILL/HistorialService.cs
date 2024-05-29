using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class HistorialService : ICrud<Historial>
    {
        HistorialRepository h_repository = new HistorialRepository();
        public string Registrar(Historial historial)
        {
            try
            {
                return h_repository.GuardarHistorialBD(historial);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
