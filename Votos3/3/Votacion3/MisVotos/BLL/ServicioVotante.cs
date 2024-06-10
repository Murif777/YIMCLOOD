using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.BLL
{
    public class ServicioVotante : ICrud<Votante>
    {
        List<Votante> votantes;
        public ServicioVotante()
        {
            votantes = new List<Votante>();       
        }
        public string Add(Votante entidad)
        {
            
            try
            {
                votantes.Add(entidad);
                return $"se agrego el votante {entidad.Nombre}";
            }
            catch (Exception)
            {
                return "no se agrego el votante";
            }
            
        }

        public string Delete(Votante entidad)
        {
            try
            { 
                    votantes.Remove(entidad);
            return $"Se eliminó el votante {entidad.Nombre}";
            }
            catch (Exception)
            {
                return "No se pudo eliminar el votante.";
            }
        }
       
        public List<Votante> GetAll()
        {
            if (votantes.Count == 0)
            {
                return null ;
            }
            return votantes;
        }

        public List<Votante> GetBySex(string sexo)
        {
            List <Votante> lista= new List<Votante> ();

            foreach (var item in votantes)
            {
                if (item.Sexo.ToUpper()==sexo)
                {
                    lista.Add(item);
                }
            }
            return lista;
        }

        public string Update(Votante entidad)
        {
            if (entidad is null)
            {
                return "Imposible realizar la actulizacion del votante";
            }
            var v = GetByCedula(entidad.Cedula);
            v = entidad;
            return "votante actualizado";
        }
        public Votante GetByCedula(string cedula)
        {
            foreach (var item in votantes)
            {
                if (item.Cedula == cedula)
                {
                    return item;
                }
            }
            return null;
        }

        public List<LugarVotacion> GetLugarVotAll()
        {
            throw new NotImplementedException();
        }
    }
}
