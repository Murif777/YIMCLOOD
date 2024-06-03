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
    public partial class AgregarProducto : Form
    {
        private ProductoService productoService = new ProductoService();
        public event EventHandler OnRegresar;
        public AgregarProducto()
        {
            InitializeComponent();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            btnSubirfoto.Click += new EventHandler(btnSubirfoto_Click);

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
            byte[] foto = null;
            Producto producto = new Producto(
                Referencia, nombre, Descripcion, valor,null);
            MessageBox.Show(productoService.Registrar(producto));
        }
        private void Limpiar_Campos()
        {
            txtReferencia.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            //foto
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void btnSubirfoto_Click(object sender, EventArgs e)
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
