using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class RutinaService : ICrud<Rutina>
    {
        RutinaRepository ru_repository = new RutinaRepository();
        public string Registrar(Rutina rutina)
        {
            try
            {
                return ru_repository.GuardarRutinaBD(rutina);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
