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
    public class EntrenadorService:ICrud<Entrenador>
    {
        EntrenadorRepository en_repository = new EntrenadorRepository();
        public string Registrar(Entrenador entrenador)
        {
            try
            {
                return en_repository.GuardarEntrenadorBD(entrenador);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public List<Entrenador> Consultar()
        {
            try
            {
                return en_repository.Consultar();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
