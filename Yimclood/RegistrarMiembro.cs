using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using BILL;
using ENTITY;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Presentacion
{
    public partial class Registrar : Form
    {
        private MiembroService miembroService = new MiembroService();
        private UsuarioService usuarioService = new UsuarioService();
        private MembresiaService MembresiaService = new MembresiaService();
        private byte[] imageBytes;

        public event EventHandler OnRegresar;

        public Registrar()
        {
            InitializeComponent();
            ComboboxMembresias();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            btnagregarfoto.Click += btnagregarfoto_Click;
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            registrarMiembro();
            //Limpiar_Campos();
        }

        private void registrarMiembro()
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

            MessageBox.Show(miembroService.Registrar(miembro));
            RegistrarMembresia(membresiaSeleccionada, registrarUsuario(miembro));
        }

        private Usuario registrarUsuario(Miembro miembro)
        {
            Usuario usuario = new Usuario(miembro);
            string resultado = usuarioService.Registrar(usuario);
            MessageBox.Show(resultado);
            return usuario;
        }

        private void RegistrarMembresia(Membresia membresia,Usuario usuario)
        {
            if (usuario != null)
            {
                PerfilMembresia perfil = new PerfilMembresia();
                perfil.DatosUsuario = usuario;
                perfil.TipoMembresia = membresia;
                perfil.Pagado = true;
                PMembresiaService PmembresiaService = new PMembresiaService();
                MessageBox.Show(PmembresiaService.Registrar(perfil));
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
            imageBytes = null; // Limpiar la imagen seleccionada
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
            }
            TiposMembresia.DataSource = membresias;
            TiposMembresia.DisplayMember = "Nombre";
        }


        private void btnagregarfoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    imageBytes = File.ReadAllBytes(filePath);
                    MessageBox.Show("Imagen seleccionada: " + filePath);
                }
                else
                {
                    return;
                }
            }
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

    }
}
