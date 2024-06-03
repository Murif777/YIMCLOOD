using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HistorialRepository : ConexionBD
    {
        public string GuardarHistorialBD(Historial historial)
        {
            string sql = "INSERT INTO historiales(Miembro, DiaDeLaSemana, Registro ,Rutina) " +
                  "VALUES (@Miembro, @DiaDeLaSemana, @Registro, @Rutina)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Miembro", historial.Miembro.Cedula);
                comando.Parameters.AddWithValue("@DiaDeLaSemana", historial.DiaDeLaSemana);
                comando.Parameters.AddWithValue("@Registro", historial.Registro);
                comando.Parameters.AddWithValue("@Rutina", historial.Rutina);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Historial no guardado";
                }
                if (res != 0)
                {
                    return "Historial guardado";
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
        public List<Historial> ConsultarTodos()
        {
            List<Historial> historiales = new List<Historial>();
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            string sql = @"SELECT h.*, m.*, r.*
                       FROM Historial h
                       INNER JOIN Miembros m ON h.Id_Miembro = m.Id
                       INNER JOIN Registros r ON h.Id_Registro = r.Id";
            using (MySqlCommand command = new MySqlCommand(sql, conexionBd))
            {
                conexionBd.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Historial historial = new Historial();

                        historial.Miembro = new Miembro
                        {
                            Cedula = reader.GetString("Cedula"),
                            Nombre = reader.GetString("Nombre"),
                            Apellido = reader.GetString("Apellido"),
                            Telefono = reader.GetString("Telefono"),
                            Sexo = reader.GetString("Sexo"),
                            FechaNacimiento = reader.GetDateTime("Fecha_Nacimiento"),
                            Correo = reader.GetString("Correo_Electrinca"),
                            Peso = reader.GetInt32("Peso"),
                            Estatura = reader.GetInt32("Estatura"),
                            Foto = null
                            // Asignar otras propiedades del Miembro de manera similar
                        };

                        //historial.Registro = new Registro
                        //{
                        //    Id = int.Parse(reader.GetString("Id")),
                        //    Miembro = historial.Miembro,
                        //    Fecha = reader.GetDateTime("Fecha"),
                        //    Peso = reader.GetDouble("Peso")
                        //};
                        historial.DiaDeLaSemana = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), reader.GetString("DiaDeLaSemana"));
                        historiales.Add(historial);
                    }
                }
                return historiales;
            }
        }

    }
}