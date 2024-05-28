using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class EntrenamientoService
    {
        EntramientoRepository e_repository = new EntramientoRepository();
        public string Registrar(Entrenamiento entrenamiento)
        {
            try
            {
                return e_repository.GuardarEntrenamientoBD(entrenamiento);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
