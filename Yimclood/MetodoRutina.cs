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
            btnRutinas.Enabled = false; // Reactivar el botón cuando Ejercicios se cierre
            btnRutinas.FlatAppearance.BorderSize = 1; // Restaurar borde
            btnRutinas.FlatStyle = FlatStyle.Standard;
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
        private void btnGym_MouseEnter(object sender, EventArgs e)
        {
            btnGym.BackColor = Color.LightBlue;
        }
        private void btnGym_MouseLeave(object sender, EventArgs e)
        {
            btnGym.BackColor = SystemColors.Control; // O el color original que desees
        }
        private void btnHogar_MouseEnter(object sender, EventArgs e)
        {
            btnHogar.BackColor = Color.LightBlue;
        }
        private void btnHogar_MouseLeave(object sender, EventArgs e)
        {
            btnHogar.BackColor = SystemColors.Control; // O el color original que desees
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
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGym_Click(object sender, EventArgs e)
        {
            Rutinas formRutinas = new Rutinas();
            this.Hide();
            formRutinas.ShowDialog();
            this.Close();
        }
        private void btnHogar_Click(object sender, EventArgs e)
        {
            Rutinas formRutinas = new Rutinas();
            this.Hide();
            formRutinas.ShowDialog();
            this.Close();
        }
        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            Ejercicios formEjercicios = new Ejercicios();
            this.Hide();
            formEjercicios.ShowDialog();
            this.Close();
        }
        private void btnRutinas_Click(object sender, EventArgs e)
        {

        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
          
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            PerfilPeso formPerfil = new PerfilPeso();
            this.Hide();
            formPerfil.ShowDialog();
            this.Close();
        }

      
    }
}
