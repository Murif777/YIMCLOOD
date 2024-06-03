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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Presentacion
{
    public partial class AgregarMedidas : Form
    {
        private System.Windows.Forms.Button currentButton; // Botón actualmente seleccionado
        private System.Windows.Forms.Button lastClickedButton; // Variable para almacenar el último botón clicado
        public AgregarMedidas()
        {
            InitializeComponent();                      
         }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PerfilPeso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            Ejercicios formEjercicios = new Ejercicios();
            this.Hide();
            formEjercicios.ShowDialog();
            this.Close();
        }
        private void btnRutinas_Click(object sender, EventArgs e)
        {
            MetodoRutina formMetodoRutina = new MetodoRutina();
            this.Hide();
            formMetodoRutina.ShowDialog();
            this.Close();
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }        
    }
}