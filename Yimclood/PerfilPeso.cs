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
    public partial class PerfilPeso : Form
    {
        private System.Windows.Forms.Button currentButton; // Botón actualmente seleccionado
        private System.Windows.Forms.Button lastClickedButton; // Variable para almacenar el último botón clicado
        public PerfilPeso()
        {
            InitializeComponent();                      

            rbtnActual.Enabled = false;
            rbtObjetivo.Enabled = false;
            rbtDiferencia.Enabled = false;
            btnPeso.BackColor = btnPeso.BackColor = Color.OrangeRed;


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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el diálogo para que muestre solo archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";

            // Mostrar el diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Realizar acciones con el archivo seleccionado (por ejemplo, cargar la imagen)
                // Por ejemplo, puedes asignar la ruta del archivo a la propiedad ImageLocation de un control PictureBox:
                fotoPerfil.ImageLocation = filePath;
            }
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

        private void rbtnActual_EnabledChanged(object sender, EventArgs e)
        {
            var radioButton = sender as System.Windows.Forms.RadioButton; // Asegúrate de utilizar System.Windows.Forms.RadioButton
            // Si el radiobutton está desactivado, cambiar el color de fondo
            if (!radioButton.Enabled)
            {
                radioButton.BackColor = radioButton.BackColor = Color.Transparent; // Volver al color predeterminado cuando se activa
                radioButton.ForeColor = radioButton.ForeColor = Color.Black;
            }
            else
            {
                radioButton.BackColor = radioButton.BackColor = Color.Transparent; // Volver al color predeterminado cuando se activa
                radioButton.ForeColor = SystemColors.ControlText;
            }
        }
        private void rbtObjetivo_EnabledChanged(object sender, EventArgs e)
        {
            var radioButton = sender as System.Windows.Forms.RadioButton; // Asegúrate de utilizar System.Windows.Forms.RadioButton
            // Si el radiobutton está desactivado, cambiar el color de fondo
            if (!radioButton.Enabled)
            {
                radioButton.BackColor = radioButton.BackColor = Color.Transparent; // Volver al color predeterminado cuando se activa
                radioButton.ForeColor = radioButton.ForeColor = Color.Black;
            }
            else
            {
                radioButton.BackColor = radioButton.BackColor = Color.Transparent; // Volver al color predeterminado cuando se activa
                radioButton.ForeColor = SystemColors.ControlText;
            }
        }
        private void rbtDiferencia_EnabledChanged(object sender, EventArgs e)
        {
            var radioButton = sender as System.Windows.Forms.RadioButton; // Asegúrate de utilizar System.Windows.Forms.RadioButton
            // Si el radiobutton está desactivado, cambiar el color de fondo
            if (!radioButton.Enabled)
            {
                radioButton.BackColor = radioButton.BackColor = Color.Transparent; // Volver al color predeterminado cuando se activa
                radioButton.ForeColor = radioButton.ForeColor = Color.Black;
            }
            else
            {
                radioButton.BackColor = radioButton.BackColor = Color.Transparent; // Volver al color predeterminado cuando se activa
                radioButton.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
         
        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {
            MostrarMedidas formPerfilMedidas = new MostrarMedidas();
            this.Hide();
            formPerfilMedidas.ShowDialog();
            this.Close();
        }

        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            // Restaurar el color de fondo del último botón clicado
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DeepSkyBlue;
            }

            // Cambiar el color de fondo del botón clicado
            clickedButton.BackColor = Color.OrangeRed;

            // Actualizar el último botón clicado
            lastClickedButton = clickedButton;
        }
        
    }
}