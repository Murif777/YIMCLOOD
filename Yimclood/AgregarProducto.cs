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
    public partial class AgregarProducto : Form
    {
        private ProductoService productoService = new ProductoService();
        public event EventHandler OnRegresar;
        private byte[] imageBytes;
        private Producto productoRecibido;

        public AgregarProducto(Producto newProducto)
        {
            InitializeComponent();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            this.btnSubirfoto.Click += new EventHandler(this.btnSubirfoto_Click_1);
            this.productoRecibido = newProducto;
            BtnActualizar.Visible = false;
        }


        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtReferencia.Focus();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (registrarProducto())
            {
                Limpiar_Campos();
            }
        }
        private bool registrarProducto()
        {
            // Obtén los valores de los campos de texto
            string referencia = txtReferencia.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string valorTexto = txtPrecio.Text.Trim();
            string cantidadTexto = txtCantidad.Text.Trim();

            // Validaciones
            if (!ValidarCampos(referencia, nombre, descripcion, valorTexto, cantidadTexto, out int valor, out int cantidad))
            {
                return false;
            }

            // Crear el producto y registrarlo
            Producto producto = new Producto(referencia, nombre, descripcion, valor, cantidad, imageBytes);
            MessageBox.Show(productoService.Registrar(producto));
            return true;
        }

        private bool ValidarCampos(string referencia, string nombre, string descripcion, string valorTexto, string cantidadTexto, out int valor, out int cantidad)
        {
            valor = 0;
            cantidad = 0;

            if (!EsReferenciaValida(referencia))
            {
                MostrarMensajeError("La referencia debe contener solo números y no puede estar vacía.");
                return false;
            }

            if (!EsNombreValido(nombre))
            {
                MostrarMensajeError("El nombre debe contener solo letras y no puede estar vacío.");
                return false;
            }

            if (!EsDescripcionValida(descripcion))
            {
                MostrarMensajeError("La descripción debe contener solo letras y no puede estar vacía.");
                return false;
            }

            if (!EsNumeroValido(valorTexto, out valor))
            {
                MostrarMensajeError("El valor debe ser un número válido y no puede estar vacío.");
                return false;
            }

            if (!EsNumeroValido(cantidadTexto, out cantidad))
            {
                MostrarMensajeError("La cantidad debe ser un número válido y no puede estar vacía.");
                return false;
            }

            return true;
        }

        private bool EsReferenciaValida(string referencia)
        {
            return !string.IsNullOrWhiteSpace(referencia) && referencia.All(char.IsDigit);
        }

        private bool EsNombreValido(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre) && nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsDescripcionValida(string descripcion)
        {
            return !string.IsNullOrWhiteSpace(descripcion) && descripcion.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsNumeroValido(string texto, out int numero)
        {
            return int.TryParse(texto, out numero);
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de validación");
        }

        private void CargarDatosProducto()
        {
            if (productoRecibido != null)
            {
                txtReferencia.Text = productoRecibido.Referencia;
                txtNombre.Text = productoRecibido.Nombre;
                txtDescripcion.Text = productoRecibido.Descripcion;
                txtPrecio.Text = productoRecibido.Valor.ToString();
                txtCantidad.Text = productoRecibido.CantidadDisponible.ToString();
                if (productoRecibido.Foto != null)
                {
                    Image image = Image.FromStream(new MemoryStream(productoRecibido.Foto));
                    int nuevoAncho = 175;
                    int nuevoAlto = 175;
                    Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);
                    pbFoto.Image = imagenRedimensionada;
                }
                imageBytes = productoRecibido.Foto;
            }
        }
        private void Limpiar_Campos()
        {
            txtReferencia.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            imageBytes = null;
            pbFoto = null;
        }
        private void actualizarProductoBD()
        {
            string referencia = txtReferencia.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int valor = int.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            Producto producto = new Producto(
                referencia, nombre, descripcion, valor, cantidad, imageBytes
            );

            MessageBox.Show(productoService.ActualizarProducto(producto));
        }


        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
        public void AsignarCampos()
        {
            if (productoRecibido != null)
            {
                txtReferencia.Text = productoRecibido.Referencia;
                txtReferencia.Enabled = false;
                txtNombre.Text = productoRecibido.Nombre;
                txtDescripcion.Text = productoRecibido.Descripcion;
                txtPrecio.Text = productoRecibido.Valor.ToString();
                txtCantidad.Text = productoRecibido.CantidadDisponible.ToString();

                // Asignar la foto si existe
                byte[] foto = productoRecibido.Foto;
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
            else
            {
                pbFoto.Image = null;
            }
        }


        private void btnSubirfoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                //Asegúrate de que este diálogo solo se muestre una vez
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            actualizarProductoBD();
        }
    }
}
