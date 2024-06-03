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
    public partial class Rutinas : Form
    {
        public Rutinas()
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
              
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            AgregarEjercicios formAgregarEjercicios = new AgregarEjercicios();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }
        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            Ejercicios formEjercicios = new Ejercicios();
            this.Hide();
            formEjercicios.ShowDialog();
            this.Close();
        }
    }
}
