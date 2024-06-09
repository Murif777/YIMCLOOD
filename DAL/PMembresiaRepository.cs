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
            string sql = "INSERT INTO membresias_usuarios(Correo_Usuario, Nombre_Membresia,Estado,Fecha_Inicio,Fecha_final,Saldo_Debe,Pagado,Duracion_Acumulada,Tiempo_Restante) " +
                  "VALUES (@Correo_Usuario, @Nombre_Membresia, @Estado, @Fecha_Inicio,@Fecha_final,@SaldoDebe,@Pagado,@Duracion_Acumulada,@Tiempo_Restante)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Correo_Usuario", pMembresia.DatosUsuario.CorreoElectronico);
                comando.Parameters.AddWithValue("@Nombre_Membresia", pMembresia.TipoMembresia.Nombre);
                comando.Parameters.AddWithValue("@Estado", pMembresia.Estado);
                comando.Parameters.AddWithValue("@Fecha_Inicio", pMembresia.Fechainicio);
                comando.Parameters.AddWithValue("@Fecha_final", pMembresia.Fechafinal);
                comando.Parameters.AddWithValue("@SaldoDebe", pMembresia.SaldoDebe);
                comando.Parameters.AddWithValue("@Pagado", pMembresia.Pagado);
                comando.Parameters.AddWithValue("@Duracion_Acumulada", pMembresia.DuracionAcumulada);
                comando.Parameters.AddWithValue("@Tiempo_Restante", pMembresia.TiempoRestante);
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
            }
            return null;

        }
        public string Actualizar(PerfilMembresia perfil)
        {
            string sql = "UPDATE Membresias_Usuarios " +
                "SET Estado = @Estado, Fecha_Inicio = @Fechainicio, Fecha_Final = @Fechafinal, Saldo_Debe = @SaldoDebe, Pagado = @Pagado, Duracion_Acumulada = @DuracionAcumulada, Tiempo_Restante = @TiempoRestante " +
                "WHERE Correo_Usuario = @CorreoUsuario AND Nombre_Membresia = @NombreMembresia";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Estado", perfil.Estado);
                comando.Parameters.AddWithValue("@Fechainicio", perfil.Fechainicio);
                comando.Parameters.AddWithValue("@Fechafinal", perfil.Fechafinal);
                comando.Parameters.AddWithValue("@SaldoDebe", perfil.SaldoDebe);
                comando.Parameters.AddWithValue("@Pagado", perfil.Pagado);
                comando.Parameters.AddWithValue("@DuracionAcumulada", perfil.DuracionAcumulada);
                comando.Parameters.AddWithValue("@TiempoRestante", perfil.TiempoRestante);
                comando.Parameters.AddWithValue("@CorreoUsuario", perfil.DatosUsuario.CorreoElectronico);
                comando.Parameters.AddWithValue("@NombreMembresia", perfil.TipoMembresia.Nombre);
                comando.ExecuteNonQuery();
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
        public PerfilMembresia ObtenerPerfilMembresiaPorCorreo(string correo)
        {
            string sql = "SELECT * FROM Membresias_Usuarios WHERE Correo_Usuario  = @Correo_Usuario ";
            PerfilMembresia perfil = null;

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Correo_Usuario ", correo);
                conexionBd.Open();
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        perfil = Map(reader);
                    }
                    return perfil;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error:" + ex.Message);

                return null;
            }
            finally
            {
                conexionBd.Close();
                
            }
        }
        public List<PerfilMembresia> ConsultarTodos()
        {
            List<PerfilMembresia> perfiles = new List<PerfilMembresia>();

            string sql = @"
    SELECT 
        mu.Correo_Usuario,
        mu.Nombre_Membresia,
        mu.Estado,
        mu.Fecha_Inicio,
        mu.Fecha_Final,
        mu.Saldo_Debe,
        mu.Pagado,
        mu.Duracion_Acumulada,
        mu.Tiempo_Restante,
        u.Clave,
        m.Cedula AS MiembroCedula,
        m.Nombre AS MiembroNombre,
        m.Apellido AS MiembroApellido,
        m.Telefono AS MiembroTelefono,
        m.Sexo AS MiembroSexo,
        m.Fecha_Nacimiento AS MiembroFechaNacimiento,
        m.Correo_Electronico AS MiembroCorreoElectronico,
        m.Peso AS MiembroPeso,
        m.Estatura AS MiembroEstatura,
        m.Foto AS MiembroFoto,
        mem.Nombre AS MembresiaNombre,
        mem.Descripcion AS MembresiaDescripcion,
        mem.Valor AS MembresiaValor,
        mem.Duracion AS MembresiaDuracion
    FROM Membresias_Usuarios mu
    JOIN Usuarios u ON mu.Correo_Usuario = u.Correo_Electronico
    JOIN Miembros m ON u.Ced_Miembro = m.Cedula
    JOIN Membresias mem ON mu.Nombre_Membresia = mem.Nombre";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        perfiles.Add(Map(reader));
                    }
                    Console.WriteLine("melocaramelo");

                    return perfiles;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        public List<PerfilMembresia> ConsultarCed(string cedula)
        {
            List<PerfilMembresia> perfiles = new List<PerfilMembresia>();

            string sql = @"
                SELECT 
                    mu.Correo_Usuario,
                    mu.Nombre_Membresia,
                    mu.Estado,
                    mu.Fecha_Inicio,
                    mu.Fecha_Final,
                    mu.Saldo_Debe,
                    mu.Pagado,
                    mu.Duracion_Acumulada,
                    mu.Tiempo_Restante,
                    u.Clave,
                    m.Cedula AS MiembroCedula,
                    m.Nombre AS MiembroNombre,
                    m.Apellido AS MiembroApellido,
                    m.Telefono AS MiembroTelefono,
                    m.Sexo AS MiembroSexo,
                    m.Fecha_Nacimiento AS MiembroFechaNacimiento,
                    m.Correo_Electronico AS MiembroCorreoElectronico,
                    m.Peso AS MiembroPeso,
                    m.Estatura AS MiembroEstatura,
                    m.Foto AS MiembroFoto,
                    mem.Nombre AS MembresiaNombre,
                    mem.Descripcion AS MembresiaDescripcion,
                    mem.Valor AS MembresiaValor,
                    mem.Duracion AS MembresiaDuracion
                FROM Membresias_Usuarios mu
                JOIN Usuarios u ON mu.Correo_Usuario = u.Correo_Electronico
                JOIN Miembros m ON u.Ced_Miembro = m.Cedula
                JOIN Membresias mem ON mu.Nombre_Membresia = mem.Nombre
                WHERE m.Cedula = @Cedula";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        perfiles.Add(Map(reader));
                    }
                    Console.WriteLine("melocaramelo");

                    return perfiles;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        private PerfilMembresia Map(MySqlDataReader reader)
        {
            // Verificación de nulos y obtención de datos del miembro
            string miembroCedula = reader.GetString("MiembroCedula");
            string miembroNombre = reader.GetString("MiembroNombre");
            string miembroApellido = reader.GetString("MiembroApellido");
            string miembroTelefono = reader.GetString("MiembroTelefono");
            string miembroSexo = reader.GetString("MiembroSexo");
            string miembroCorreoElectronico = reader.GetString("MiembroCorreoElectronico");
            DateTime miembroFechaNacimiento = reader.GetDateTime("MiembroFechaNacimiento");
            int miembroPeso = reader.GetInt32("MiembroPeso");
            int miembroEstatura = reader.GetInt32("MiembroEstatura");
            byte[] miembroFoto = reader.IsDBNull(reader.GetOrdinal("MiembroFoto")) ? null : (byte[])reader["MiembroFoto"];

            // Creación del objeto Miembro
            Miembro miembro = new Miembro(miembroCedula, miembroNombre, miembroApellido, miembroTelefono, miembroSexo, miembroCorreoElectronico, miembroFechaNacimiento, miembroPeso, miembroEstatura, miembroFoto);

            // Creación del objeto Usuario
            Usuario usuario = new Usuario(miembro);

            // Verificación de nulos y obtención de datos de la membresía
            string membresiaNombre = reader.GetString("MembresiaNombre");
            string membresiaDescripcion = reader.GetString("MembresiaDescripcion");
            int membresiaValor = reader.GetInt32("MembresiaValor");
            TimeSpan membresiaDuracion = TimeSpan.FromDays(reader.GetInt32("MembresiaDuracion"));

            // Creación del objeto Membresia
            Membresia membresia = new Membresia(membresiaNombre, membresiaDescripcion, membresiaValor, membresiaDuracion, null);

            // Creación del objeto PerfilMembresia con todos los datos requeridos
            PerfilMembresia perfil = new PerfilMembresia(
                usuario,
                membresia,
                reader.GetString("Estado"),
                reader.GetDateTime("Fecha_Inicio"),
                reader.GetDateTime("Fecha_Final"),
                reader.GetInt32("Saldo_Debe"),
                reader.GetBoolean("Pagado"),
                reader.GetInt32("Duracion_Acumulada"),
                reader.GetInt32("Tiempo_Restante")
            );

            return perfil;
        }
        public string ActualizarPMembresiaBD(PerfilMembresia perfil)
        {
            string sql = "UPDATE membresias_usuarios SET " +
                 "Duracion_Acumulada = @DuracionAcumulada, " +
                 "Tiempo_Restante = @TiempoRestante, " +
                 "Saldo_Debe = @SaldoDebe, " +
                 "Estado = @Estado " +
                 "WHERE Correo_Usuario = @Correo_Usuario";

            using (MySqlConnection conexionBd = conexion())
            {
                try
                {
                    conexionBd.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                    comando.Parameters.AddWithValue("@DuracionAcumulada", perfil.DuracionAcumulada);
                    comando.Parameters.AddWithValue("@TiempoRestante", perfil.TiempoRestante);
                    comando.Parameters.AddWithValue("@SaldoDebe", perfil.SaldoDebe);
                    comando.Parameters.AddWithValue("@Estado", perfil.Estado);
                    comando.Parameters.AddWithValue("@Correo_Usuario", perfil.DatosUsuario.CorreoElectronico);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return "Actualización exitosa";
                    }
                    else
                    {
                        return "No se pudo actualizar la membresía";
                    }
                }
                catch (MySqlException ex)
                {
                    return "Error al actualizar el perfil de membresía: " + ex.Message;
                }
            }
        }



    }
}
