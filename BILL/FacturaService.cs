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
    }
}
