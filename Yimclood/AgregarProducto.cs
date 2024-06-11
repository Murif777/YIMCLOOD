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
        private Producto newProducto;

        public AgregarProducto(Producto newProducto)
        {
            InitializeComponent();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            this.btnSubirfoto.Click += new EventHandler(this.btnSubirfoto_Click_1);
            this.newProducto = newProducto;
            BtnActualizar.Visible = false;
        }


        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtReferencia.Focus();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            registrarProducto();
            Limpiar_Campos();
        }
        private void registrarProducto()
        {
            string Referencia = txtReferencia.Text;
            string nombre = txtNombre.Text;
            string Descripcion = txtDescripcion.Text;
            int valor = int.Parse(txtPrecio.Text);
            int cantidad=int.Parse(txtCantidad.Text);
            Producto producto = new Producto(
                Referencia, nombre, Descripcion, valor,cantidad,imageBytes);
            MessageBox.Show(productoService.Registrar(producto));
        }
        private void CargarDatosProducto()
        {
            if (newProducto != null)
            {
                txtReferencia.Text = newProducto.Referencia;
                txtNombre.Text = newProducto.Nombre;
                txtDescripcion.Text = newProducto.Descripcion;
                txtPrecio.Text = newProducto.Valor.ToString();
                txtCantidad.Text = newProducto.CantidadDisponible.ToString();
                if (newProducto.Foto != null)
                {
                    Image image = Image.FromStream(new MemoryStream(newProducto.Foto));
                    int nuevoAncho = 175;
                    int nuevoAlto = 175;
                    Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);
                    pbFoto.Image = imagenRedimensionada;
                }
                imageBytes = newProducto.Foto;
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
            if (newProducto != null)
            {
                txtReferencia.Text = newProducto.Referencia;
                txtReferencia.Enabled = false;
                txtNombre.Text = newProducto.Nombre;
                txtDescripcion.Text = newProducto.Descripcion;
                txtPrecio.Text = newProducto.Valor.ToString();
                txtCantidad.Text = newProducto.CantidadDisponible.ToString();

                // Asignar la foto si existe
                byte[] foto = newProducto.Foto;
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
