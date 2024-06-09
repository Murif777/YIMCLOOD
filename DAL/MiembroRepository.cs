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
            string sqlMiembros = "DELETE FROM Miembros WHERE Cedula = @Cedula";

            using (MySqlConnection conexionBd = conexion())
            {
                conexionBd.Open();
                using (MySqlTransaction transaction = conexionBd.BeginTransaction())
                {
                    try
                    {
                        // Eliminar de Miembros
                        using (MySqlCommand comando = new MySqlCommand(sqlMiembros, conexionBd, transaction))
                        {
                            comando.Parameters.AddWithValue("@Cedula", cedula);
                            comando.ExecuteNonQuery();
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
                "Correo_Electronico=@Correo, Peso=@Peso, Estatura=@Estatura, Foto=@Foto WHERE Cedula=@Cedula";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                conexionBd.Open();
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
                return "Error al actualizar " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
                //CerrarConexion();
            }
            return null;
        }

    }


}



