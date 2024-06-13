using DAL;
using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace BILL
{
    public class UsuarioService //: ICrud<Usuario>
    {
        public string Registrar(Usuario usuario)
        {
            try
            {
                return u_repository.GuardarUsuarioBD(usuario);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }

        UsuarioRepository u_repository = new UsuarioRepository();
        public string Actualizar(Usuario usuario)
        {
            try
            {
                return u_repository.ActualizaContraseña(usuario);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public Miembro DatosMiembro(Usuario usuario)
        {
            try
            {
                return u_repository.DatosMiembro(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return null;
            }
        }
    }
}
