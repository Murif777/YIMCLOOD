using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    using System;

    public class Registro
    {
        public byte[] Foto { get; set; }=null;
        public Miembro Miembro { get; set; }
        public DateTime Fecha { get; set; }
        public double Peso { get; set; }
        public double? Hombros { get; set; }
        public double? Pecho { get; set; }
        public double? AntebrazoIzquierdo { get; set; }
        public double? AntebrazoDerecho { get; set; }
        public double? BrazoIzquierdo { get; set; }
        public double? BrazoDerecho { get; set; }
        public double? Cintura { get; set; }
        public double? Cadera { get; set; }
        public double? PiernaIzquierda { get; set; }
        public double? PiernaDerecha { get; set; }
        public double? GemeloIzquierdo { get; set; }
        public double? GemeloDerecho { get; set; }
        public double? Altura { get; set; }

        public Registro(Miembro miembro, DateTime fecha, double peso)
        {
            Miembro = miembro;
            Fecha = fecha;
            Peso = peso;
        }
    }
}
