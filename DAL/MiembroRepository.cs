using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MiembroRepository:ConexionBD
    {
       
        public string GuardarMiembroBD(Miembro miembro)
        {
            string sql = "INSERT INTO Miembros(Cedula, Nombre, Apellido, Telefono, Sexo, Fecha_Nacimiento,Correo_Electronico, Peso, Estatura,Foto) " +
                  "VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Sexo, @Fecha_Nacimiento, @Correo_Electronico, @Peso, @Estatura, @Foto)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            //arreglar columnas
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Cedula", miembro.Cedula);
                comando.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                comando.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                comando.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                comando.Parameters.AddWithValue("@Sexo", miembro.Sexo);
                comando.Parameters.AddWithValue("@Correo_Electronico", miembro.Correo);
                comando.Parameters.AddWithValue("@Fecha_Nacimiento", miembro.FechaNacimiento.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@Peso", miembro.Peso);
                comando.Parameters.AddWithValue("@Estatura", miembro.Estatura);
                comando.Parameters.AddWithValue("@Foto", miembro.Foto);
                var res=comando.ExecuteNonQuery();
                if (res==0)
                {
                    return "Miembro no guardado";
                }
                if (res!=0)
                {
                    return $"Miembro registrado ";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
                //CerrarConexion();
            }
            return null;

        }
        public Miembro BuscarPorCedula(string cedula)
        {
            string sql = "SELECT * FROM Miembros WHERE Cedula = @Cedula";

            using (MySqlConnection conexionBd = conexion())
            {
                try
                {
                    conexionBd.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                    comando.Parameters.AddWithValue("@Cedula", cedula);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapMiembro(reader);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error al buscar el miembro por cédula: " + ex.Message);
                    return null;
                }
            }
        }

        private Miembro MapMiembro(MySqlDataReader reader)
        {
            return new Miembro
            {
                Cedula = reader.GetString("Cedula"),
                Nombre = reader.GetString("Nombre"),
                Apellido = reader.GetString("Apellido"),
                Telefono = reader.GetString("Telefono"),
                Sexo = reader.GetString("Sexo"),
                Correo = reader.GetString("Correo_Electronico"),
                FechaNacimiento = reader.GetDateTime("Fecha_Nacimiento"),
                Peso = reader.GetInt32("Peso"),
                Estatura = reader.GetInt32("Estatura"),
                Foto = (byte[])reader["Foto"]
            };
        }
    }

}

