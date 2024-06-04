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
    public partial class AgregarEjercicios : Form
    {
        public AgregarEjercicios()
        {
            InitializeComponent();
            CargarEjercicios();
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
        private void btnRutinaExistente_MouseEnter(object sender, EventArgs e)
        {
            btnRutinaExistente.BackColor = Color.LightGreen;
        }

        private void btnRutinaExistente_MouseLeave(object sender, EventArgs e)
        {
            btnRutinaExistente.BackColor = Color.White;
        }

        private void btnNuevaRutina_MouseEnter(object sender, EventArgs e)
        {
            btnNuevaRutina.BackColor = Color.LightGreen;
        }

        private void btnNuevaRutina_MouseLeave(object sender, EventArgs e)
        {
            btnNuevaRutina.BackColor = Color.White;
        }

        private void btnNuevaRutina_Click(object sender, EventArgs e)
        {
            Rutinas formRutinas = new Rutinas();
            this.Hide();
            formRutinas.ShowDialog();
            this.Close();
        }

        private void btnRutinaExistente_Click(object sender, EventArgs e)
        {
            Rutinas formRutinas = new Rutinas();
            this.Hide();
            formRutinas.ShowDialog();
            this.Close();
        }
        private void CargarEjercicios()
        {

            EjercicioService ejercicioService = new EjercicioService();
            List<Ejercicio> ejercicios = ejercicioService.ConsultarEjercicioMusculo("Hombros");
            listaEjercicios.DataSource = ejercicios;
            if (ejercicios != null && ejercicios.Count > 0)
            {

                // Asignar la lista de ejercicios al DataGridView
                listaEjercicios.DataSource = ejercicios;
                // Refrescar el DataGridView para que muestre los datos
                listaEjercicios.Refresh();
                MessageBox.Show("Si se encontraron ejercicios.");

            }
            else
            {
                MessageBox.Show("No se encontraron ejercicios.");
            }
        }
    }
}
