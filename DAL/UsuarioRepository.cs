using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository:ConexionBD
    {
        public string GuardarUsuarioBD(Usuario usuario)
        {
            string sql = "INSERT INTO usuarios(Correo_Electronico, Clave, Ced_Miembro,Ced_Entrenador) VALUES" +
                "(@Correo,@Clave, @Ced_Miembro, @Ced_Entrenador)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                if (usuario.DatosEntrenador == null) 
                {
                    comando.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Clave", usuario.Clave);
                    comando.Parameters.AddWithValue("@Ced_Miembro", usuario.DatosMiembro.Cedula);
                    comando.Parameters.AddWithValue("@Ced_Entrenador", null);
                }
                if(usuario.DatosMiembro==null) 
                {
                    comando.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Clave", usuario.Clave);
                    comando.Parameters.AddWithValue("@Ced_Miembro",null );
                    comando.Parameters.AddWithValue("@Ced_Entrenador", usuario.DatosEntrenador.Cedula);

                }
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Usuario no guardado";
                }
                if (res != 0)
                {
                    return "Usuario guardado";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
            return null;
        }

        public string ActualizaContraseña(Usuario usuario)
        {
            string actualizarSql = "UPDATE Usuarios SET Clave = @NuevaClave WHERE Correo_Electronico = @CorreoElectronico";

            using (var connection = conexion())
            {
                MySqlCommand actualizarComando = new MySqlCommand(actualizarSql, connection);
                actualizarComando.Parameters.AddWithValue("@NuevaClave", usuario.Clave);
                actualizarComando.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);

                try
                {
                    connection.Open();
                    int rowsAffected = actualizarComando.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return "Contraseña actualizada exitosamente.";
                    }
                    else
                    {
                        return "Usuario no encontrado.";
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al actualizar la contraseña", ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public bool Login(Usuario usuario)
        {
            string sql = "SELECT 1 FROM Usuarios WHERE Correo_Electronico = @CorreoElectronico AND Clave = @Clave LIMIT 1";

            using (var connection = conexion())
            {
                MySqlCommand comando = new MySqlCommand(sql, connection);
                comando.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                comando.Parameters.AddWithValue("@Clave", usuario.Clave);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al realizar la consulta", ex);
                }
            }
        }

        public Miembro DatosMiembro(Usuario usuario)
        {
            string sql = "SELECT * FROM Miembros WHERE Correo_Electronico = @CorreoElectronico";

            using (MySqlConnection conexionBd = conexion())
            {

                try
                {
                    conexionBd.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                    comando.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);


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
            Miembro miembro= new Miembro
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
            };
            if (!reader.IsDBNull(reader.GetOrdinal("Foto")))
            {
                miembro.Foto = (byte[])reader["Foto"];
            }

            return miembro;
        }

    }
}
