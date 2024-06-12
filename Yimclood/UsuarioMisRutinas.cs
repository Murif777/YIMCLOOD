using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Controls.Primitives;
using System.Drawing.Text;
using ENTITY;
using BILL;



namespace Presentacion
{
    public partial class UsuarioMisRutinas : Form
    {
        private Miembro Miembro;
        private RutinaService rutinaService = new RutinaService();
        public UsuarioMisRutinas(Miembro Miembro)
        {
            InitializeComponent();
            this.Miembro = Miembro;
            ComboboxRutinas();
            cbRutinas.SelectedIndexChanged += (sender, e) =>
            {
                mostrarEjerciciosTabla();
            };
        }
        private void ComboboxRutinas()
        {
            string cedula = Miembro.Cedula;
            List<Rutina> rutinas = rutinaService.ConsultarPersonalizadas(cedula);
            if (rutinas == null)
            {
                MessageBox.Show("Lista vacia");
            }
            else
            {
                rutinas.Insert(0, new Rutina { Nombre = "Ninguno" });
                cbRutinas.DropDownStyle = ComboBoxStyle.DropDownList;
                cbRutinas.DataSource = rutinas;
                cbRutinas.DisplayMember = "Nombre";
            }
        }
        private void EliminarRutina(string nombreRutina)
        {
            MessageBox.Show(rutinaService.EliminnarRutina(nombreRutina));
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Rutina rutinaSeleccionada = cbRutinas.SelectedItem as Rutina;
            if (rutinaSeleccionada != null)
            {
                string mensaje = $"¿Está seguro de eliminar la rutina '{rutinaSeleccionada.Nombre}'?";
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    EliminarRutina(rutinaSeleccionada.Nombre);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna rutina para eliminar.");
            }
        }
        private void mostrarEjerciciosTabla()
        {
            Rutina rutinaSeleccionada = cbRutinas.SelectedItem as Rutina;
            if (rutinaSeleccionada != null && rutinaSeleccionada.Nombre == "Ninguno")
            {
                limpiarCampos();
                return;
            }
            lblNombre.Text = rutinaSeleccionada.Nombre;
            lblDescripcion.Text = rutinaSeleccionada.Descripcion;
            if (rutinaSeleccionada != null)
            {
                List<Ejercicio> ejercicios = rutinaSeleccionada.Ejercicios;

                if (ejercicios != null && ejercicios.Count > 0)
                {
                    var viewList = ejercicios.Select(p => new
                    {
                        Foto = p.Foto,
                        Nombre = p.Nombre,
                        Descripcion = p.Descripcion,
                        Duracion = p.Duracion,
                        Repeticiones = p.Repeticiones,
                        Series = p.Series,
                        Musculo = p.Musculo,
                        Categoria = p.Categoria

                    }).ToList();

                    tablaEjercicios.DataSource = viewList;
                    tablaEjercicios.Columns["Foto"].DisplayIndex = 0;
                    tablaEjercicios.Columns["Nombre"].DisplayIndex = 1;
                    tablaEjercicios.Columns["Descripcion"].DisplayIndex = 2;
                    tablaEjercicios.Columns["Duracion"].DisplayIndex = 3;
                    tablaEjercicios.Columns["Repeticiones"].DisplayIndex = 4;
                    tablaEjercicios.Columns["Series"].DisplayIndex = 5;
                    tablaEjercicios.Columns["Musculo"].DisplayIndex = 6;
                    tablaEjercicios.Columns["Categoria"].DisplayIndex = 7;
                    tablaEjercicios.ColumnHeadersVisible = false;
                    tablaEjercicios.RowHeadersVisible = false;
                    foreach (DataGridViewRow row in tablaEjercicios.Rows)
                    {
                        row.Height = 100; // Establece la altura deseada para cada fila
                    }
                    DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)tablaEjercicios.Columns["Foto"];
                    imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("La rutina seleccionada no contiene ejercicios.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna rutina.");
            }
        }
        private void limpiarCampos()
        {
            lblDescripcion.Text = "";
            lblNombre.Text = "";
            tablaEjercicios.DataSource = null;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void cbRutinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}