using DAL;
using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class PMembresiaService:ICrud<PerfilMembresia>
    {
        private readonly PMembresiaRepository pmRepository;

        public PMembresiaService(PMembresiaRepository repository)
        {
            pmRepository = repository;
        }

        public string Registrar(PerfilMembresia perfil)
        {
            try
            {
                var perfilCompleto = CrearPerfilCompleto(perfil.DatosUsuario, perfil.TipoMembresia);
                return pmRepository.GuardarPMembresiaBD(perfilCompleto);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }

        private PerfilMembresia CrearPerfilCompleto(Usuario usuario, Membresia membresia)
        {
            var perfil = new PerfilMembresia
            {
                DatosUsuario = usuario,
                TipoMembresia = membresia,
                Fechainicio = DateTime.Now,
                Fechafinal = DateTime.Now.Add(membresia.Duracion),
                DuracionAcumulada = TimeSpan.FromDays(membresia.Duracion.Days),
                TiempoRestante = TimeSpan.FromDays(membresia.Duracion.Days)
            };

            perfil.Pagado = EsPagado(perfil);
            perfil.Estado = DeterminarEstado(perfil);
            perfil.SaldoDebe = CalcularSaldoDebe(perfil);

            return perfil;
        }

        private string DeterminarEstado(PerfilMembresia perfil)
        {
            if (perfil.Pagado)
            {
                return "Activo";
            }

            var fechaVencimiento = perfil.Fechainicio.Add(perfil.TipoMembresia.Duracion);
            var fechaFinalConPeriodoDeGracia = fechaVencimiento.AddDays(15);

            return DateTime.Now <= fechaFinalConPeriodoDeGracia ? "Deudor" : "Cancelada";
        }

        public string RenovarMembresia(PerfilMembresia perfil)
        {
            if (perfil.Pagado)
            {
                perfil.DuracionAcumulada += TimeSpan.FromDays(perfil.TipoMembresia.Duracion.Days);
                perfil.Fechainicio = DateTime.Now;
                perfil.Fechafinal = perfil.Fechainicio.AddDays(perfil.TipoMembresia.Duracion.Days);
                perfil.TiempoRestante = TimeSpan.FromDays(perfil.TipoMembresia.Duracion.Days);
                perfil.Estado = "Activo";
            }
            else
            {
                perfil.Estado = DeterminarEstado(perfil);
            }

            return perfil.Estado;
        }

        private int CalcularSaldoDebe(PerfilMembresia perfil)
        {
            return perfil.Pagado ? 0 : perfil.TipoMembresia.Valor;
        }

        private bool EsPagado(PerfilMembresia perfil)
        {
            var fechaVencimiento = perfil.Fechainicio.Add(perfil.TipoMembresia.Duracion);
            var fechaFinalConPeriodoDeGracia = fechaVencimiento.AddDays(15);

            return DateTime.Now <= fechaFinalConPeriodoDeGracia && perfil.SaldoDebe == 0;
        }
    }

}
