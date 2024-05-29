﻿using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MiembroRepository:ConexionBD
    {
       
        public string GuardarMiembroBD(Miembro miembro)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            string sql = "INSERT INTO Miembros(Id, Cedula, Nombre, Apellido, Telefono, Sexo, Correo, FechaNacimiento, DatosUsuario, Peso, Estatura, TipoMembresia, Foto) " +
                  "VALUES (@Id, @Cedula, @Nombre, @Apellido, @Telefono, @Sexo, @Correo, @FechaNacimiento, @DatosUsuario, @Peso, @Estatura, @TipoMembresia, @Foto)";
            MySqlConnection conexionBd = new MySqlConnection();
            conexionBd = conexion();
            try
            {
                //AbrirConexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                comando.Parameters.AddWithValue("@Id", miembro.Id);
                comando.Parameters.AddWithValue("@Cedula", miembro.Cedula);
                comando.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                comando.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                comando.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                comando.Parameters.AddWithValue("@Sexo", miembro.Sexo);
                comando.Parameters.AddWithValue("@Correo", miembro.Correo);
                comando.Parameters.AddWithValue("@FechaNacimiento", miembro.FechaNacimiento.ToString("yyyy-MM-dd")); // Formato de fecha de MySQL
                comando.Parameters.AddWithValue("@DatosUsuario", miembro.DatosUsuario);
                comando.Parameters.AddWithValue("@Peso", miembro.Peso);
                comando.Parameters.AddWithValue("@Estatura", miembro.Estatura);
                comando.Parameters.AddWithValue("@TipoMembresia", miembro.TipoMembresia);
                comando.Parameters.AddWithValue("@Foto", miembro.Foto);
                var res=comando.ExecuteNonQuery();
                if (res==0)
                {
                    return "Miembro no guardado";
                }
                if (res!=0)
                {
                    return $"Miembro registrado {usuarioRepository.GuardarUsuarioBD(miembro, null)}";
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

    }
}