using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MembresiaRepository:ConexionBD
    {
        public string GuardarMembresiaBD(Membresia membresia)
        {
            string sql = "INSERT INTO membresias(Nombre, Descripcion, Valor, Duracion, Ced_Entrenador) " +
                  "VALUES (@Nombre, @Descripcion, @Valor, @Duracion, @Entrenador)";
           MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", membresia.Descripcion);
                comando.Parameters.AddWithValue("@Valor", membresia.Valor);
                comando.Parameters.AddWithValue("@Duracion", membresia.ObtenerDuracionEnDias());
                comando.Parameters.AddWithValue("@Entrenador", membresia.Entrenador.Cedula);

                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Membresia no guardada";
                }
                if (res != 0)
                {
                    return "Membresia guardada";
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
        public List<Membresia> Consultar()
        {
            List<Membresia> membresias = new List<Membresia>();

            string ssql = "SELECT * FROM membresias";

            MySqlConnection conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        membresias.Add(Map(reader));
                    }
                }

                return membresias;
            }
            catch (MySqlException ex)
            {
                // Manejar el error o registrar los detalles del error
                Console.WriteLine("Error al consultar membresias: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }


        private Membresia Map(MySqlDataReader reader)
        {
            EntrenadorRepository EntrenadorRepository = new EntrenadorRepository();
            Membresia membresia = new Membresia();
            membresia.Nombre = reader.GetString(0);
            membresia.Descripcion = reader.GetString(1);
            membresia.Valor = reader.GetInt32(2);
            membresia.Duracion = TimeSpan.FromDays(reader.GetUInt32(3)); // Usamos GetUInt32 para evitar valores negativos
            membresia.Entrenador = EntrenadorRepository.ObtenerEntrenadorPorCed(reader.GetString(4));
            return membresia;
        }


    }
}
