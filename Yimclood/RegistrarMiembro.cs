using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using BILL;
using ENTITY;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Presentacion
{
    public partial class Registrar : Form
    {
        private MiembroService miembroService = new MiembroService();
        private UsuarioService usuarioService = new UsuarioService();
        private MembresiaService membresiaService = new MembresiaService();
        private PMembresiaService PMembresiaService = new PMembresiaService();
        private byte[] imageBytes;
        private PerfilMembresia MiembroRecibido;
        public event EventHandler OnRegresar;

        public Registrar(PerfilMembresia miembro)
        {
            PMembresiaService.VerificarMembresias();
            InitializeComponent();
            btnActualizar.Visible = false;
            ComboboxMembresias();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            //btnagregarfoto.Click += btnagregarfoto_Click_1;
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            InitializeDateTimePicker();
            MiembroRecibido = miembro;
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            registrarMiembro();
            Limpiar_Campos();
        }

        private void registrarMiembro()
        {
            Miembro miembro = ValidadorMiembro();

            Membresia membresiaSeleccionada = ObtenerMembresia();
            if (membresiaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una membresia");
                return;
            }
            if (miembro != null)
            {
                Usuario usuario = new Usuario(miembro);
                try
                {
                    string resultadoMiembro = miembroService.Registrar(miembro);
                    string resultadoUsuario = usuarioService.Registrar(usuario);
                    string resultadoMembresia = RegistrarMembresia(membresiaSeleccionada, usuario);

                    if (resultadoMiembro.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        resultadoUsuario.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        resultadoMembresia.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        MessageBox.Show("Miembro no guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Miembro guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar_Campos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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

            // Si no hay errores, crear y retornar el objeto Miembro
            DateTime FechaNacimiento = fechaNacimiento.Value;
            Miembro miembro = new Miembro(
                cedula, nombre, apellido, telefono, Sexo(), correo, FechaNacimiento,
                0, 0, imageBytes);

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

        private void ActualizarMiembroBD()
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string sexo = Sexo();
            string correo = txtCorreo.Text;
            DateTime FechaNacimiento = fechaNacimiento.Value;
            Membresia membresiaSeleccionada = ObtenerMembresia();
            Miembro miembro = new Miembro(
                cedula, nombre, apellido, telefono, sexo, correo, FechaNacimiento,
                0, 0, imageBytes);
            MessageBox.Show(miembroService.ActualizarMiembro(miembro));
        }
        private string RegistrarMembresia(Membresia membresia,Usuario usuario)
        {
            if (usuario != null)
            {
                PerfilMembresia perfil = new PerfilMembresia();
                perfil.DatosUsuario = usuario;
                perfil.TipoMembresia = membresia;
                perfil.Pagado = true;
                PMembresiaService PmembresiaService = new PMembresiaService();
                //MessageBox.Show(PmembresiaService.Registrar(perfil));
                return PmembresiaService.Registrar(perfil);
            }
            else
            {
                MessageBox.Show("usuario vacio");
            }
            return null;
        }
        private Membresia ObtenerMembresia()
        {
            List<Membresia> listaMembresias = MembresiaService.ConsultarTodo();

            if (listaMembresias != null && listaMembresias.Count > 0 && TiposMembresia.SelectedItem != null)
            {
                string nombreSeleccionado = TiposMembresia.SelectedItem.ToString();

                Membresia MembresiaSeleccionada = listaMembresias
                    .FirstOrDefault(m => m.Nombre.Equals(nombreSeleccionado, StringComparison.OrdinalIgnoreCase));

                return MembresiaSeleccionada;
            }

            return null;
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
        private void Limpiar_Campos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            rdbtnHombre.Checked = false;
            rdbtnMujer.Checked = false;
            imageBytes = null; 
        }
        private void ComboboxMembresias()
        {
            List<Membresia> membresias = MembresiaService.ConsultarTodo();
            if (membresias == null)
            {
                MessageBox.Show("Lista vacia");
            }
            else
            {
                membresias.Insert(0, new Membresia { Nombre = "Ninguno" });
                TiposMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
                TiposMembresia.DataSource = membresias;
                TiposMembresia.DisplayMember = "Nombre";
            }
        }
        public void Asignar_Campos()
        {
            txtCedula.Text = MiembroRecibido.DatosUsuario.DatosMiembro.Cedula;
            txtCedula.Enabled = false;
            txtNombre.Text= MiembroRecibido.DatosUsuario.DatosMiembro.Nombre;
            txtApellido.Text= MiembroRecibido.DatosUsuario.DatosMiembro.Apellido;
            txtTelefono.Text = MiembroRecibido.DatosUsuario.DatosMiembro.Telefono;
            txtCorreo.Text= MiembroRecibido.DatosUsuario.DatosMiembro.Correo;
            imageBytes = MiembroRecibido.DatosUsuario.DatosMiembro.Foto;
            if (MiembroRecibido.DatosUsuario.DatosMiembro.Sexo == "Hombre")
            {
                rdbtnHombre.Checked=true;
            }
            else
            {
                rdbtnMujer.Checked = true;
            }
            fechaNacimiento.Value = MiembroRecibido.DatosUsuario.DatosMiembro.FechaNacimiento;
            if (MiembroRecibido.TipoMembresia.Nombre == "NORMAL")
            {
                TiposMembresia.SelectedIndex = 2;
            }
            if (MiembroRecibido.TipoMembresia.Nombre == "VIP")
            {
                TiposMembresia.SelectedIndex = 3;
            }
            if (MiembroRecibido.TipoMembresia.Nombre == "ENTRENADOR")
            {
                TiposMembresia.SelectedIndex = 1;
            }
            if (MiembroRecibido.Fechafinal<= DateTime.Now)
            {
                TiposMembresia.Enabled = false;
            }
            byte[]foto=MiembroRecibido.DatosUsuario.DatosMiembro.Foto;
            if (foto != null)
            {
                Image image = Image.FromStream(new MemoryStream(foto));

                int nuevoAncho = 175;
                int nuevoAlto = 175;
                Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

                pbFoto.Image = imagenRedimensionada;
            }
            else
            {
                pbFoto.Image = null;
            }
        }
        private void InitializeDateTimePicker()
        {
            fechaNacimiento.Format = DateTimePickerFormat.Custom;
            fechaNacimiento.CustomFormat = " ";
            fechaNacimiento.ShowCheckBox = true;
            fechaNacimiento.Checked = false;
            fechaNacimiento.ValueChanged += new EventHandler(fechaNacimiento_ValueChanged);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMiembroBD();

        }
        private void fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (fechaNacimiento.Checked)
            {
                fechaNacimiento.Format = DateTimePickerFormat.Short;
            }
            else
            {
                fechaNacimiento.Format = DateTimePickerFormat.Custom;
                fechaNacimiento.CustomFormat = " ";
            }
        }
        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
        private void btnagregarfoto_Click(object sender, EventArgs e)
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
            byte[] foto =imageBytes;
            if (foto != null)
            {
                Image image = Image.FromStream(new MemoryStream(foto));

                int nuevoAncho = 175;
                int nuevoAlto = 175;
                Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

                pbFoto.Image = imagenRedimensionada;
            }
            else
            {
                pbFoto.Image = null;
            }
        }

       
    }
}
