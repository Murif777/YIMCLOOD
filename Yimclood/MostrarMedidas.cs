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
    public partial class MostrarMedidas : Form
    {
        private System.Windows.Forms.Button currentButton; // Botón actualmente seleccionado
        public MostrarMedidas()
        {
            InitializeComponent();

            btnPerfil.Enabled = false; // Reactivar el botón cuando Ejercicios se cierre
            btnPerfil.FlatAppearance.BorderSize = 1; // Restaurar borde
            btnPerfil.FlatStyle = FlatStyle.Standard;
            btnMedidas.BackColor = btnMedidas.BackColor=Color.OrangeRed;
            btnPeso.BackColor=btnPeso.BackColor=Color.DeepSkyBlue;

        

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
        private void btnSubir_MouseEnter(object sender, EventArgs e)
        {
            btnSubir.BackColor = Color.DeepSkyBlue;
        }

        private void btnSubir_MouseLeave(object sender, EventArgs e)
        {
            btnSubir.BackColor = Color.Transparent;
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {

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



        private void btnPeso_Click(object sender, EventArgs e)
        {
            PerfilPeso formPerfilPeso = new PerfilPeso();
            this.Hide();
            formPerfilPeso.ShowDialog();
            this.Close();
        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            System.Windows.Forms.Button btnSubir = this.Controls["btnSubir"] as System.Windows.Forms.Button;

            // Restablecer el color de fondo de todos los botones, excepto el botón clicado y btnSubir
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Button button && button != clickedButton && button != btnSubir)
                {
                    button.BackColor = Color.DeepSkyBlue;
                }
            }

            // Cambiar el color de fondo del botón clicado
            clickedButton.BackColor = Color.OrangeRed;

            // Actualizar el botón actualmente seleccionado
            currentButton = clickedButton;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarMedidas formAgregarMedidas = new AgregarMedidas();
            this.Hide();
            formAgregarMedidas.ShowDialog();
            this.Close();
        }
    }
}