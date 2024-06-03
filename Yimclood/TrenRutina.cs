using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using BILL;
using ENTITY;

namespace Presentacion
{
    public partial class MetodoRutina : Form
    {
        public MetodoRutina()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormInterfaz_Load(object sender, EventArgs e)
        {
            
        }

        private void FormInterfaz_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlGimnasio_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel panel = sender as System.Windows.Forms.Panel;
            if (panel != null)
            {
                int borderRadius = 20; // Radio de las esquinas redondeadas
                int borderWidth = 3;   // Grosor del borde
                Color borderColor = Color.DarkBlue; // Color del borde

                // Crear la ruta de la figura con esquinas redondeadas
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                // Establecer la región del panel a la ruta
                panel.Region = new Region(path);

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void pnlHogar_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel panel = sender as System.Windows.Forms.Panel;
            if (panel != null)
            {
                int borderRadius = 20; // Radio de las esquinas redondeadas
                int borderWidth = 3;   // Grosor del borde
                Color borderColor = Color.DarkBlue; // Color del borde

                // Crear la ruta de la figura con esquinas redondeadas
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                // Establecer la región del panel a la ruta
                panel.Region = new Region(path);

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void btnPlanGym_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            int cornerRadius = 15; // Ajusta este valor según el redondeo deseado
            int borderWidth = 3; // Ajusta este valor según el grosor del borde deseado
            Color borderColor = Color.DarkBlue; // Cambia este valor al color deseado

            buttonPath.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            buttonPath.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            buttonPath.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            buttonPath.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            buttonPath.CloseAllFigures();

            button.Region = new System.Drawing.Region(buttonPath);

            // Dibuja el borde del botón
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawPath(borderPen, buttonPath);
            }
        }

        private void btnHogar_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            int cornerRadius = 15; // Ajusta este valor según el redondeo deseado
            int borderWidth = 3; // Ajusta este valor según el grosor del borde deseado
            Color borderColor = Color.DarkBlue; // Cambia este valor al color deseado

            buttonPath.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            buttonPath.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            buttonPath.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            buttonPath.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            buttonPath.CloseAllFigures();

            button.Region = new System.Drawing.Region(buttonPath);

            // Dibuja el borde del botón
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawPath(borderPen, buttonPath);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            MetodoRutina formEjercicios = new MetodoRutina();
            this.Hide();
            formEjercicios.ShowDialog();
            this.Close();
        }
        private void btnRutinas_Click(object sender, EventArgs e)
        {

        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
           // FormHistorial formHistorial = new FormHistorial();
            this.Hide(); // Oculta el formulario actual
            //formHistorial.ShowDialog(); // Abre el nuevo formulario de manera modal
            this.Close(); // Cierra el formulario actual después de que se cierra el formulario nuevo
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
