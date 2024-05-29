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
        MiembroRepository mi_repository =new MiembroRepository();
        public string Registrar(Miembro miembro)
        {
            try
            {
                return mi_repository.GuardarMiembroBD(miembro);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
