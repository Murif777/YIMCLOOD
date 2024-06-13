using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegistroRepository:ConexionBD
    {
        public string GuardarRegistroBD(Registro registro)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            string sql = "INSERT INTO registros(Miembro_Cedula, Fecha, Peso, Hombros, Pecho, AntebrazoIzquierdo, AntebrazoDerecho, BrazoIzquierdo, BrazoDerecho, Cintura, Cadera, PiernaIzquierda, PiernaDerecha, GemeloIzquierdo, GemeloDerecho, Altura, Foto) " +
                  "VALUES (@Miembro, @Fecha, @Peso, @Hombros, @Pecho, @AntebrazoIzquierdo, @AntebrazoDerecho, @BrazoIzquierdo, @BrazoDerecho, @Cintura, @Cadera, @PiernaIzquierda, @PiernaDerecha, @GemeloIzquierdo, @GemeloDerecho, @Altura, @Foto)";
            var conexionBd = conexionBD();
            try
            {
                //AbrirConexion();
               // // conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Foto", registro.Foto);
                comando.Parameters.AddWithValue("@Peso", registro.Peso);
                comando.Parameters.AddWithValue("@Hombros", registro.Hombros);
                comando.Parameters.AddWithValue("@Pecho", registro.Pecho);
                comando.Parameters.AddWithValue("@AntebrazoIzquierdo", registro.AntebrazoIzquierdo);
                comando.Parameters.AddWithValue("@AntebrazoDerecho", registro.AntebrazoDerecho);
                comando.Parameters.AddWithValue("@BrazoIzquierdo", registro.BrazoIzquierdo);
                comando.Parameters.AddWithValue("@BrazoDerecho", registro.BrazoDerecho);
                comando.Parameters.AddWithValue("@Cintura", registro.Cintura);
                comando.Parameters.AddWithValue("@Cadera)", registro.Cadera);
                comando.Parameters.AddWithValue("@PiernaIzquierda", registro.PiernaIzquierda);
                comando.Parameters.AddWithValue("@PiernaDerecha", registro.PiernaDerecha);
                comando.Parameters.AddWithValue("@GemeloIzquierdo", registro.GemeloIzquierdo);
                comando.Parameters.AddWithValue("@GemeloDerecho", registro.GemeloDerecho);
                comando.Parameters.AddWithValue("@Altura", registro.Altura);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Registro no guardado";
                }
                if (res != 0)
                {
                    return "Registro guardado";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
               // // conexionBd.Close();
                //CerrarConexion();
            }
            return null;

        }
       

    }
}
