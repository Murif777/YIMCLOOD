using DAL;
using ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class PMembresiaService : ICrud<PerfilMembresia>
    {
        private EmailService emailService = new EmailService();
        private PMembresiaRepository PmembresiaRepository = new PMembresiaRepository();
        private FacturaService facturaService = new FacturaService();
        public string Registrar(PerfilMembresia perfil)
        {
            try
            {
                var perfilCompleto = CrearPerfilCompleto(perfil);
                VerificarMembresias();

                return PmembresiaRepository.GuardarPMembresiaBD(perfilCompleto);
            }
            catch (Exception ex)
            {
                return "Error al registrAr: " + ex.Message;
            }
        }
        public List<PerfilMembresia> ConsultarCed(string cedula)
        {
            try
            {
                return PmembresiaRepository.ConsultarCed(cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("no esta leyendo " + ex.Message);
                return null;
            }
        }
        //public string Actualizar(PerfilMembresia perfil)
        //{
        //    try
        //    {
        //        // Crear el perfil completo si es necesario
        //        var perfilCompleto = CrearPerfilCompleto(perfil);

        //        // Llamar al método de actualización en el repositorio y obtener el resultado
        //        return PmembresiaRepository.ActualizarPMembresiaBD(perfilCompleto);
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error al actualizar: " + ex.Message;
        //    }
        //}

        public List<PerfilMembresia> consultartodo()
        {
            try
            {
                return PmembresiaRepository.ConsultarTodos();
            }
            catch (Exception ex)
            {
                Console.WriteLine("no esta leyendo "+ ex.Message);
                return null;
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
        public void VerificarMembresias()
        {
            List<PerfilMembresia> membresias = PmembresiaRepository.ConsultarTodos();
            if (membresias == null)
            {
                Console.WriteLine("no esta leyendo los datos");
            }
            DateTime hoy = DateTime.Now;
            foreach (PerfilMembresia perfil in membresias)
            {
                if (perfil.Fechainicio.Date == hoy.Date)
                {
                    //Notificación de inicio de membresía
                    string correo = perfil.DatosUsuario.DatosMiembro.Correo;
                    Console.WriteLine(perfil.Fechafinal);
                    Console.WriteLine(correo);
                    string subject = "Inicio de Membresía";
                    string body = CrearCuerpoCorreoInicio(perfil);
                    emailService.SendEmail(correo, subject, body);
                }
                else if (perfil.Fechafinal > hoy && perfil.Fechafinal <= hoy.AddDays(7))
                {
                    // Notificación de membresía próxima a caducar
                    string correo = perfil.DatosUsuario.CorreoElectronico;
                    string subject = "Membresía Próxima a Caducar";
                    string body = CrearCuerpoCorreoProximoACaducar(perfil);
                    emailService.SendEmail(correo, subject, body);
                }
                else if (perfil.Fechafinal <= hoy)
                {
                    // Notificación de membresía caducada
                    string correo = perfil.DatosUsuario.CorreoElectronico;
                    string subject = "Notificación de Membresía Caducada";
                    string body = CrearCuerpoCorreoCaducado(perfil);
                    emailService.SendEmail(correo, subject, body);
                }
            }

        }

        public string ActualizarBD()
        {
            try
            {
                List<PerfilMembresia> membresias = PmembresiaRepository.ConsultarTodos();
                if (membresias == null)
                {
                    return "No se encontraron membresías para actualizar.";
                }

                DateTime hoy = DateTime.Now;

                foreach (PerfilMembresia perfil in membresias)
                {
                    // Calcular la duración acumulada y el tiempo restante
                    perfil.DuracionAcumulada = CalcularDuracionAcumulada(perfil.Fechainicio, hoy, perfil.TipoMembresia.Duracion);
                    perfil.TiempoRestante = CalcularTiempoRestante(perfil.Fechafinal);

                    // Calcular el saldo debe y el estado
                    perfil.SaldoDebe = CalcularSaldoDebe(perfil);
                    perfil.Estado = DeterminarEstado(perfil); 
                    // Actualizar los datos en la base de datos
                    Console.WriteLine(PmembresiaRepository.ActualizarPMembresiaBD(perfil));
                }
                
                return "Actualización de membresías completada.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la base de datos: " + ex.Message;
            }
        }

        //public void VerificarMembresias(PerfilMembresia perfil)
        //{
        //    List<PerfilMembresia> membresias = PmembresiaRepository.ConsultarTodos();
        //    DateTime hoy = DateTime.Now;

        //    //foreach (PerfilMembresia perfil in membresias)
        //    //{
        //        if (perfil.Fechainicio.Date == hoy.Date)
        //        {
        //            //Notificación de inicio de membresía
        //            string correo = perfil.DatosUsuario.CorreoElectronico;
        //            Console.WriteLine(perfil.DatosUsuario.DatosMiembro.Nombre);
        //            Console.WriteLine(correo);
        //            string subject = "Inicio de Membresía";
        //            string body = CrearCuerpoCorreoInicio(perfil);
        //            emailService.SendEmail(correo, subject, body);
        //        }
        //        else if (perfil.Fechafinal > hoy && perfil.Fechafinal <= hoy.AddDays(7))
        //        {
        //            // Notificación de membresía próxima a caducar
        //            string correo = perfil.DatosUsuario.CorreoElectronico;
        //            string subject = "Membresía Próxima a Caducar";
        //            string body = CrearCuerpoCorreoProximoACaducar(perfil);
        //            emailService.SendEmail(correo, subject, body);
        //        }
        //        else if (perfil.Fechafinal <= hoy)
        //        {
        //            // Notificación de membresía caducada
        //            string correo = perfil.DatosUsuario.CorreoElectronico;
        //            string subject = "Notificación de Membresía Caducada";
        //            string body = CrearCuerpoCorreoCaducado(perfil);
        //            emailService.SendEmail(correo, subject, body);
        //        }
        //    //}
        //}
        private string CrearCuerpoCorreoInicio(PerfilMembresia perfil)
        {
            return $@"
        Estimado/a {perfil.DatosUsuario.DatosMiembro.Nombre},

        Nos complace informarle que su membresía {perfil.TipoMembresia.Nombre} ha comenzado hoy, {perfil.Fechainicio:dd/MM/yyyy}. Su membresía es válida hasta el {perfil.Fechafinal:dd/MM/yyyy}.

        Estamos encantados de tenerle con nosotros y esperamos que disfrute de todos los beneficios y servicios que ofrecemos.

        Si tiene alguna pregunta o necesita asistencia adicional, no dude en ponerse en contacto con nosotros. Estamos aquí para ayudarle.

        Atentamente,
        YIMCLOOD
        yimclood@gmail.com
    ";
        }

        private string CrearCuerpoCorreoProximoACaducar(PerfilMembresia perfil)
        {
            return $@"
        Estimado/a {perfil.DatosUsuario.DatosMiembro.Nombre},

        Nos gustaría informarle que su membresía {perfil.TipoMembresia.Nombre} está próxima a caducar el día {perfil.Fechafinal:dd/MM/yyyy}. Le recomendamos renovarla a tiempo para seguir disfrutando de nuestros servicios sin interrupciones.

        Puede realizar la renovación a través de nuestra página web o visitando nuestra oficina.

        Si tiene alguna pregunta o necesita asistencia adicional, no dude en ponerse en contacto con nosotros.

        Atentamente,
        YIMCLOOD
        yimclood@gmail.com
    ";
        }

        private string CrearCuerpoCorreoCaducado(PerfilMembresia perfil)
        {
            return $@"
        Estimado/a {perfil.DatosUsuario.DatosMiembro.Nombre},

        Nos gustaría informarle que su membresía {perfil.TipoMembresia.Nombre} ha caducado el día {perfil.Fechafinal:dd/MM/yyyy}. Lamentamos que su acceso a los beneficios y servicios proporcionados por nuestra membresía haya llegado a su fin.

        Para continuar disfrutando de nuestros servicios, le invitamos a renovar su membresía a la brevedad posible. Puede realizar la renovación a través de nuestra página web o visitando nuestra oficina.

        Si tiene alguna pregunta o necesita asistencia adicional, no dude en ponerse en contacto con nosotros. Estamos aquí para ayudarle.

        Gracias por su atención y esperamos poder seguir sirviéndole en el futuro.

        Atentamente,
        YIMCLOOD
        yimclood@gmail.com
    ";
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
