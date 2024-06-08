using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class MembresiaService : ICrud<Membresia>
    {
        MembresiaRepository me_repository = new MembresiaRepository();
        private MiembroRepository miembroRepository = new MiembroRepository();
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
        public List<Membresia> ConsultarTodo()
        {
            try
            {
                return me_repository.Consultar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar membresias: " + ex.Message);
                return null;
            }
        }
      
    }
}
