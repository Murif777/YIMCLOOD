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
        public AgregarProducto()
        {
            InitializeComponent();
            this.Shown += new EventHandler(FormRegistrar_Shown);
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
    }
}
