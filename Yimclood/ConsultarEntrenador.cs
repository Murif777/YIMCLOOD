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
        private List<Entrenador> listaEntrenadores;
        public ConsultarEntrenador()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtCedula.KeyPress += new KeyPressEventHandler(txtCedula_KeyPress);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            MostrarTabla();
            //CargarDatos(entrenador);
            pnlActualizar.Visible = false;
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
            listaEntrenadores = entrenadorService.Consultar();
            if (listaEntrenadores != null && listaEntrenadores.Count > 0)
            {
                var viewList = listaEntrenadores.Select(p => new
                {
                    Foto = p.Foto,
                    Cedula = p.Cedula,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Correo = p.Correo,
                    Telefono = p.Telefono,
                    Sexo = p.Sexo,
                    FechaNacimiento = p.FechaNacimiento
                }).ToList();

                dataGridView1.DataSource = viewList;

                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Cedula"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Apellido"].DisplayIndex = 3;
                dataGridView1.Columns["Correo"].DisplayIndex = 4;
                dataGridView1.Columns["Telefono"].DisplayIndex = 5;
                dataGridView1.Columns["Sexo"].DisplayIndex = 6;
                dataGridView1.Columns["FechaNacimiento"].DisplayIndex = 7;

                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacía");
            }
        }

        private void MostrarBusqueda()
        {
            string cedula = txtCedula.Text;
            var entrenadores = entrenadorService.ConsultarCed(cedula);
            if (entrenadores != null && entrenadores.Count > 0)
            {
                var viewList = entrenadores.Select(p => new
                {
                    Foto = p.Foto,
                    Cedula = p.Cedula,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Correo = p.Correo,
                    Telefono = p.Telefono,
                    Sexo = p.Sexo,
                    FechaNacimiento = p.FechaNacimiento
                }).ToList();

                dataGridView1.DataSource = viewList;

                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Cedula"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Apellido"].DisplayIndex = 3;
                dataGridView1.Columns["Correo"].DisplayIndex = 4;
                dataGridView1.Columns["Telefono"].DisplayIndex = 5;
                dataGridView1.Columns["Sexo"].DisplayIndex = 6;
                dataGridView1.Columns["FechaNacimiento"].DisplayIndex = 7;

                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacía");
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

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }
        private Entrenador AsignaciondeValoresEntrenador()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string cedula = selectedRow.Cells["Cedula"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string telefono = selectedRow.Cells["Telefono"].Value.ToString();
                string correo = selectedRow.Cells["Correo"].Value.ToString();
                string fechanacimiento = selectedRow.Cells["FechaNacimiento"].Value.ToString();
                string sexo = selectedRow.Cells["Sexo"].Value.ToString();
                byte[] foto = (byte[])selectedRow.Cells["Foto"].Value;

                Entrenador entrenador = new Entrenador();
                entrenador.Cedula = cedula;
                entrenador.Nombre = nombre;
                entrenador.Apellido = apellido;
                entrenador.Telefono = telefono;
                entrenador.Correo = correo;
                entrenador.FechaNacimiento = Convert.ToDateTime(fechanacimiento);
                entrenador.Sexo = sexo;
                entrenador.Foto = foto;

                return entrenador;
            }
            MessageBox.Show("Seleccione un entrenador de la tabla");
            return null;
        }
        private void Abrirformpanel(Form formHijo)
        {
            if (this.pnlActualizar.Controls.Count > 0)
                this.pnlActualizar.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlActualizar.Controls.Add(formHijo);
            this.pnlActualizar.Tag = formHijo;
            formHijo.Show();

            if (formHijo is RegistrarEntrenador)
            {
                RegistrarEntrenador registrarForm = (RegistrarEntrenador)formHijo;
                registrarForm.button1.Visible = false;
                registrarForm.Btnregresar.Visible = false; // Botón Regresar
                registrarForm.btnActualizar.Visible = true;
                registrarForm.AsignarCampos();
            }


        }
        private void FormActualizar()
        {
            Entrenador entrenador = AsignaciondeValoresEntrenador();
            if (entrenador != null)
            {
                pnlActualizar.Visible = true;
                RegistrarEntrenador registrar = new RegistrarEntrenador(entrenador);
                Abrirformpanel(registrar);
            }
        }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            FormActualizar();
        }

        private void ConsultarEntrenador_Click(object sender, EventArgs e)
        {
            this.pnlActualizar.Visible = false;
        }
    }
}

