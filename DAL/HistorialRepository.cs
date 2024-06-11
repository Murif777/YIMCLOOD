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
            string sqlRegistro = "INSERT INTO Registros (Peso, Hombros, Pecho, AntebrazoIzquierdo, AntebrazoDerecho, " +
                                 "BrazoIzquierdo, BrazoDerecho, Cintura, Cadera, PiernaIzquierda, PiernaDerecha, " +
                                 "GemeloIzquierdo, GemeloDerecho, Altura, Foto) " +
                                 "VALUES (@Peso, @Hombros, @Pecho, @AntebrazoIzquierdo, @AntebrazoDerecho, " +
                                 "@BrazoIzquierdo, @BrazoDerecho, @Cintura, @Cadera, @PiernaIzquierda, @PiernaDerecha, " +
                                 "@GemeloIzquierdo, @GemeloDerecho, @Altura, @Foto); " +
                                 "SELECT LAST_INSERT_ID();";

            string sqlHistorial = "INSERT INTO Historial (Cedula_Miembro, Fecha, Registro_Id) " +
                                  "VALUES (@CedulaMiembro, @Fecha, @RegistroId)";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            MySqlTransaction transaction = null;
            try
            {
                conexionBd.Open();
                transaction = conexionBd.BeginTransaction();

                MySqlCommand comandoRegistro = new MySqlCommand(sqlRegistro, conexionBd, transaction);
                comandoRegistro.Parameters.AddWithValue("@Peso", historial.Registro.Peso);
                comandoRegistro.Parameters.AddWithValue("@Hombros", historial.Registro.Hombros);
                comandoRegistro.Parameters.AddWithValue("@Pecho", historial.Registro.Pecho);
                comandoRegistro.Parameters.AddWithValue("@AntebrazoIzquierdo", historial.Registro.AntebrazoIzquierdo);
                comandoRegistro.Parameters.AddWithValue("@AntebrazoDerecho", historial.Registro.AntebrazoDerecho);
                comandoRegistro.Parameters.AddWithValue("@BrazoIzquierdo", historial.Registro.BrazoIzquierdo);
                comandoRegistro.Parameters.AddWithValue("@BrazoDerecho", historial.Registro.BrazoDerecho);
                comandoRegistro.Parameters.AddWithValue("@Cintura", historial.Registro.Cintura);
                comandoRegistro.Parameters.AddWithValue("@Cadera", historial.Registro.Cadera);
                comandoRegistro.Parameters.AddWithValue("@PiernaIzquierda", historial.Registro.PiernaIzquierda);
                comandoRegistro.Parameters.AddWithValue("@PiernaDerecha", historial.Registro.PiernaDerecha);
                comandoRegistro.Parameters.AddWithValue("@GemeloIzquierdo", historial.Registro.GemeloIzquierdo);
                comandoRegistro.Parameters.AddWithValue("@GemeloDerecho", historial.Registro.GemeloDerecho);
                comandoRegistro.Parameters.AddWithValue("@Altura", historial.Registro.Altura);
                comandoRegistro.Parameters.AddWithValue("@Foto", historial.Registro.Foto);

                int registroId = Convert.ToInt32(comandoRegistro.ExecuteScalar());

                MySqlCommand comandoHistorial = new MySqlCommand(sqlHistorial, conexionBd, transaction);
                comandoHistorial.Parameters.AddWithValue("@CedulaMiembro", historial.Miembro.Cedula);
                comandoHistorial.Parameters.AddWithValue("@Fecha", historial.Fecha); // Asignar la fecha actual
                comandoHistorial.Parameters.AddWithValue("@RegistroId", registroId);

                int res = comandoHistorial.ExecuteNonQuery();
                if (res == 0)
                {
                    transaction.Rollback();
                    return "Historial no guardado";
                }

                transaction.Commit();
                return "Historial guardado";
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback();
                return "Error al guardar: " + ex.Message;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        public List<Historial> ConsultarCed(string ced)
        {
            List<Historial> historiales = new List<Historial>();
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            string sql = "SELECT h.Cedula_Miembro, h.Fecha, h.Registro_Id, " +
                         "r.Peso, r.Hombros, r.Pecho, r.AntebrazoIzquierdo, r.AntebrazoDerecho, " +
                         "r.BrazoIzquierdo, r.BrazoDerecho, r.Cintura, r.Cadera, r.PiernaIzquierda, " +
                         "r.PiernaDerecha, r.GemeloIzquierdo, r.GemeloDerecho, r.Altura, r.Foto " +
                         "FROM Historial h " +
                         "INNER JOIN Registros r ON h.Registro_Id = r.Id " +
                         "WHERE h.Cedula_Miembro = @Cedula";

            using (MySqlCommand command = new MySqlCommand(sql, conexionBd))
            {
                command.Parameters.AddWithValue("@Cedula", ced);
                conexionBd.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Registro registro = new Registro
                        {
                            Id = reader.GetInt32("Registro_Id"),
                            Peso = reader.IsDBNull(reader.GetOrdinal("Peso")) ? (int?)null : reader.GetInt32("Peso"),
                            Hombros = reader.IsDBNull(reader.GetOrdinal("Hombros")) ? (int?)null : reader.GetInt32("Hombros"),
                            Pecho = reader.IsDBNull(reader.GetOrdinal("Pecho")) ? (int?)null : reader.GetInt32("Pecho"),
                            AntebrazoIzquierdo = reader.IsDBNull(reader.GetOrdinal("AntebrazoIzquierdo")) ? (int?)null : reader.GetInt32("AntebrazoIzquierdo"),
                            AntebrazoDerecho = reader.IsDBNull(reader.GetOrdinal("AntebrazoDerecho")) ? (int?)null : reader.GetInt32("AntebrazoDerecho"),
                            BrazoIzquierdo = reader.IsDBNull(reader.GetOrdinal("BrazoIzquierdo")) ? (int?)null : reader.GetInt32("BrazoIzquierdo"),
                            BrazoDerecho = reader.IsDBNull(reader.GetOrdinal("BrazoDerecho")) ? (int?)null : reader.GetInt32("BrazoDerecho"),
                            Cintura = reader.IsDBNull(reader.GetOrdinal("Cintura")) ? (int?)null : reader.GetInt32("Cintura"),
                            Cadera = reader.IsDBNull(reader.GetOrdinal("Cadera")) ? (int?)null : reader.GetInt32("Cadera"),
                            PiernaIzquierda = reader.IsDBNull(reader.GetOrdinal("PiernaIzquierda")) ? (int?)null : reader.GetInt32("PiernaIzquierda"),
                            PiernaDerecha = reader.IsDBNull(reader.GetOrdinal("PiernaDerecha")) ? (int?)null : reader.GetInt32("PiernaDerecha"),
                            GemeloIzquierdo = reader.IsDBNull(reader.GetOrdinal("GemeloIzquierdo")) ? (int?)null : reader.GetInt32("GemeloIzquierdo"),
                            GemeloDerecho = reader.IsDBNull(reader.GetOrdinal("GemeloDerecho")) ? (int?)null : reader.GetInt32("GemeloDerecho"),
                            Altura = reader.IsDBNull(reader.GetOrdinal("Altura")) ? (int?)null : reader.GetInt32("Altura"),
                            Foto = reader.IsDBNull(reader.GetOrdinal("Foto")) ? null : (byte[])reader["Foto"]
                        };

                        Historial historial = new Historial
                        {
                            Miembro = new Miembro { Cedula = reader.GetString("Cedula_Miembro") },
                            Fecha = reader.GetDateTime("Fecha"),
                            Registro = registro
                        };

                        historiales.Add(historial);
                    }
                }

                conexionBd.Close();
            }

            return historiales;
        }


    }
}