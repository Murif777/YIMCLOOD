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
            string referencia = txtReferencia.Text;
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
            if (ProductoService.Consultar() != null)
            {
                dataGridView1.DataSource = ProductoService.Consultar();
                int lastColumnIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns[lastColumnIndex].Visible = false;

            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
 
                int fotoColumnIndex = 5;

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
    }
}
