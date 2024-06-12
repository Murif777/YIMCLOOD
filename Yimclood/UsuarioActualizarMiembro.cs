using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Controls.Primitives;
using System.Drawing.Text;
using ENTITY;
using BILL;
using System.IO;



namespace Presentacion
{
    public partial class UsuarioActualizarMiembro : Form
    {
        private Miembro miembroRecibido;
        private byte[] imageBytes;
        private MiembroService miembroService = new MiembroService();
        private UsuarioMenuPrincipal _usuarioMenuPrincipal;
        public UsuarioActualizarMiembro(UsuarioMenuPrincipal usuarioMenuPrincipal,Miembro miembro)
        {
            InitializeComponent();
            miembroRecibido = miembro;
            Asignar_Campos();
            _usuarioMenuPrincipal = usuarioMenuPrincipal;
        }

        private void ActualizarMiembroBD()
        {
            string cedula = txtCedula.Text;
            txtCedula.Enabled = false;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string sexo = Sexo();
            string correo = txtCorreo.Text;
            int peso = int.Parse(txtPeso.Text);
            int estatura = int.Parse(txtEstatura.Text);
            DateTime FechaNacimiento = fechaNacimiento.Value;
            Miembro miembro = new Miembro(
                cedula, nombre, apellido, telefono, sexo, correo, FechaNacimiento,
                peso, estatura, imageBytes);
            MessageBox.Show(miembroService.ActualizarMiembro(miembro,miembroRecibido.Correo));
            DialogResult result = MessageBox.Show("Es necesario volver a iniciar sesión", "Aviso", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Login loginForm = new Login();
                loginForm.Show();
                _usuarioMenuPrincipal.Close();

            }
        }
        public void Asignar_Campos()
        {
            txtCedula.Text = miembroRecibido.Cedula;
            txtCedula.Enabled = false;
            txtNombre.Text = miembroRecibido.Nombre;
            txtApellido.Text = miembroRecibido.Apellido;
            txtTelefono.Text = miembroRecibido.Telefono;
            txtCorreo.Text = miembroRecibido.Correo;
            txtPeso.Text=miembroRecibido.Peso.ToString(); 
            txtEstatura.Text= miembroRecibido.Estatura.ToString();
            if (miembroRecibido.Sexo == "Hombre")
            {
                rdbtnHombre.Checked = true;
            }
            else
            {
                rdbtnMujer.Checked = true;
            }
            fechaNacimiento.Value = miembroRecibido.FechaNacimiento;
            byte[] foto = miembroRecibido.Foto;
            if (foto != null)
            {
                Image image = Image.FromStream(new MemoryStream(foto));

                int nuevoAncho = 309;
                int nuevoAlto = 251;
                Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

                pbFoto.Image = imagenRedimensionada;
            }
            else
            {
                pbFoto.Image = null;
            }
        }
        private string Sexo()
        {
            if (rdbtnHombre.Checked)
            {
                return "Hombre";
            }
            if (rdbtnMujer.Checked)
            {
                return "Mujer";
            }
            return null;
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Asegúrate de que este diálogo solo se muestre una vez
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string filePath = openFileDialog.FileName;
                    imageBytes = File.ReadAllBytes(filePath);
                    MessageBox.Show("Imagen seleccionada: " + filePath);
                }
            }
            byte[] foto = imageBytes;
            if (foto != null)
            {
                Image image = Image.FromStream(new MemoryStream(foto));

                int nuevoAncho = 309;
                int nuevoAlto = 251;
                Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

                pbFoto.Image = imagenRedimensionada;
            }
            else
            {
                pbFoto.Image = null;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarMiembroBD();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


    }
}