using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RutinaRepository:ConexionBD
    {
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
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sqlRutina, conexionBd);
                comando.Parameters.AddWithValue("@IdMiembro", rutina.Miembro);
                comando.Parameters.AddWithValue("@Nombre", rutina.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", rutina.Descripcion);

                MySqlCommand comandoRutina = new MySqlCommand(sqlRutinaEjercicio, conexionBd);
                string idRutina = comandoRutina.LastInsertedId.ToString();

                // Guardar los ejercicios asociados a la rutina
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
                //CerrarConexion();
            }
        }
       
        //faltan metodos buscar eliminar y actualizar
    }
}
