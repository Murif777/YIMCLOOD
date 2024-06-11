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
        public int Id { get; set; }
        public int? Peso { get; set; }
        public int? Hombros { get; set; }
        public int? Pecho { get; set; }
        public int? AntebrazoIzquierdo { get; set; }
        public int? AntebrazoDerecho { get; set; }
        public int? BrazoIzquierdo { get; set; }
        public int? BrazoDerecho { get; set; }
        public int? Cintura { get; set; }
        public int? Cadera { get; set; }
        public int? PiernaIzquierda { get; set; }
        public int? PiernaDerecha { get; set; }
        public int? GemeloIzquierdo { get; set; }
        public int? GemeloDerecho { get; set; }
        public int? Altura { get; set; }
        public Registro()
        {
        }
        public Registro(int id, int peso)
        {
            Id = id;
            Peso = peso;
        }
    }
}
