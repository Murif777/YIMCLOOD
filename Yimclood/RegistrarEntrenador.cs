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

        public event EventHandler OnRegresar;
        private byte[] imageBytes;
        public RegistrarEntrenador()
        {
            InitializeComponent();
            ComboboxMembresias();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            this.btnsubirfoto.Click += new EventHandler(this.btnsubirfoto_Click);
            InitializeDateTimePicker();
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrarEntrenador();
            Limpiar_Campos();
        }
        private void registrarEntrenador()
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
            MessageBox.Show(entrenadorService.Registrar(entrenador));
            RegistrarMembresia(membresiaSeleccionada ,registrarUsuario(entrenador));
        }
        private Usuario registrarUsuario(Entrenador entrenador)
        {
            Usuario usuario = new Usuario(entrenador);
            MessageBox.Show(usuarioService.Registrar(usuario));
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
                MessageBox.Show(PmembresiaService.Registrar(perfil));
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
        }
    }
}
