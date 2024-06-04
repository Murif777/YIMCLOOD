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
    public class CategoriaRepository:ConexionBD
    {
        public string GuardarCategoriaBD(CategoriaEjercicio categoria)
        {
            string sql = "INSERT INTO categorias(Nombre,Descripcion) " +
                  "VALUES (@Nombre, @Descripcion)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                var res = comando.ExecuteNonQuery();
                if (res == 0)
                {
                    return "Categoria no guardada";
                }
                if (res != 0)
                {
                    return "Categoria guardada";
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
        public List<CategoriaEjercicio> ConsultarCategorias()
        {
            List<CategoriaEjercicio> categorias = new List<CategoriaEjercicio>();

            string ssql = $"select * from categorias_ejercicios";

            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(ssql, conexionBd);
                conexionBd.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(Map(reader));
                }
                return categorias;
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                conexionBd.Close();
            }
        }

        private CategoriaEjercicio Map(MySqlDataReader reader)
        {
            CategoriaEjercicio categoria = new CategoriaEjercicio();
            categoria.Nombre = reader.GetString(0);
            categoria.Descripcion = reader.GetString(1);
            return categoria;
        }
    }
}
