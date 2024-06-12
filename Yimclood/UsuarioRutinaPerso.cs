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
using BILL;
using ENTITY;



namespace Presentacion
{
    public partial class UsuarioRutinaPerso : Form
    {
        private RutinaService RutinaService = new RutinaService();
        private EjercicioService ejercicioService = new EjercicioService();
        private List<Ejercicio> ejerciciosSeleccionados = new List<Ejercicio>();
        private List<Ejercicio> todosEjercicios;
        private Ejercicio ejercicioTemporal;
        private Miembro miembro;
        public UsuarioRutinaPerso(Miembro miembro)
        {
            InitializeComponent();
            mostrarEjerciciosTabla();
            this.miembro = miembro;
        }
        private void ComboboxEjercicios()
        {
            if (ejerciciosSeleccionados == null || ejerciciosSeleccionados.Count == 0)
            {
                MessageBox.Show("Lista vacía");
            }
            else
            {
                cbEjercicios.DropDownStyle = ComboBoxStyle.DropDownList;
                cbEjercicios.DataSource = ejerciciosSeleccionados.Select(e => e.Nombre).ToList();
            }
        }
        private void mostrarEjerciciosTabla()
        {
            todosEjercicios = ejercicioService.ConsultarEjercicios();

            if (todosEjercicios != null && todosEjercicios.Count > 0)
            {
                var viewList = todosEjercicios.Select(p => new
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
                foreach (DataGridViewRow row in tablaEjercicios.Rows)
                {
                    row.Height = 200; // Establece la altura deseada para cada fila
                }
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)tablaEjercicios.Columns["Foto"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            else
            {
                MessageBox.Show("La rutina seleccionada no contiene ejercicios.");
            }
        }

        private void SelecciondeTabla()
        {
            if (ejercicioTemporal != null)
            {
                if (!ejerciciosSeleccionados.Any(ej => ej.Nombre == ejercicioTemporal.Nombre))
                {
                    ejerciciosSeleccionados.Add(ejercicioTemporal);
                    ComboboxEjercicios();
                    MessageBox.Show("Ejercicio agregado");
                }
                else
                {
                    MessageBox.Show("El ejercicio ya está en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ejercicio de la tabla.");
            }
        }

        private void GuardarBD()
        {
            string nombre =txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            Rutina rutina = new Rutina();
            rutina.Nombre = nombre;
            rutina.Descripcion = descripcion;
            rutina.Miembro = miembro;
            rutina.Ejercicios = ejerciciosSeleccionados;
            foreach (var item in rutina.Ejercicios)
            {
                Console.WriteLine(item.Nombre);
            }
            MessageBox.Show(RutinaService.RegistrarPersonalizada(rutina));
        }
        private void btnAgregarEjercicio_Click(object sender, EventArgs e)
        {
            SelecciondeTabla();
        }
        private void btnGuadar_Click(object sender, EventArgs e)
        {
            GuardarBD();
        }
        private void TablaEjercicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el ejercicio seleccionado
                string nombreEjercicio = tablaEjercicios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                ejercicioTemporal = ejercicioService.ConsultarEjercicios().FirstOrDefault(ej => ej.Nombre == nombreEjercicio);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void tablaEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}