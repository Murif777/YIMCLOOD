using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.ENTITY
{
    public class Votante : Persona
    {
        public Votante() : base()
        {
                
        }
        public LugarVotacion LugarVotacion { get; set; }
    }
}
