﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PerfilMembresia
    {
        public Membresia TipoMembresia { get; set; }
        public string Estado { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafinal { get; set; }
        public int SaldoDebe { get; set; }
        public bool Pagado { get; set; }
        public Usuario DatosUsuario { get;  set; }
        public int DuracionAcumulada { get; set; }
        public int TiempoRestante { get; set; }

        public PerfilMembresia() { }
        public PerfilMembresia(
            Usuario usuario,
            Membresia tipomembresia,
            string estado,
            DateTime fechainicio,
            DateTime fechafinal,
            int saldodebe,
            bool pagado,
            int duracionAcumulada,
            int tiempoRestante
            ) {
             DatosUsuario = usuario;
            TipoMembresia= tipomembresia;
            Estado = estado;
            Fechainicio = fechainicio;
            Fechafinal = fechafinal;
            SaldoDebe = saldodebe;
            Pagado = pagado;
            DuracionAcumulada = duracionAcumulada;
            TiempoRestante = tiempoRestante;
        }
    }
}
