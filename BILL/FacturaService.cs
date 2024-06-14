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
        private int numeroFacturaActual = 100000;
        private void GenerarPDF(Factura factura, string filePath)
        {
            string nombre = $"{factura.Miembro.Nombre} {factura.Miembro.Apellido}";
            //string apellido = factura.Miembro.Apellido; AGREGAR A PDF
            string cedula = factura.Miembro.Cedula;
            DateTime fecha = factura.FechaFactura;
            int numeroFactura = factura.Id;
            //AGREGAR LOGO  ARREGLAR COLUMNA PRECIO TOTAL
            string paginahtml_texto = Properties.Resources.plantillaFactura.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", nombre);
            paginahtml_texto = paginahtml_texto.Replace("@DOCUMENTO", cedula);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", fecha.ToString("yyyy-MM-dd"));
            paginahtml_texto = paginahtml_texto.Replace("@NUMEROFAC", numeroFactura.ToString());

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

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(60, 60);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;

                //img.SetAbsolutePosition(10,100);
                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                pdfDoc.Add(img);

                using (StringReader sr = new StringReader(paginahtml_texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }
                pdfDoc.Close();
                stream.Close();
            }
            
        }
        private void GenerarPDFReporte(List<Producto> productos, List<MembresiaAgrupada> agrupadas, string filePath)
        {
            string nombreReporte = "Reporte de Ingresos";
            string documento = "Yimclood";
            DateTime fecha = DateTime.Now;
            int total = 0;
            int numeroReporte = 1; // Puedes cambiar esto si tienes un sistema para generar números de reporte

            // Cargar la plantilla HTML
            string paginahtml_texto = Properties.Resources.codigo.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@NUMEROREPORT", numeroReporte.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL_MEMBRESIAS", agrupadas.Sum(a => a.Valor).ToString("F2"));

            // Generar filas de membresías
            string filasMembresias = string.Empty;
            foreach (var item in agrupadas)
            {
                filasMembresias += "<tr>";
                filasMembresias += "<td>" + item.Membresia + "</td>";
                filasMembresias += "<td>" + item.Cantidad + "</td>";
                filasMembresias += "<td>" + item.Valor.ToString("F2") + "</td>";
                filasMembresias += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS_MEMBRESIAS", filasMembresias);

            // Generar filas de productos y calcular el total
            string filasProductos = string.Empty;
            foreach (var producto in productos)
            {
                int valor = producto.Valor * producto.CantidadDisponible;
                total += valor;
                filasProductos += "<tr>";
                filasProductos += "<td>" + producto.Nombre + "</td>";
                filasProductos += "<td>" + producto.CantidadDisponible + "</td>";
                filasProductos += "<td>" + valor.ToString("F2") + "</td>";
                filasProductos += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS_PRODUCTOS", filasProductos);

            // Reemplazar la variable @TOTAL_PRODUCTOS con el total calculado
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL_PRODUCTOS", total.ToString("F2"));

            // Crear el documento PDF
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                // Agregar logo
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(60, 60);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                pdfDoc.Add(img);

                // Parsear HTML y agregar al PDF
                using (StringReader sr = new StringReader(paginahtml_texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }
        }


        public void GenerarYEnviarPDFReporte(List<Producto> productos,List<MembresiaAgrupada> membresiaAgrupadas, string filePath)
        {
            GenerarPDFReporte(productos,membresiaAgrupadas, filePath);
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
