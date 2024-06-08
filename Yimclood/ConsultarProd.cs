using BILL;
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
    public partial class ConsultarProd : Form
    {
        public event EventHandler OnRegresar;
        private  ProductoService ProductoService = new ProductoService();
        public ConsultarProd()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            MostrarTabla();

        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarBusqueda();
        }
        private void MostrarBusqueda()
        {
            string referencia = txtReferenciaProducto.Text;
            var consulta = ProductoService.ConsultarRef(referencia);
            if (consulta!= null)
            {
                dataGridView1.DataSource = consulta;
                int lastColumnIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns[lastColumnIndex].Visible = false;

            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }
        private void MostrarTabla()
        {
            var productos = ProductoService.Consultar();
            if (productos != null && productos.Count > 0)
            {
                var viewList = productos.Select(p => new
                {
                    Foto = p.Foto, 
                    Referencia = p.Referencia,
                    Nombre = p.Nombre,
                    Precio = p.Valor
                }).ToList();
                dataGridView1.DataSource = viewList;
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Referencia"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Precio"].DisplayIndex = 3;
                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacía");
            }
        }

        private void MostrarBusquedaProducto()
        {
            string referencia = txtReferenciaProducto.Text; 
            var productos = ProductoService.ConsultarRef(referencia); 
            if (productos != null && productos.Count > 0)
            {
                var viewList = productos.Select(p => new
                {
                    Foto = p.Foto, 
                    Referencia = p.Referencia,
                    Nombre = p.Nombre,
                    Precio = p.Valor
                }).ToList();
                dataGridView1.DataSource = viewList;
                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Referencia"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Precio"].DisplayIndex = 3;
                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
 
                int fotoColumnIndex = 0;

                byte[] foto = (byte[])selectedRow.Cells[fotoColumnIndex].Value;

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
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectrow = dataGridView1.SelectedRows[0];
                try
                {
                    string referenciaProducto = selectrow.Cells[1].Value.ToString();

                    // Mostrar mensaje de confirmación
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                                "Confirmación de eliminación",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Eliminar producto
                        string resultadoEliminacion = ProductoService.EliminarProducto(referenciaProducto);
                        MessageBox.Show(resultadoEliminacion);

                        // Actualizar el DataGridView después de la eliminación
                        MostrarBusquedaProducto();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un dato de la tabla");
            }
        }
    }
}
