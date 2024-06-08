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
    public partial class Ejercicios : Form
    {
        public Ejercicios()
        {
            InitializeComponent();
            btnEjercicios.Enabled = false; // Reactivar el botón cuando Ejercicios se cierre
            btnEjercicios.FlatAppearance.BorderSize = 1; // Restaurar borde
            btnEjercicios.FlatStyle = FlatStyle.Standard;
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

        private void musculos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHombros_MouseEnter(object sender, EventArgs e)
        {
            btnHombros.BackColor = Color.Red;
            musculos.Image = Properties.Resources.hombrosF; 

        }

        private void btnHombros_MouseLeave(object sender, EventArgs e)
        {
            btnHombros.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnPecho_MouseEnter(object sender, EventArgs e)
        {
            btnPecho.BackColor = Color.Red;
            musculos.Image = Properties.Resources.pechoF;
        }

        private void btnPecho_MouseLeave(object sender, EventArgs e)
        {
            btnPecho.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;

        }

        private void btnBiceps_MouseEnter(object sender, EventArgs e)
        {
            btnBiceps.BackColor = Color.Red;
            musculos.Image = Properties.Resources.bicepsF;
        }

        private void btnBiceps_MouseLeave(object sender, EventArgs e)
        {
            btnBiceps.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

           private void btnAbdominales_MouseEnter(object sender, EventArgs e)
        {
            btnAbdominales.BackColor = Color.Red;
            musculos.Image = Properties.Resources.abdominalesF;
        }

        private void btnAbdominales_MouseLeave(object sender, EventArgs e)
        {
            btnAbdominales.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnPiernas_MouseEnter(object sender, EventArgs e)
        {
            btnPiernas.BackColor = Color.Red;
            musculos.Image = Properties.Resources.piernasF;
        }

        private void btnPiernas_MouseLeave(object sender, EventArgs e)
        {
            btnPiernas.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnEspalda_MouseEnter(object sender, EventArgs e)
        {
            btnEspalda.BackColor = Color.Red;
            musculos.Image = Properties.Resources.espaldaF;
        }

        private void btnEspalda_MouseLeave(object sender, EventArgs e)
        {
            btnEspalda.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;            
        }

        private void btnTriceps_MouseEnter(object sender, EventArgs e)
        {
            btnTriceps.BackColor = Color.Red;
            musculos.Image = Properties.Resources.tricepsF;
        }

        private void btnTriceps_MouseLeave(object sender, EventArgs e)
        {
            btnTriceps.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnAntebrazos_MouseEnter(object sender, EventArgs e)
        {
            btnAntebrazos.BackColor = Color.Red;
            musculos.Image = Properties.Resources.antebrazosF;
        }

        private void btnAntebrazos_MouseLeave(object sender, EventArgs e)
        {
            btnAntebrazos.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnGluteos_MouseEnter(object sender, EventArgs e)
        {
            btnGluteos.BackColor = Color.Red;
            musculos.Image = Properties.Resources.gluteosF;
        }

        private void btnGluteos_MouseLeave(object sender, EventArgs e)
        {
            btnGluteos.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnPantorrillas_MouseEnter(object sender, EventArgs e)
        {
            btnPantorrillas.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.pantorrillasF;
        }

        private void btnPantorrillas_MouseLeave(object sender, EventArgs e)
        {
            btnPantorrillas.BackColor = SystemColors.Control;
            musculos.Image = Properties.Resources.Musculos;
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
        
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
            PerfilPeso formPerfil = new PerfilPeso();
            this.Hide();
            formPerfil.ShowDialog();
            this.Close();
        }

        private void btnHombros_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnPecho_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnBiceps_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnAbdominales_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnPiernas_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnEspalda_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnTriceps_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnAntebrazos_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnGluteos_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void btnPantorrillas_Click(object sender, EventArgs e)
        {
            AgregarEjercicio formAgregarEjercicios = new AgregarEjercicio();
            this.Hide();
            formAgregarEjercicios.ShowDialog();
            this.Close();
        }

        private void musculos_Click(object sender, EventArgs e)
        {

        }
    }
}
