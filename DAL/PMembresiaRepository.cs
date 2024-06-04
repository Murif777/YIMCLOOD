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
            string sql = "SELECT * FROM Membresias_Usuarios";

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
                    return perfiles;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error:"+ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();

            }
        }

        private PerfilMembresia Map(MySqlDataReader reader)
        {
            PerfilMembresia perfil = new PerfilMembresia
            {
                DatosUsuario = new Usuario { CorreoElectronico = reader.GetString("Correo_Usuario") }, // Supone que tienes una clase Usuario con esta propiedad
                TipoMembresia = new Membresia { Nombre = reader.GetString("Nombre_Membresia") }, // Supone que tienes una clase Membresia con esta propiedad
                Estado = reader.GetString("Estado"),
                Fechainicio = reader.GetDateTime("Fecha_Inicio"),
                Fechafinal = reader.GetDateTime("Fecha_Final"),
                SaldoDebe = reader.GetInt32("Saldo_Debe"),
                Pagado = reader.GetBoolean("Pagado"),
                DuracionAcumulada = reader.GetInt32("Duracion_Acumulada"),
                TiempoRestante = reader.GetInt32("Tiempo_Restante")
            };
            return perfil;
        }
    }
}
