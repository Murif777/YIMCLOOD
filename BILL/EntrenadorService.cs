﻿using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class EntrenadorService:ICrud<Entrenador>
    {
        EntrenadorRepository en_repository = new EntrenadorRepository();
        public string Registrar(Entrenador entrenador)
        {
            try
            {
                return en_repository.GuardarEntrenadorBD(entrenador);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public List<Entrenador> Consultar()
        {
            try
            {
                return en_repository.Consultar();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Entrenador> ConsultarCed(string cedula)
        {
            try
            {
                return en_repository.ConsultarCed(cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error:" + ex.Message);

                return null;
            }
        }
        public string EliminarEntrenador(string cedulaEntrenador)
        {
            return en_repository.EliminarEntrenador(cedulaEntrenador);
        }

        public string ActualizarEntrenador(Entrenador entrenador)
        {
            try
            {
                return en_repository.ActualizarEntrenador(entrenador);
                //return m_repository.AbrirConexion().ToString();
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }

        }
    }
}
