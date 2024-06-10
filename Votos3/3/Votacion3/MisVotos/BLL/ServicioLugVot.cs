using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.BLL
{
    public class ServicioLugVot : ICrud<LugarVotacion>
    {
        List<LugarVotacion> LugarVotacions;
        public ServicioLugVot()
        {
            LugarVotacions = new List<LugarVotacion>();
        }
        public string Add(LugarVotacion entidad)
        {
            try
            {
                LugarVotacions.Add(entidad);
                return $"se agrego el votante {entidad.Descripcion}";
            }
            catch (Exception)
            {
                return "no se agrego el votante";
            }
        }

        public string Delete(LugarVotacion entidad)
        {
            try
            {
                LugarVotacion lugar = null;
                foreach (var L in LugarVotacions)
                {
                    if (L.Codigo == entidad.Codigo)
                    {
                        lugar = L;
                        break;
                    }
                }
                if (lugar != null)
                {
                    LugarVotacions.Remove(lugar);
                    return $"Se eliminó el lugar {entidad.Descripcion}";
                }
                else
                {
                    return "Lugar no encontrado. No se realizó la eliminación.";
                }
            }
            catch (Exception)
            {
                return "No se pudo eliminar el lugar";
            }
        }

        public List<Votante> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<LugarVotacion> GetLugarVotAll()
        {
            if (LugarVotacions.Count == 0)
            {
                return null;
            }
            return LugarVotacions;
        }
        public string Update(LugarVotacion entidad)
        {
            if (entidad is null)
            {
                return "Imposible realizar la actulizacion del lugar de votacion";
            }
            var L = GetByCode(entidad.Codigo);
            L = entidad;
            return "Lugar de votacion actualizado";
        }
        public LugarVotacion GetByCode(string Code)
        {
            foreach (var item in LugarVotacions)
            {
                if (item.Codigo == Code)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
