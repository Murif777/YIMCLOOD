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
    public partial class UsuarioRutinasPrees : Form
    {
        private RutinaService rutinaService = new RutinaService();
        private Miembro miembro;
        public UsuarioRutinasPrees(Miembro miembro)
        {
            InitializeComponent();
            this.miembro= miembro;
            ComboboxRutinasPrees();
            cbRutinas.SelectedIndexChanged += (sender, e) =>
            {
                mostrarEjerciciosTabla();
            };
        }
        private void ComboboxRutinasPrees()
        {
            List<Rutina> rutinas = rutinaService.ConsultarPrees();
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
        private void mostrarEjerciciosTabla()
        {
            Rutina rutinaSeleccionada = cbRutinas.SelectedItem as Rutina;
            if (rutinaSeleccionada != null && rutinaSeleccionada.Nombre == "Ninguno")
            {
                limpiarCampos();
                return;
            }
            lblNombre.Text = rutinaSeleccionada.Nombre;
            lblDescripcion.Text= rutinaSeleccionada.Descripcion;
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
        private void AgregarMisRutinas()
        {
            Rutina rutinaSeleccionada = cbRutinas.SelectedItem as Rutina;
            foreach (var item in rutinaSeleccionada.Ejercicios)
            {
                Console.WriteLine(item.Descripcion);
            }
            List<Rutina> Rutinas = rutinaService.ConsultarPersonalizadas(miembro.Cedula);
            if (!Rutinas.Contains(rutinaSeleccionada))
            {
                GuardarBD(rutinaSeleccionada);
            }
            else
            {
                MessageBox.Show("La rutina seleccionada ya ha sido agregada.");
            }
            //limpiarCampos();
        }
        private void GuardarBD(Rutina rutinaseleccionada)
        {
            Rutina rutina = rutinaseleccionada;
            rutina.Miembro = miembro;
            MessageBox.Show(rutinaService.RegistrarPersonalizada(rutina));
        }
        private void limpiarCampos()
        {
            lblDescripcion.Text = "";
            lblNombre.Text="";
            tablaEjercicios.DataSource = null;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMisRutinas();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void arrastrarElemento()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnlPadre_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarElemento();
        }

    }
}