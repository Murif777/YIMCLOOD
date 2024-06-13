using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MiembroRepository : ConexionBD
    {
        private PMembresiaRepository perfilmembresia = new PMembresiaRepository();
        public string GuardarMiembroBD(Miembro miembro)
        {
            string sql = "INSERT INTO Miembros(Cedula, Nombre, Apellido, Telefono, Sexo, Fecha_Nacimiento,Correo_Electronico, Peso, Estatura,Foto) " +
                  "VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Sexo, @Fecha_Nacimiento, @Correo_Electronico, @Peso, @Estatura, @Foto)";
            var conexionBd = conexionBD();

            //arreglar columnas
            try
            {
                //AbrirConexion();
                // conexionBd.Open();
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
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Miembro no guardado";
                }
                if (res != 0)
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
               // // conexionBd.Close();
                //CerrarConexion();
            }
            return null;

        }
        public Miembro BuscarPorCedula(string cedula)
        {
            string sql = "SELECT * FROM Miembros WHERE Cedula = @Cedula";

            using (var conexionBd = conexionBD())
            {
                try
                {
                    // conexionBd.Open();
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
                Estatura = reader.GetInt32("Estatura")
             };
            if (!reader.IsDBNull(reader.GetOrdinal("Foto")))
            {
                miembro.Foto = (byte[])reader["Foto"];
            }
            return miembro;
        }
        public string EliminarMiembroBD(string cedula)
        {
            using (var conexionBd = conexionBD())
            {
                // conexionBd.Open();
                using (MySqlTransaction transaction = conexionBd.BeginTransaction())
                {
                    try
                    {
                        // Eliminar de Facturas relacionadas
                        string sqlEliminarFacturas = "DELETE FROM Facturas WHERE Cedula_Miembro = @Cedula";
                        using (MySqlCommand comandoFacturas = new MySqlCommand(sqlEliminarFacturas, conexionBd, transaction))
                        {
                            comandoFacturas.Parameters.AddWithValue("@Cedula", cedula);
                            comandoFacturas.ExecuteNonQuery();
                        }

                        // Eliminar de Historial relacionado
                        string sqlEliminarHistorial = "DELETE FROM Historial WHERE Cedula_Miembro = @Cedula";
                        using (MySqlCommand comandoHistorial = new MySqlCommand(sqlEliminarHistorial, conexionBd, transaction))
                        {
                            comandoHistorial.Parameters.AddWithValue("@Cedula", cedula);
                            comandoHistorial.ExecuteNonQuery();
                        }

                        // Eliminar de Membresias_Usuarios relacionado
                        string sqlEliminarMembresiasUsuarios = "DELETE FROM Membresias_Usuarios WHERE Correo_Usuario IN (SELECT Correo_Electronico FROM Usuarios WHERE Ced_Miembro = @Cedula)";
                        using (MySqlCommand comandoMembresiasUsuarios = new MySqlCommand(sqlEliminarMembresiasUsuarios, conexionBd, transaction))
                        {
                            comandoMembresiasUsuarios.Parameters.AddWithValue("@Cedula", cedula);
                            comandoMembresiasUsuarios.ExecuteNonQuery();
                        }

                        // Eliminar de Usuarios relacionado
                        string sqlEliminarUsuarios = "DELETE FROM Usuarios WHERE Ced_Miembro = @Cedula";
                        using (MySqlCommand comandoUsuarios = new MySqlCommand(sqlEliminarUsuarios, conexionBd, transaction))
                        {
                            comandoUsuarios.Parameters.AddWithValue("@Cedula", cedula);
                            comandoUsuarios.ExecuteNonQuery();
                        }

                        // Eliminar de Rutinas_Miembro relacionado
                        string sqlEliminarRutinasMiembro = "DELETE FROM Rutinas_Miembro WHERE Miembro_Cedula = @Cedula";
                        using (MySqlCommand comandoRutinasMiembro = new MySqlCommand(sqlEliminarRutinasMiembro, conexionBd, transaction))
                        {
                            comandoRutinasMiembro.Parameters.AddWithValue("@Cedula", cedula);
                            comandoRutinasMiembro.ExecuteNonQuery();
                        }

                        // Eliminar de Miembros
                        string sqlEliminarMiembro = "DELETE FROM Miembros WHERE Cedula = @Cedula";
                        using (MySqlCommand comandoMiembro = new MySqlCommand(sqlEliminarMiembro, conexionBd, transaction))
                        {
                            comandoMiembro.Parameters.AddWithValue("@Cedula", cedula);
                            comandoMiembro.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                        return "Miembro eliminado exitosamente";
                    }
                    catch (MySqlException ex)
                    {
                        // Rollback transaction
                        transaction.Rollback();
                        return "Error al intentar eliminar el miembro: " + ex.Message;
                    }
                }
            }
        }


        public string ActualizarMiembroBD(Miembro miembro)
        {
            string sql = "UPDATE Miembros SET Nombre=@Nombre, Apellido=@Apellido, " +
                         "Telefono=@Telefono, Sexo=@Sexo, Fecha_Nacimiento=@FechaNacimiento, " +
                         "Correo_Electronico=@Correo, Peso=@Peso, Estatura=@Estatura, Foto=@Foto " +
                         "WHERE Cedula=@Cedula";
            var conexionBd = conexionBD();

            try
            {
                // conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Cedula", miembro.Cedula);
                comando.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                comando.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                comando.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                comando.Parameters.AddWithValue("@Sexo", miembro.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", miembro.FechaNacimiento.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@Correo", miembro.Correo);
                comando.Parameters.AddWithValue("@Peso", miembro.Peso);
                comando.Parameters.AddWithValue("@Estatura", miembro.Estatura);
                comando.Parameters.AddWithValue("@Foto", miembro.Foto);

                int res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Miembro no actualizado";
                }
                return "Miembro actualizado exitosamente";
            }
            catch (MySqlException ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
            finally
            {
               // // conexionBd.Close();
            }
        }
        public string ActualizarMiembroBD(Miembro miembro, string correoViejo)
        {
            var conexionBd = conexionBD();


            // Buscar la clave del usuario según el correo del miembro recibido
            string claveUsuario = ObtenerClaveUsuarioPorCorreo(correoViejo);
            if (claveUsuario == null)
            {
                return "Error no clave";
            }

            // Obtener el correo antiguo
            string correoAntiguo = ObtenerCorreoAntiguo(miembro.Cedula);
            if (correoAntiguo == null)
            {
                return "Error no correo";
            }

            // Obtener perfil de membresía antiguo
            PerfilMembresia perfilMembresiaViejo = perfilmembresia.ObtenerPerfilMembresiaPorCorreo(correoViejo);

            // Actualizar los datos del miembro según la cédula
            string sqlActualizarMiembro = "UPDATE Miembros SET Nombre=@Nombre, Apellido=@Apellido, " +
                                           "Telefono=@Telefono, Sexo=@Sexo, Fecha_Nacimiento=@FechaNacimiento, " +
                                           "Correo_Electronico=@Correo, Peso=@Peso, Estatura=@Estatura, Foto=@Foto " +
                                           "WHERE Cedula=@Cedula";
            try
            {
                // conexionBd.Open();
                MySqlCommand comandoActualizarMiembro = new MySqlCommand(sqlActualizarMiembro, conexionBd);
                comandoActualizarMiembro.Parameters.AddWithValue("@Cedula", miembro.Cedula);
                comandoActualizarMiembro.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                comandoActualizarMiembro.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                comandoActualizarMiembro.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                comandoActualizarMiembro.Parameters.AddWithValue("@Sexo", miembro.Sexo);
                comandoActualizarMiembro.Parameters.AddWithValue("@FechaNacimiento", miembro.FechaNacimiento.ToString("yyyy-MM-dd"));
                comandoActualizarMiembro.Parameters.AddWithValue("@Correo", miembro.Correo);
                comandoActualizarMiembro.Parameters.AddWithValue("@Peso", miembro.Peso);
                comandoActualizarMiembro.Parameters.AddWithValue("@Estatura", miembro.Estatura);
                comandoActualizarMiembro.Parameters.AddWithValue("@Foto", miembro.Foto);

                int resActualizarMiembro = comandoActualizarMiembro.ExecuteNonQuery();
                if (resActualizarMiembro == 0)
                {
                    return "Miembro no actualizado";
                }
                // Eliminar los datos de membresias_usuarios según el correo del miembro recibido
                string sqlEliminarMembresiaUsuario = "DELETE FROM Membresias_Usuarios WHERE Correo_Usuario=@CorreoViejo";
                MySqlCommand comandoEliminarMembresiaUsuario = new MySqlCommand(sqlEliminarMembresiaUsuario, conexionBd);
                comandoEliminarMembresiaUsuario.Parameters.AddWithValue("@CorreoViejo", correoViejo);
                int resEliminarMembresiaUsuario = comandoEliminarMembresiaUsuario.ExecuteNonQuery();

                // Eliminar los datos del usuario según la cédula del miembro recibido
                string sqlEliminarUsuario = "DELETE FROM Usuarios WHERE Ced_Miembro=@Cedula";
                MySqlCommand comandoEliminarUsuario = new MySqlCommand(sqlEliminarUsuario, conexionBd);
                comandoEliminarUsuario.Parameters.AddWithValue("@Cedula", miembro.Cedula);
                int resEliminarUsuario = comandoEliminarUsuario.ExecuteNonQuery();

                // Insertar nuevamente el usuario con los nuevos datos
                string sqlInsertarUsuario = "INSERT INTO Usuarios (Correo_Electronico, Clave, Ced_Miembro) VALUES (@Correo, @Clave, @Cedula)";
                MySqlCommand comandoInsertarUsuario = new MySqlCommand(sqlInsertarUsuario, conexionBd);
                comandoInsertarUsuario.Parameters.AddWithValue("@Correo", miembro.Correo);
                comandoInsertarUsuario.Parameters.AddWithValue("@Clave", claveUsuario);
                comandoInsertarUsuario.Parameters.AddWithValue("@Cedula", miembro.Cedula);
                int resInsertarUsuario = comandoInsertarUsuario.ExecuteNonQuery();


                // Insertar nuevamente la membresia del usuario con los nuevos datos
                string sqlInsertarMembresiaUsuario = "INSERT INTO Membresias_Usuarios (Correo_Usuario, Nombre_Membresia, Estado, Fecha_Inicio, Fecha_Final, Saldo_Debe, Pagado, Duracion_Acumulada, Tiempo_Restante) " +
                                                     "VALUES (@Correo, @NombreMembresia, @Estado, @FechaInicio, @FechaFinal, @SaldoDebe, @Pagado, @DuracionAcumulada, @TiempoRestante)";
                MySqlCommand comandoInsertarMembresiaUsuario = new MySqlCommand(sqlInsertarMembresiaUsuario, conexionBd);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@Correo", miembro.Correo);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@NombreMembresia", perfilMembresiaViejo.TipoMembresia.Nombre);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@Estado", perfilMembresiaViejo.Estado);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@FechaInicio", perfilMembresiaViejo.Fechainicio);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@FechaFinal", perfilMembresiaViejo.Fechafinal);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@SaldoDebe", perfilMembresiaViejo.SaldoDebe);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@Pagado", perfilMembresiaViejo.Pagado);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@DuracionAcumulada", perfilMembresiaViejo.DuracionAcumulada);
                comandoInsertarMembresiaUsuario.Parameters.AddWithValue("@TiempoRestante", perfilMembresiaViejo.TiempoRestante);
                int resInsertarMembresiaUsuario = comandoInsertarMembresiaUsuario.ExecuteNonQuery();

                return "Miembro actualizado exitosamente";
            }
            catch (MySqlException ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
            finally
            {
               // // conexionBd.Close();
            }
        }
        private string ObtenerCorreoAntiguo(string cedula)
        {
            Miembro miembro = new Miembro();

            string ssql = "SELECT * FROM miembros WHERE Cedula = @Cedula ";

            var conexionBd = conexionBD();


            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                // conexionBd.Open();
                comando.Parameters.AddWithValue("@Cedula", cedula);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    miembro.Correo = reader.GetString("Correo_Electronico");
                }
                    return miembro.Correo;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error: "+ex.Message);
                return null;
            }
            finally
            {
               // // conexionBd.Close();
            }
        }

        private string ObtenerClaveUsuarioPorCorreo(string correo)
        {
            Usuario usuario = new Usuario();
            string ssql = "SELECT * FROM usuarios WHERE Correo_Electronico = @Correo";

            var conexionBd = conexionBD();
            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                // conexionBd.Open();
                comando.Parameters.AddWithValue("@Correo", correo);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    usuario.Clave = reader.GetString("Clave");
                }
                return usuario.Clave;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error :" + ex.Message);
                return null;
            }
            finally
            {
               // // conexionBd.Close();
            }
        }

    }


}



