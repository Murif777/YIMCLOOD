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
    public partial class ActualizarMiembro : Form
    {
        private MiembroService miembroService = new MiembroService();
        private UsuarioService usuarioService = new UsuarioService();
        private MembresiaService MembresiaService = new MembresiaService();
        private byte[] imageBytes;
        private string cedula;

        public ActualizarMiembro(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;

            // Cargar los datos del miembro
            CargarDatosMiembro();
        }
        private void CargarDatosMiembro()
        {
            // Llama a tu servicio o repositorio para obtener los datos del miembro
            Miembro miembro = miembroService.BuscarPorCedul(cedula);

            if (miembro != null)
            {
                // Asignar los valores a los controles del formulario
                txtCedula.Text = miembro.Cedula;
                txtNombre.Text = miembro.Nombre;
                txtApellido.Text = miembro.Apellido;
                txtTelefono.Text = miembro.Telefono;
                

                // Asignar la imagen
                if (miembro.Foto != null)
                {
                    using (MemoryStream ms = new MemoryStream(miembro.Foto))
                    {
                        btnagregarfoto.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el miembro con la cédula especificada.");
                this.Close();
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Miembro miembro = new Miembro
        {
            Cedula = txtCedula.Text,
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Telefono = txtTelefono.Text,
            Sexo = sexo(), // Suponiendo que tienes una función para obtener el sexo
            Correo = txtCorreo.Text,
            FechaNacimiento = fechaNacimiento.Value,
            //Peso = 0, // O el valor que corresponda
            //Estatura = 0, // O el valor que corresponda

        };

        // Llama a tu servicio para actualizar el miembro
        string resultado = miembroService.ActualizarMiembro(miembro);
        MessageBox.Show(resultado);
           
        this.Close();
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
                //PmembresiaService.consultartodo();
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

        private string sexo()
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
        }
    }
}
