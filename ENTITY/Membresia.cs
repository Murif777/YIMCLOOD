﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Membresia
    {
        public Membresia() { }
        public Membresia(
            int idmembresia,
            string nombre,
            string descripcion,
            int valor,
            int duracionMeses
            ) {
            Idmembresia = idmembresia;
            Nombre = nombre;
            Descripcion = descripcion;
            Valor = valor;
            DuracionMeses = duracionMeses;
        }
        public int Idmembresia { get;  set; }
        public string Nombre { get;  set; }
        public string Descripcion { get;  set; }
        public int Valor { get;  set; }
        public int DuracionMeses { get;  set; }
    }
}
