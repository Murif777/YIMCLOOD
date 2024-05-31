using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class RegistroService : ICrud<Registro>
    {
        RegistroRepository re_repository = new RegistroRepository();
        public string Registrar(Registro registro)
        {
            try
            {
                return re_repository.GuardarRegistroBD(registro);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
    }
}
