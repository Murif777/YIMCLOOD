using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class MembresiaService : ICrud<Membresia>
    {
        MembresiaRepository me_repository = new MembresiaRepository();
        public string Registrar(Membresia membresia)
        {
            try
            {
                return me_repository.GuardarMembresiaBD(membresia);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
