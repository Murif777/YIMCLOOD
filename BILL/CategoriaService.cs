using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class CategoriaService:ICrud<CategoriaEjercicio>
    {
        CategoriaRepository c_repository = new CategoriaRepository();
        public string Registrar(CategoriaEjercicio categoria)
        {
            try
            {
                return c_repository.GuardarCategoriaBD(categoria);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public List<CategoriaEjercicio> ConsultarCategorias()
        {
            try
            {
                return c_repository.ConsultarCategorias();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
                return null;
            }
        }

    }
}
