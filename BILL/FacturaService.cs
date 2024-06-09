using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class FacturaService:ICrud<Factura>
    {
        FacturaRepository f_repository = new FacturaRepository();
        public string Registrar(Factura factura)
        {
            try
            {
                return f_repository.GuardarFacturaBD(factura);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public string RegistrarFacturaProducto(Factura factura)
        {
            try
            {
                return f_repository.GuardarFacturaBD(factura);
            }
            catch (Exception ex)
            {
                return "Error al registrar la factura: " + ex.Message;
            }
        }
        public List<Factura> ConsultarTodo()
        {
            try
            {
                return f_repository.ConsultarTodo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar las factura: " + ex.Message);
                return null;
            }
        }
        public List<Factura> ConsultarCed(string cedula)
        {
            try
            {
                return f_repository.ConsultarCed(cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar las factura: " + ex.Message);
                return null;
            }
        }
    }

}
