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

            string ssql = @"
            SELECT 
                m.Nombre AS MembresiaNombre,
                m.Descripcion AS MembresiaDescripcion,
                m.Valor AS MembresiaValor,
                m.Duracion AS MembresiaDuracion,
                e.Cedula AS EntrenadorCedula,
                e.Nombre AS EntrenadorNombre,
                e.Apellido AS EntrenadorApellido,
                e.Telefono AS EntrenadorTelefono,
                e.Sexo AS EntrenadorSexo,
                e.Correo_Electronico AS EntrenadorCorreoElectronico,
                e.Fecha_Nacimiento AS EntrenadorFechaNacimiento,
                e.Foto AS EntrenadorFoto
            FROM 
                membresias m
            LEFT JOIN 
                entrenadores e ON m.Ced_Entrenador = e.Cedula";

            using (MySqlConnection conexionBd = conexion())
            {
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
                    Console.WriteLine("Error al consultar membresias: " + ex.Message);
                    return null;
                }
            }
        }

        private Membresia Map(MySqlDataReader reader)
        {
            Membresia membresia = new Membresia
            {
                Nombre = reader.GetString("MembresiaNombre"),
                Descripcion = reader.GetString("MembresiaDescripcion"),
                Valor = reader.GetInt32("MembresiaValor"),
                Duracion = TimeSpan.FromDays(reader.GetInt32("MembresiaDuracion"))
            };

            if (!reader.IsDBNull(reader.GetOrdinal("EntrenadorCedula")))
            {
                Entrenador entrenador = new Entrenador
                {
                    Cedula = reader.GetString("EntrenadorCedula"),
                    Nombre = reader.GetString("EntrenadorNombre"),
                    Apellido = reader.GetString("EntrenadorApellido"),
                    Telefono = reader.GetString("EntrenadorTelefono"),
                    Sexo = reader.GetString("EntrenadorSexo"),
                    Correo= reader.GetString("EntrenadorCorreoElectronico"),
                    FechaNacimiento = reader.GetDateTime("EntrenadorFechaNacimiento")
                };

                if (!reader.IsDBNull(reader.GetOrdinal("EntrenadorFoto")))
                {
                    long length = reader.GetBytes(reader.GetOrdinal("EntrenadorFoto"), 0, null, 0, 0);
                    byte[] foto = new byte[length];
                    reader.GetBytes(reader.GetOrdinal("EntrenadorFoto"), 0, foto, 0, (int)length);
                    entrenador.Foto = foto;
                }

                membresia.Entrenador = entrenador;
            }
            else
            {
                membresia.Entrenador = null;
            }

            return membresia;
        }

    }
}
