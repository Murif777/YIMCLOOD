using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RutinaRepository:ConexionBD
    {
        private EjercicioRepository EjercicioRepository = new EjercicioRepository();
        public string GuardarRutinaBD(Rutina rutina)
        {
            string sqlRutina = "INSERT INTO rutinas(IdMiembro, Nombre, Descripcion, Personalizada) " +
                  "VALUES (IdMiembro, @Nombre, @Descripcion, @Personalizada)";
            string sqlRutinaEjercicio = "INSERT INTO Rutina_Ejercicios(id_rutina, Nombre_ejercicio) " +
                                "VALUES (@IdRutina, @NombreEjercicio)";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sqlRutina, conexionBd);
                comando.Parameters.AddWithValue("@IdMiembro", rutina.Miembro);
                comando.Parameters.AddWithValue("@Nombre", rutina.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", rutina.Descripcion);

                MySqlCommand comandoRutina = new MySqlCommand(sqlRutinaEjercicio, conexionBd);
                string idRutina = comandoRutina.LastInsertedId.ToString();
                foreach (var ejercicio in rutina.Ejercicios)
                {
                    MySqlCommand comandoRutinaEjercicio = new MySqlCommand(sqlRutinaEjercicio, conexionBd);
                    comandoRutinaEjercicio.Parameters.AddWithValue("@IdRutina", idRutina);
                    comandoRutinaEjercicio.Parameters.AddWithValue("@NombreEjercicio", ejercicio.Nombre);
                    comandoRutinaEjercicio.ExecuteNonQuery();
                }
                return "Rutina guardada";
            }
            catch (MySqlException ex)
            {
                return "Error al guardar rutina" + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }


        public List<Rutina> ConsultarTodo()
        {
            List<Rutina> rutinas = new List<Rutina>();

            string ssql = "SELECT r.Id AS RutinaId, r.Nombre AS RutinaNombre, r.Descripcion AS RutinaDescripcion, " +
                          "r.Miembro_Cedula AS RutinaMiembroCedula, m.Nombre AS MiembroNombre, m.Apellido AS MiembroApellido, " +
                          "e.Nombre AS EjercicioNombre, e.Descripcion AS EjercicioDescripcion, e.Duracion AS EjercicioDuracion, " +
                          "e.Repeticiones AS EjercicioRepeticiones, e.Series AS EjercicioSeries, e.Musculo AS EjercicioMusculo, " +
                          "e.Categoria AS EjercicioCategoria, e.Foto AS EjercicioFoto " +
                          "FROM Rutinas r " +
                          "INNER JOIN Miembros m ON r.Miembro_Cedula = m.Cedula " +
                          "INNER JOIN Rutinas_Ejercicios re ON r.Id = re.Rutina_Id " +
                          "INNER JOIN Ejercicios e ON re.Ejercicio_Nombre = e.Nombre";

            MySqlConnection conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int rutinaId = reader.GetInt32("RutinaId");
                    Rutina rutina = rutinas.FirstOrDefault(r => r.Id == rutinaId);
                    if (rutina == null)
                    {
                        rutina = MapRutina(reader);
                        rutina.Ejercicios = new List<Ejercicio>();
                        rutinas.Add(rutina);
                    }

                    Ejercicio ejercicio = MapEjercicio(reader);
                    rutina.Ejercicios.Add(ejercicio);
                }
                Console.WriteLine("se está llenando");
                return rutinas;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lista vacía ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        public List<Rutina> ConsultarPersonalizadas(string cedula)
        {
            List<Rutina> rutinas = new List<Rutina>();

            string ssql = "SELECT r.Id AS RutinaId, r.Nombre AS RutinaNombre, r.Descripcion AS RutinaDescripcion, " +
                          "r.Miembro_Cedula AS RutinaMiembroCedula, m.Nombre AS MiembroNombre, m.Apellido AS MiembroApellido, " +
                          "e.Nombre AS EjercicioNombre, e.Descripcion AS EjercicioDescripcion, e.Duracion AS EjercicioDuracion, " +
                          "e.Repeticiones AS EjercicioRepeticiones, e.Series AS EjercicioSeries, e.Musculo AS EjercicioMusculo, " +
                          "e.Categoria AS EjercicioCategoria, e.Foto AS EjercicioFoto " +
                          "FROM Rutinas r " +
                          "INNER JOIN Miembros m ON r.Miembro_Cedula = m.Cedula " +
                          "INNER JOIN Rutinas_Ejercicios re ON r.Id = re.Rutina_Id " +
                          "INNER JOIN Ejercicios e ON re.Ejercicio_Nombre = e.Nombre" +
                          "WHERE m.Cedula = @Cedula ";

            MySqlConnection conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);

                conexionBd.Open();
                comando.Parameters.AddWithValue("@Cedula", cedula);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int rutinaId = reader.GetInt32("RutinaId");
                    Rutina rutina = rutinas.FirstOrDefault(r => r.Id == rutinaId);
                    if (rutina == null)
                    {
                        rutina = MapRutina(reader);
                        rutina.Ejercicios = new List<Ejercicio>();
                        rutinas.Add(rutina);
                    }

                    Ejercicio ejercicio = MapEjercicio(reader);
                    rutina.Ejercicios.Add(ejercicio);
                    Console.WriteLine(rutina.Id);
                }
                return rutinas;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lista vacía ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        private Rutina MapRutina(MySqlDataReader reader)
        {
            Rutina rutina = new Rutina();
            rutina.Id = reader.GetInt32("RutinaId");
            rutina.Nombre = reader.GetString("RutinaNombre");
            rutina.Descripcion = reader.GetString("RutinaDescripcion");

            Miembro miembro = new Miembro();
            miembro.Cedula = reader.GetString("RutinaMiembroCedula");
            miembro.Nombre = reader.GetString("MiembroNombre");
            miembro.Apellido = reader.GetString("MiembroApellido");
            rutina.Miembro = miembro;

            return rutina;
        }

        private Ejercicio MapEjercicio(MySqlDataReader reader)
        {
            Ejercicio ejercicio = new Ejercicio();
            ejercicio.Nombre = reader.GetString("EjercicioNombre");
            ejercicio.Descripcion = reader.GetString("EjercicioDescripcion");
            if (!reader.IsDBNull(reader.GetOrdinal("EjercicioDuracion")))
            {
                ejercicio.Duracion = reader.GetTimeSpan("EjercicioDuracion");
            }
            if (!reader.IsDBNull(reader.GetOrdinal("EjercicioRepeticiones")))
            {
                ejercicio.Repeticiones = reader.GetInt32("EjercicioRepeticiones");
            }
            if (!reader.IsDBNull(reader.GetOrdinal("EjercicioSeries")))
            {
                ejercicio.Series = reader.GetInt32("EjercicioSeries");
            }
            ejercicio.Musculo = reader.GetString("EjercicioMusculo");
            ejercicio.Categoria = reader.GetString("EjercicioCategoria");
            if (!reader.IsDBNull(reader.GetOrdinal("EjercicioFoto")))
            {
                ejercicio.Foto = (byte[])reader["EjercicioFoto"];
            }
            else
            {
                ejercicio.Foto = null;
            }

            return ejercicio;
        }
        //faltan metodos buscar eliminar y actualizar
    }
}
