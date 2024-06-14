using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class ConexionService
    {
		private ConexionBD ConexionBD = new ConexionBD();
        public bool Login(Usuario usuario)
        {
			try
			{
				return ConexionBD.Login(usuario);
			}
			catch (Exception ex )
			{
                Console.WriteLine("error :"+ ex.Message);
                return false;
			}
        }
		public Usuario UsuarioRecuperacion()
		{
			try
			{
				return ConexionBD.UsuariodeRecuperacion();
			}
			catch (Exception ex)
			{
				Console.WriteLine("error :" + ex.Message);

				throw;
			}
		}
        public void cerrarConexion()
        {
            try
            {
                ConexionBD.Cerrarconexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex.Message);

                throw;
            }
        }
        
        public bool prueba()
        {
            Usuario usuario = new Usuario();
            usuario.CorreoElectronico = "root";
            usuario.Clave = "123456";
            try
            {
                return ConexionBD.Login(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex.Message);
                return false;
            }
        }
    }
}
