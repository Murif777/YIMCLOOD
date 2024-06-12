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
using System.Net.NetworkInformation;
using System.IO;
using System.util;



namespace Presentacion
{
    public partial class UsuarioEjercicios : Form
    {
        private EjercicioService ejercicioService = new EjercicioService();
        private UsuarioMenuPrincipal _usuarioMenuPrincipal;
        private Miembro miembro;
        public UsuarioEjercicios(UsuarioMenuPrincipal usuarioMenuPrincipal, Miembro miembro)
        {
            InitializeComponent();
            _usuarioMenuPrincipal = usuarioMenuPrincipal;
            this.miembro = miembro;
           listEjercicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void VerRutinasPrestablecidas()
        {
            _usuarioMenuPrincipal.Abrirformpanel(new UsuarioRutinasPrees(miembro));
        }
        private void VerRutinasPersonalizadas()
        {
            _usuarioMenuPrincipal.Abrirformpanel(new UsuarioRutinaPerso(miembro));
        }
        private void btnCrearRutina_Click(object sender, EventArgs e)
        {
            VerRutinasPersonalizadas();
        }
        private void btnPreestablecidas_Click(object sender, EventArgs e)
        {
            VerRutinasPrestablecidas();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MusculoButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string musculo = clickedButton.Text;
                cargarEjercicio(musculo);
            }
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return b;
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void cargarEjercicio(string musculo)
        {
            var ejercicios = ejercicioService.ConsultarEjercicioMusculo(musculo);
            if (ejercicios == null)
            {
                MessageBox.Show("Vacia mi negro");
                return;
            }

            if (ejercicios.Count > 0)
            {
                listEjercicios.Columns.Clear();
                var viewList = ejercicios.Select(p => new
                {
                    Foto = ResizeImage(ByteArrayToImage(p.Foto), 370, 370),
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    Duracion = p.Duracion,
                    Repeticiones = p.Repeticiones,
                    Series = p.Series,
                    Musculo = p.Musculo,
                    Categoria = p.Categoria
                }).ToList();

                listEjercicios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                listEjercicios.DataSource = viewList;
                listEjercicios.Columns["Foto"].DisplayIndex = 0;
                listEjercicios.Columns["Nombre"].DisplayIndex = 1;
                listEjercicios.Columns["Descripcion"].DisplayIndex = 2;
                listEjercicios.Columns["Duracion"].DisplayIndex = 3;
                listEjercicios.Columns["Repeticiones"].DisplayIndex = 4;
                listEjercicios.Columns["Series"].DisplayIndex = 5;
                listEjercicios.Columns["Musculo"].DisplayIndex = 6;
                listEjercicios.Columns["Categoria"].DisplayIndex = 7;
                foreach (DataGridViewRow row in listEjercicios.Rows)
                {
                    row.Height = 150;
                }
                foreach (DataGridViewColumn column in listEjercicios.Columns)
                {
                    column.Width = 150;
                }
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)listEjercicios.Columns["Foto"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }

        private void MusculoButton_MouseEnter(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;

            if (hoveredButton != null)
            {
                // Cambiar el color y la imagen del botón al pasar el ratón por encima
                CambiarEstiloBotonYImagen(hoveredButton, Color.Red, ObtenerImagenResaltada(hoveredButton));
            }
        }

        private void MusculoButton_MouseLeave(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;

            if (hoveredButton != null)
            {
                // Restaurar el color y la imagen del botón al salir el ratón
                CambiarEstiloBotonYImagen(hoveredButton, SystemColors.Control, Properties.Resources.Musculos);
            }
        }

        private Image ObtenerImagenResaltada(Button button)
        {
            if (button == btnHombros)
            {
                return Properties.Resources.hombrosF;
            }
            else if (button == btnPecho)
            {
                return Properties.Resources.pechoF;
            }
            else if (button == btnBiceps)
            {
                return Properties.Resources.bicepsF;
            }
            else if (button == btnAbdominales)
            {
                return Properties.Resources.abdominalesF;
            }
            else if (button == btnPiernas)
            {
                return Properties.Resources.piernasF;
            }
            else if (button == btnEspalda)
            {
                return Properties.Resources.espaldaF;
            }
            else if (button == btnTriceps)
            {
                return Properties.Resources.tricepsF;
            }
            else if (button == btnAntebrazos)
            {
                return Properties.Resources.antebrazosF;
            }
            else if (button == btnGluteos)
            {
                return Properties.Resources.gluteosF;
            }
            else if (button == btnPantorrillas)
            {
                return Properties.Resources.pantorrillasF;
            }
            else
            {
                return Properties.Resources.Musculos;
            }
        }

        private void CambiarEstiloBotonYImagen(Button boton, Color color, Image imagen)
        {
            boton.BackColor = color;
            musculos.Image = imagen;
        }
    }
}