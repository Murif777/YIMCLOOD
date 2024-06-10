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
        public string RegistrarPersonalizada(Rutina rutina)
        {
            try
            {
                return ru_repository.GuardarRutinaPersoBD(rutina);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
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
        public List<Rutina> ConsultarPrees()
        {
            try
            {
                return ru_repository.ConsultarPrees();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return null;
            }
        }
        public List<Rutina> ConsultarPersonalizadas(string cedula)
        {
            try
            {
                return ru_repository.ConsultarPersonalizadas(cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return null;
            }
        }
    }
}
