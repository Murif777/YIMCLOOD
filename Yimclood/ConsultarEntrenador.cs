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
    public partial class ConsultarEntrenador : Form
    {
        private EntrenadorService entrenadorService = new EntrenadorService();
        public event EventHandler OnRegresar;
        public ConsultarEntrenador()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtCedula.KeyPress += new KeyPressEventHandler(txtCedula_KeyPress);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            MostrarTabla();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarBusqueda();
        }
        private void MostrarTabla()
        {
            if (entrenadorService.Consultar() != null)
            {
                dataGridView1.DataSource = entrenadorService.Consultar();
                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }
        private void MostrarBusqueda()
        {
            string cedula = txtCedula.Text;
            var consulta = entrenadorService.ConsultarCed(cedula);
            if (consulta != null)
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
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                MessageBox.Show("Por favor, ingresa solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                e.Handled = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MostrarTabla();

        }

        private void btnEliminarEntrenador_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                try
                {
                    // Obtener la cédula del entrenador
                    string cedulaEntrenador = selectedRow.Cells[1].Value.ToString();

                    // Mostrar mensaje de confirmación
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este entrenador?",
                                                                "Confirmación de eliminación",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Eliminar entrenador
                        string resultado = entrenadorService.EliminarEntrenador(cedulaEntrenador);
                        MessageBox.Show(resultado);

                        // Actualizar el DataGridView después de la eliminación
                        MostrarBusqueda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el entrenador: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un dato de la tabla");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
