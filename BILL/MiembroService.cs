using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class MiembroService:ICrud<Miembro>
    {
        //MiembroRepository miembroRepository = new MiembroRepository();
        private MiembroRepository miembroRepository = new MiembroRepository();// Instancia de MiembroRepository

        public string Registrar(Miembro miembro)
        {
            try
            {
                return miembroRepository.GuardarMiembroBD(miembro);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }

        public Miembro BuscarPorCedul(string cedula)
        {
            // Llamar al método BuscarPorCedula definido en MiembroRepository
            return miembroRepository.BuscarPorCedula(cedula);
        }
    }
}
