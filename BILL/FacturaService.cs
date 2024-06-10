using DAL;
using ENTITY;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Data;


namespace BILL
{
    public class FacturaService:ICrud<Factura>
    {
        private EmailService emailService= new EmailService();
        private FacturaRepository f_repository = new FacturaRepository();
        public string Registrar(Factura factura)
        {
            try
            {
                return f_repository.GuardarFacturaBD(factura);
            }
            catch (Exception ex)
            {
                return "Error al registrar: " + ex.Message;
            }
        }
        public string RegistrarFacturaProducto(Factura factura)
        {
            try
            {

                return f_repository.GuardarFacturaBD(factura);
            }
            catch (Exception ex)
            {
                return "Error al registrar la factura: " + ex.Message;
            }
        }
        public List<Factura> ConsultarTodo()
        {
            try
            {
                return f_repository.ConsultarTodo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar las factura: " + ex.Message);
                return null;
            }
        }
        public List<Factura> ConsultarCed(string cedula)
        {
            try
            {
                return f_repository.ConsultarCed(cedula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar las factura: " + ex.Message);
                return null;
            }
        }

        private void GenerarPDF(Factura factura, string filePath)
        {
            string nombre = factura.Miembro.Nombre;
            //string apellido = factura.Miembro.Apellido; AGREGAR A PDF
            string cedula = factura.Miembro.Cedula;
            DateTime fecha = factura.FechaFactura;
           // int id =factura.Id; AGREGAR A PDF
           //AGREGAR LOGO  ARREGLAR COLUMNA PRECIO TOTAL
            string paginahtml_texto = Properties.Resources.plantillaFactura.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", nombre);
            paginahtml_texto = paginahtml_texto.Replace("@DOCUMENTO", cedula);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", fecha.ToString("yyyy-MM-dd"));

            string filas = string.Empty;
            foreach (var row in factura.Productos)
            {
                filas += "<tr>";
                filas += "<td>" + row.Referencia + "</td>";
                filas += "<td>" + row.Nombre + "</td>";
                filas += "<td>" + row.CantidadDisponible + " </td>";
                filas += "<td>" + row.Valor + "</td>";
                filas += "</tr>";
            }
            double total = factura.Precio_Total;

            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", total.ToString());

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                using (StringReader sr = new StringReader(paginahtml_texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }
        }

        public void GenerarYEnviarPDF(Factura factura, string filePath)
        {
            GenerarPDF(factura, filePath);
            string subject = "Factura de Compra";
            string body = "Adjunto se encuentra su factura de compra.";
            string emailDestino = factura.Miembro.Correo;
            emailService.SendEmail(emailDestino, subject, body, filePath);
            Console.WriteLine("Se envio correctamente");
        }
    }

}
