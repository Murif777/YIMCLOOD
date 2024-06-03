using DAL;
using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class PMembresiaService : ICrud<PerfilMembresia>
    {
        private PMembresiaRepository PmembresiaRepository = new PMembresiaRepository();

        public string Registrar(PerfilMembresia perfil)
        {
            try
            {
                var perfilCompleto = CrearPerfilCompleto(perfil);
                return PmembresiaRepository.GuardarPMembresiaBD(perfilCompleto);
            }
            catch (Exception ex)
            {
                return "rror al registrar: " + ex.Message;
            }
        }

        private PerfilMembresia CrearPerfilCompleto(PerfilMembresia perfil)
        {
            var perfilCompleto = new PerfilMembresia();

            perfilCompleto.DatosUsuario = perfil.DatosUsuario;
            perfilCompleto.TipoMembresia = perfil.TipoMembresia;
            perfilCompleto.Fechainicio = DateTime.Now;
            perfilCompleto.Fechafinal = DateTime.Now.Add(perfil.TipoMembresia.Duracion);
            perfilCompleto.DuracionAcumulada = CalcularDuracionAcumulada(perfilCompleto.Fechainicio, DateTime.Now, perfilCompleto.TipoMembresia.Duracion);
            perfilCompleto.TiempoRestante = CalcularTiempoRestante(perfilCompleto.Fechafinal);
                     
            perfilCompleto.Pagado =perfil.Pagado;
            perfilCompleto.Estado = DeterminarEstado(perfil);
            perfilCompleto.SaldoDebe = CalcularSaldoDebe(perfil);
            Console.WriteLine(perfil.Pagado);
            Console.WriteLine(perfilCompleto.DuracionAcumulada);
            Console.WriteLine(perfilCompleto.TiempoRestante);
            return perfilCompleto;
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
                perfil.DuracionAcumulada += perfil.TipoMembresia.Duracion.Days;
                perfil.Fechainicio = DateTime.Now;
                perfil.Fechafinal = perfil.Fechainicio.AddDays(perfil.TipoMembresia.Duracion.Days);
                perfil.TiempoRestante = perfil.TipoMembresia.Duracion.Days;
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
        private int CalcularDuracionAcumulada(DateTime fechaInicio, DateTime fechaFin, TimeSpan duracionMembresia)
        {
            int totalDias = (int)(fechaFin - fechaInicio).TotalDays;
            double promedioDiasPorMes = 365.25 / 12; // 365.25 es el promedio de días por año, considerando los años bisiestos
            int totalMeses = (int)(totalDias / promedioDiasPorMes);

            return totalMeses;
        }
        private int CalcularTiempoRestante(DateTime fechaFinal)
        {
            TimeSpan diferencia = fechaFinal - DateTime.Now;
            return (int)diferencia.TotalDays; // Convertir la diferencia de tiempo a días
        }
    }
}
