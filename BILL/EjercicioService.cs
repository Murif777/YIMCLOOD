using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class EjercicioService : ICrud<Ejercicio>
    {
        EjercicioRepository e_repository = new EjercicioRepository();
        public string Registrar(Ejercicio ejercicio)
        {
            try
            {
                return e_repository.GuardarEjercicioBD(ejercicio);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public List<Ejercicio> ConsultarEjercicios()
        {
            try
            {
                return e_repository.ConsultarEjercicio();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return null;
            }
        }
    }
}
