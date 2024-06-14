using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistrarEntrenador : Form
    {
     private EntrenadorService entrenadorService = new EntrenadorService();
     private UsuarioService usuarioService = new UsuarioService();
     private MembresiaService MembresiaService = new MembresiaService();
        private Entrenador newentrenador;

        public event EventHandler OnRegresar;
        private byte[] imageBytes;
        private string resultadousuario;
        private string resultadoentrenador;
        private string resultadomem;
        public RegistrarEntrenador(Entrenador entrenador)
        {
            InitializeComponent();
            ComboboxMembresias();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            //this.btnsubirfoto.Click += new EventHandler(this.btnsubirfoto_Click);
            InitializeDateTimePicker();
            newentrenador = entrenador;
            btnActualizar.Visible = false;
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (registrarEntrenador())
            {
                Limpiar_Campos();
            }
        }
        private bool registrarEntrenador()
        {
            // Obtén los valores de los campos de texto
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string sexo = Sexo();
            string correo = txtCorreo.Text.Trim();
            Membresia membresiaSeleccionada = ObtenerMembresia();
            DateTime FechaNacimiento = fechaNacimiento.Value;

            // Validaciones
            if (!ValidarCamposEntrenador(cedula, nombre, apellido, telefono))
            {
                return false;
            }

            // Crear el entrenador y registrarlo
            Entrenador entrenador = new Entrenador(
                cedula, nombre, apellido, telefono, sexo,
                correo, FechaNacimiento, imageBytes
            );

             resultadoentrenador =entrenadorService.Registrar(entrenador);

            RegistrarMembresia(membresiaSeleccionada, registrarUsuario(entrenador));

            if (resultadoentrenador.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0 ||
                resultadousuario.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0 ||
                resultadomem.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                MessageBox.Show("Entrenador no guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Entrenador guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_Campos();
            }
            return true;
        }

        private bool ValidarCamposEntrenador(string cedula, string nombre, string apellido, string telefono)
        {
            if (!EsCedulaValida(cedula))
            {
                MostrarMensajeError("La cédula debe contener solo números y no puede estar vacía.");
                return false;
            }

            if (!EsNombreValido(nombre))
            {
                MostrarMensajeError("El nombre debe contener solo letras y no puede estar vacío.");
                return false;
            }

            if (!EsApellidoValido(apellido))
            {
                MostrarMensajeError("El apellido debe contener solo letras y no puede estar vacío.");
                return false;
            }

            if (!EsTelefonoValido(telefono))
            {
                MostrarMensajeError("El teléfono debe contener solo números y no puede estar vacío.");
                return false;
            }

            return true;
        }

        private bool EsCedulaValida(string cedula)
        {
            return !string.IsNullOrWhiteSpace(cedula) && cedula.All(char.IsDigit);
        }

        private bool EsNombreValido(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre) && nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsApellidoValido(string apellido)
        {
            return !string.IsNullOrWhiteSpace(apellido) && apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsTelefonoValido(string telefono)
        {
            return !string.IsNullOrWhiteSpace(telefono) && telefono.All(char.IsDigit);
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de validación");
        }

        private void actualizarentrenadoBD()
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string sexo = Sexo();
            string correo = txtCorreo.Text;
            Membresia membresiaSeleccionada = ObtenerMembresia();
            DateTime FechaNacimiento = fechaNacimiento.Value;
            Entrenador entrenador = new Entrenador(
                                                    cedula, nombre, apellido, telefono, sexo,
                                                    correo, FechaNacimiento, imageBytes
                                                   );
            MessageBox.Show(entrenadorService.ActualizarEntrenador(entrenador));

            //RegistrarMembresia(membresiaSeleccionada, registrarUsuario(entrenador));
        }
        private Usuario registrarUsuario(Entrenador entrenador)
        {
            Usuario usuario = new Usuario(entrenador);
          resultadousuario = usuarioService.Registrar(usuario);
            return usuario;
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

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
        private void RegistrarMembresia(Membresia membresia, Usuario usuario)
        {

            if (usuario != null)
            {
                PerfilMembresia perfil = new PerfilMembresia();
                perfil.DatosUsuario = usuario;
                perfil.TipoMembresia = membresia;
                perfil.Pagado = true;
                PMembresiaService PmembresiaService = new PMembresiaService();
                resultadomem= PmembresiaService.Registrar(perfil);
                //PmembresiaService.VerificarMembresias(perfil);
            }
            else
            {
                MessageBox.Show("usuario vacio");
            }
        }
        private Membresia ObtenerMembresia()
        {
            MembresiaService membresiaService = new MembresiaService();
            List<Membresia> listaMembresias = membresiaService.ConsultarTodo();

            if (listaMembresias != null && listaMembresias.Count > 0 && TiposMembresia.SelectedItem != null)
            {
                string nombreSeleccionado = TiposMembresia.SelectedItem.ToString();

                Membresia MembresiaSeleccionada = listaMembresias
                    .FirstOrDefault(m => m.Nombre.Equals(nombreSeleccionado, StringComparison.OrdinalIgnoreCase));

                return MembresiaSeleccionada;
            }

            return null;
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

        private void InitializeDateTimePicker()
        {
            fechaNacimiento.Format = DateTimePickerFormat.Custom;
            fechaNacimiento.CustomFormat = " ";
            fechaNacimiento.ShowCheckBox = true;
            fechaNacimiento.Checked = false;
            fechaNacimiento.ValueChanged += new EventHandler(fechaNacimiento_ValueChanged);
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

        private void btnsubirfoto_Click(object sender, EventArgs e)
        {

        }

        private void btnsubirfoto_Click_1(object sender, EventArgs e)
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
        //public void AsignarCampos(Entrenador entrenador)
        //{
            
        //}

        public void AsignarCampos()
        {
            if ( newentrenador != null)
            {
                txtCedula.Text = newentrenador.Cedula;
                txtCedula.Enabled = false;  
                txtNombre.Text = newentrenador.Nombre;
                txtApellido.Text = newentrenador.Apellido;
                txtTelefono.Text = newentrenador.Telefono;
                txtCorreo.Text = newentrenador.Correo;
                imageBytes = newentrenador.Foto;
                if (newentrenador.Sexo == "Hombre")
                {
                    rdbtnHombre.Checked = true;
                }
                else
                {
                    rdbtnMujer.Checked = true;
                }
                fechaNacimiento.Value = newentrenador.FechaNacimiento;
                TiposMembresia.Enabled = false;
                // Asignar la foto si existe
                byte[] foto = newentrenador.Foto;
                if (foto != null)
                {
                    Image image = Image.FromStream(new MemoryStream(foto));
                    pbFoto.Image = image;
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarentrenadoBD();
            
        }
    }
}
