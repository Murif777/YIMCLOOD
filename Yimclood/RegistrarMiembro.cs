using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registrar : Form
    {
        private MiembroService miembroService = new MiembroService();
        private UsuarioService usuarioService = new UsuarioService();
        private MembresiaService MembresiaService = new MembresiaService();

        public Registrar()
        {
            InitializeComponent();
            ComboboxMembresias();
            this.Shown += new EventHandler(FormRegistrar_Shown);
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarMiembro();
            Limpiar_Campos();
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

            Membresia membresiaSeleccionada = (Membresia)TiposMembresia.SelectedItem;
            Miembro miembro = new Miembro(
                cedula, nombre, apellido, telefono, sexo, correo, FechaNacimiento,
                0, 0, null);

            MessageBox.Show(miembroService.Registrar(miembro));
            registrarUsuario(miembro);
        }

        private void registrarUsuario(Miembro miembro)
        {
            Usuario usuario = new Usuario(miembro);
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

        private void ComboboxMembresias()
        {
            List<Membresia> membresias = MembresiaService.ConsultarTodo();
            if (membresias == null)
            {
                MessageBox.Show("Lista vacia");
            }
            else
            {
                membresias.Insert(0, new Membresia { Nombre = "Ninguno" }); // Añade "Ninguno" al inicio de la lista
            }

            TiposMembresia.DataSource = membresias;
            TiposMembresia.DisplayMember = "Nombre";
        }
    }
}
