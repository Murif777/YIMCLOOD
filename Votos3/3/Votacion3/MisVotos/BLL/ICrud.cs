using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.BLL
{
    public interface ICrud<T>
    {
        string Add(T entidad);
        string Update(T entidad);
        string Delete(T entidad);
        List<Votante> GetAll();
        List<LugarVotacion> GetLugarVotAll();
    }
}
