using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class PMembresiaService : ICrud<PerfilMembresia>
    {
        PMembresiaRepository pm_repository = new PMembresiaRepository();
        public string Registrar(PerfilMembresia pMembresia)
        {
            try
            {
                return pm_repository.GuardarPMembresiaBD(pMembresia);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
