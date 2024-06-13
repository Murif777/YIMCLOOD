using ENTITY;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class ConexionBD
    {
        private string servidor = "127.0.0.1";
        private string bd = "yimclood";
        private static MySqlConnection conexionBd;
        private  string user;
        private  string password;

        // Método para crear la cadena de conexión y la conexión
        private MySqlConnection CrearConexion( )
        {
            string cadenaConexion = $"Server={servidor};Database={bd};Uid={user};Pwd={password};";
            Console.WriteLine("Cadena de conexión: " + cadenaConexion);  // Para depuración

            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                Console.WriteLine("Conexión creada exitosamente.");  // Depuración
                return conexion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al crear la conexión: " + ex.Message);
                return null;
            }
        }

        // Método para iniciar sesión y abrir la conexión
        public bool Login(Usuario usuario)
        {
            user=usuario.CorreoElectronico;
            password = usuario.Clave;

            miembro(); 
            conexionBd = CrearConexion();

            if (conexionBd == null)
            {
                Console.WriteLine("La conexión no pudo ser creada."+user);
                return false;
            }

            try
            {
               //// // conexionBd.Open();
                Console.WriteLine("Conexión abierta exitosamente.");  // Depuración
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al intentar conectar con la base de datos: " + ex.Message);
                conexionBd.Dispose();
                conexionBd = null;  // Asegurarse de que la conexión no válida no se retiene
                return false;
            }
        }
        public MySqlConnection conexionBD()
        {
            if (conexionBd.State == System.Data.ConnectionState.Closed)
            {
                conexionBd.Open();
            }
            if (conexionBd != null && conexionBd.State == System.Data.ConnectionState.Open)
            {
                return conexionBd;
            }
            
            else
            {
                Console.WriteLine("No hay conexión abierta.");
                return null;
            }
        }
        public void Cerrarconexion() 
        {
            if (conexionBd.State == System.Data.ConnectionState.Open)
            {
                conexionBd.Close();
            }
        }
        public Usuario UsuariodeRecuperacion()
        {
            Usuario usuario = new Usuario
            {
                CorreoElectronico = "usuarioRecuperacion",
                Clave = "123"
            };
            return usuario;
        }
        private void miembro()
        {
            if (user != "root" && user != "admin")
            {
                user = "miembro";
                password = "123";
            }
        }
    }
}
