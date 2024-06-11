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
            string sql = "INSERT INTO rutinas_miembro (Id_Rutina, Miembro_Cedula) " +
                         "VALUES (@Id_Rutina, @Miembro_Cedula)";
            MySqlConnection conexionBd = conexion();
            try
            {
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Id_Rutina", rutina.Id);
                comando.Parameters.AddWithValue("@Miembro_Cedula", rutina.Miembro.Cedula);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Rutina no guardada";
                }
                else
                {
                    return "Rutina guardada";
                }
            }
            catch (MySqlException ex)
            {
                return "Error al guardar rutina: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }
        public string GuardarRutinaPersoBD(Rutina rutina)
        {
            MySqlConnection conexionBd = conexion();

            try
            {
                conexionBd.Open();

                // Insertar en la tabla Rutinas
                string sqlRutinas = "INSERT INTO Rutinas (Nombre, Descripcion,EsPredefinida ) " +
                                    "VALUES (@Nombre, @Descripcion,@EsPredefinida )";
                MySqlCommand comandoRutinas = new MySqlCommand(sqlRutinas, conexionBd);
                comandoRutinas.Parameters.AddWithValue("@Nombre", rutina.Nombre);
                comandoRutinas.Parameters.AddWithValue("@Descripcion", rutina.Descripcion);
                comandoRutinas.Parameters.AddWithValue("@EsPredefinida", false);
                comandoRutinas.ExecuteNonQuery();

                // Obtener el ID de la última rutina insertada
                int lastInsertedId = (int)comandoRutinas.LastInsertedId;

                //Insertar en la tabla Rutinas_Miembro
                string sqlRutinasMiembro = "INSERT INTO Rutinas_Miembro (Id_Rutina, Miembro_Cedula) " +
                                           "VALUES (@Id_Rutina, @Miembro_Cedula)";
                MySqlCommand comandoRutinasMiembro = new MySqlCommand(sqlRutinasMiembro, conexionBd);
                comandoRutinasMiembro.Parameters.AddWithValue("@Id_Rutina", lastInsertedId);
                comandoRutinasMiembro.Parameters.AddWithValue("@Miembro_Cedula", rutina.Miembro.Cedula);
                comandoRutinasMiembro.ExecuteNonQuery();

                // Insertar en la tabla Rutinas_Ejercicios
                foreach (Ejercicio ejercicio in rutina.Ejercicios)
                {
                    string sqlRutinasEjercicios = "INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) " +
                                                   "VALUES (@Rutina_Id, @Ejercicio_Nombre)";
                    MySqlCommand comandoRutinasEjercicios = new MySqlCommand(sqlRutinasEjercicios, conexionBd);
                    comandoRutinasEjercicios.Parameters.AddWithValue("@Rutina_Id", lastInsertedId);
                    comandoRutinasEjercicios.Parameters.AddWithValue("@Ejercicio_Nombre", ejercicio.Nombre);
                    comandoRutinasEjercicios.ExecuteNonQuery();
                }

                return "Rutina guardada exitosamente";
            }
            catch (MySqlException ex)
            {
                return "Error al guardar la rutina: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        public List<Rutina> ConsultarPrees()
        {
            List<Rutina> rutinas = new List<Rutina>();

            string ssql = @"SELECT r.Id AS RutinaId, r.Nombre AS RutinaNombre, r.Descripcion AS RutinaDescripcion,
               re.Ejercicio_Nombre AS EjercicioNombre, e.Descripcion AS EjercicioDescripcion, e.Duracion AS EjercicioDuracion,
               e.Repeticiones AS EjercicioRepeticiones, e.Series AS EjercicioSeries, e.Musculo AS EjercicioMusculo,
               e.Categoria AS EjercicioCategoria, e.Foto AS EjercicioFoto
               FROM Rutinas r
               INNER JOIN Rutinas_Ejercicios re ON r.Id = re.Id_Rutina
               INNER JOIN Ejercicios e ON re.Ejercicio_Nombre = e.Nombre
               WHERE r.EsPredefinida = TRUE;";

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
                        rutina = MapRutina(reader, false);
                        rutina.Ejercicios = new List<Ejercicio>();
                        rutinas.Add(rutina);
                    }

                    Ejercicio ejercicio = MapEjercicio(reader);
                    rutina.Ejercicios.Add(ejercicio);
                }
                foreach (var item in rutinas)
                {
                    Console.WriteLine(item.Nombre);
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
        public List<Rutina> ConsultarPersonalizadas(string cedula)
        {
            List<Rutina> rutinas = new List<Rutina>();

            string ssql = "SELECT r.Id AS RutinaId, r.Nombre AS RutinaNombre, r.Descripcion AS RutinaDescripcion, " +
              "rm.Miembro_Cedula AS RutinaMiembroCedula, m.Nombre AS MiembroNombre, m.Apellido AS MiembroApellido, " +
              "re.Ejercicio_Nombre AS EjercicioNombre, e.Descripcion AS EjercicioDescripcion, e.Duracion AS EjercicioDuracion, " +
              "e.Repeticiones AS EjercicioRepeticiones, e.Series AS EjercicioSeries, e.Musculo AS EjercicioMusculo, " +
              "e.Categoria AS EjercicioCategoria, e.Foto AS EjercicioFoto " +
              "FROM Rutinas r " +
              "INNER JOIN Rutinas_Miembro rm ON r.Id = rm.Id_Rutina " +
              "INNER JOIN Miembros m ON rm.Miembro_Cedula = m.Cedula " +
              "INNER JOIN Rutinas_Ejercicios re ON r.Id = re.Id_Rutina " +
              "INNER JOIN Ejercicios e ON re.Ejercicio_Nombre = e.Nombre " +
              "WHERE rm.Miembro_Cedula = @Cedula";

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
                        rutina = MapRutina(reader, true);
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
        public string EliminarRutinaPersonalizada(string nombre)
        {
            string sqlDeleteRutina = "DELETE FROM Rutinas WHERE Nombre = @Nombre AND EsPredefinida = FALSE ";
            MySqlConnection conexionBd = conexion();

            try
            {
                using (MySqlCommand comando = new MySqlCommand(sqlDeleteRutina, conexionBd))
                {
                    conexionBd.Open();
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    int rowsAffected = comando.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return "Rutina personalizada eliminada exitosamente.";
                    }
                    else
                    {
                        return "No se encontró ninguna rutina personalizada con ese nombre.";
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Error al intentar eliminar la rutina personalizada: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        private Rutina MapRutina(MySqlDataReader reader, bool includeMember)
        {
            Rutina rutina = new Rutina();
            rutina.Id = reader.GetInt32("RutinaId");
            rutina.Nombre = reader.GetString("RutinaNombre");
            rutina.Descripcion = reader.GetString("RutinaDescripcion");

            if (includeMember)
            {
                Miembro miembro = new Miembro();
                miembro.Cedula = reader.GetString("RutinaMiembroCedula");
                miembro.Nombre = reader.GetString("MiembroNombre");
                miembro.Apellido = reader.GetString("MiembroApellido");
                rutina.Miembro = miembro;
            }

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
