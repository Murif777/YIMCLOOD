using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PMembresiaRepository:ConexionBD
    {
        public string GuardarPMembresiaBD(PerfilMembresia pMembresia)
        {
            string sql = "INSERT INTO perfilMembresias(TipoMembresia,Estado,Fechainicio,Fechafinal,SaldoDebe) " +
                  "VALUES (@TipoMembresia, @Estado, @Fechainicio, @Fechafinal, @SaldoDebe)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@TipoMembresia", pMembresia.TipoMembresia);
                comando.Parameters.AddWithValue("@Estado", pMembresia.Estado);
                comando.Parameters.AddWithValue("@Fechainicio", pMembresia.Fechainicio);
                comando.Parameters.AddWithValue("@Fechafinal", pMembresia.Fechafinal);
                comando.Parameters.AddWithValue("@SaldoDebe", pMembresia.SaldoDebe);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Perfil membresia no guardada";
                }
                if (res != 0)
                {
                    return "Perfil membresia guardada";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
                //CerrarConexion();
            }
            return null;

        }
    }
}
