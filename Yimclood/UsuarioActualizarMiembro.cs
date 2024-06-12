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
            Miembro miembro = ValidadorMiembro();
        }

        private Miembro ValidadorMiembro()
        {
            // Lista de errores
            List<string> errores = new List<string>();

            // Validar cédula
            string cedula = txtCedula.Text;
            if (string.IsNullOrWhiteSpace(cedula) || !cedula.All(char.IsDigit))
            {
                errores.Add("La cédula solo puede contener números y no puede estar vacía.");
                MessageBox.Show("La cédula solo puede contener números y no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }

            // Validar nombre
            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(char.IsLetter))
            {
                errores.Add("El nombre solo puede contener letras y no puede estar vacío.");
                MessageBox.Show("El nombre solo puede contener letras y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }
            else
            {
                nombre = char.ToUpper(nombre[0]) + nombre.Substring(1).ToLower();
            }

            // Validar apellido
            string apellido = txtApellido.Text;
            if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(char.IsLetter))
            {
                errores.Add("El apellido solo puede contener letras y no puede estar vacío.");
                MessageBox.Show("El apellido solo puede contener letras y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }
            else
            {
                apellido = char.ToUpper(apellido[0]) + apellido.Substring(1).ToLower();
            }

            // Validar teléfono
            string telefono = txtTelefono.Text;
            if (string.IsNullOrWhiteSpace(telefono) || !telefono.All(char.IsDigit))
            {
                errores.Add("El teléfono solo puede contener números y no puede estar vacío.");
                MessageBox.Show("El teléfono solo puede contener números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }

            // Validar correo electrónico
            string correo = txtCorreo.Text;
            if (string.IsNullOrWhiteSpace(correo) || !IsValidEmail(correo))
            {
                errores.Add("El correo electrónico no tiene un formato válido o está vacío.");
                MessageBox.Show("El correo electrónico no tiene un formato válido o está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }

            // Validar peso
            string peso = txtPeso.Text;
            if (string.IsNullOrWhiteSpace(peso) || !peso.All(char.IsDigit))
            {
                errores.Add("El peso solo puede contener números y no puede estar vacío.");
                MessageBox.Show("El peso solo puede contener números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }

            // Validar estatura
            string estatura = txtEstatura.Text;
            if (string.IsNullOrWhiteSpace(estatura) || !estatura.All(char.IsDigit))
            {
                errores.Add("La estatura solo puede contener números y no puede estar vacío.");
                MessageBox.Show("La estatura solo puede contener números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Detener la ejecución del método
            }


            // Si no hay errores, crear y retornar el objeto Miembro
            DateTime FechaNacimiento = fechaNacimiento.Value;
            Miembro miembro = new Miembro(
            cedula, nombre, apellido, telefono, Sexo(), correo, FechaNacimiento,
            0, 0, imageBytes);
            MessageBox.Show(miembroService.ActualizarMiembro(miembro,miembroRecibido.Correo));
            DialogResult result = MessageBox.Show("Es necesario volver a iniciar sesión", "Aviso", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Login loginForm = new Login();
                loginForm.Show();
                _usuarioMenuPrincipal.Close();

            }
            return miembro;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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