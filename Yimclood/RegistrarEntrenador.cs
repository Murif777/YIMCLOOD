using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public event EventHandler OnRegresar;
        public RegistrarEntrenador()
        {
            InitializeComponent();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            btnsubirfoto.Click += new EventHandler(btnsubirfoto_Click);
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
            DateTime FechaNacimiento = fechaNacimiento.Value;
            Entrenador entrenador = new Entrenador(
                                                    cedula, nombre, apellido, telefono, sexo,
                                                    correo, FechaNacimiento, null
                                                   );
            MessageBox.Show(entrenadorService.Registrar(entrenador));
            registrarUsuario(entrenador);
        }
        private void registrarUsuario(Entrenador entrenador)
        {
            Usuario usuario = new Usuario(entrenador);
            MessageBox.Show(usuarioService.Registrar(usuario));
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
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void btnsubirfoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string filePath = openFileDialog.FileName;

                    // Mostrar la imagen en un PictureBox o realizar cualquier acción con la ruta del archivo
                    MessageBox.Show("Imagen seleccionada: " + filePath);
                }
            }
        }
    }
}
