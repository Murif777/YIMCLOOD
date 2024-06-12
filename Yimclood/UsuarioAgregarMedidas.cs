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
using System.IO;
using BILL;



namespace Presentacion
{
    public partial class UsuarioAgregarMedidas : Form
    {
        private Miembro miembroRecibido;
        private byte[] imageBytes;


        private HistorialService historialService = new HistorialService();
        public UsuarioAgregarMedidas( Miembro miembro)
        {
            InitializeComponent();
            miembroRecibido = miembro;
            AsignarDatos();
        }
        private void AsignarDatos()
        {
           txtPeso.Text= miembroRecibido.Peso.ToString();
           txtAltura.Text= miembroRecibido.Estatura.ToString();
            fecha.Enabled = false;
        }

        private bool ValidarCamposEnteros()
        {
            // Define una función de validación que verifica si un valor es un entero
            bool EsEntero(string valor)
            {
                return int.TryParse(valor, out _);
            }

            // Verifica si todos los campos son enteros
            if (!EsEntero(txtPeso.Text) ||
                !EsEntero(txtHombros.Text) ||
                !EsEntero(txtPecho.Text) ||
                !EsEntero(txtAntebraIzq.Text) ||
                !EsEntero(txtAntebrazoDe.Text) ||
                !EsEntero(txtBrazoIzq.Text) ||
                !EsEntero(txtBrazoDe.Text) ||
                !EsEntero(txtCintura.Text) ||
                !EsEntero(txtCadera.Text) ||
                !EsEntero(txtPiernaIzq.Text) ||
                !EsEntero(txtPiernaDe.Text) ||
                !EsEntero(txtGemeloIzq.Text) ||
                !EsEntero(txtGemeloDe.Text) ||
                !EsEntero(txtAltura.Text))
            {
                MessageBox.Show("Ingrese solo valores enteros en los campos.");
                return false;
            }

            return true;
        }
        private void GuardarRegistroBD()
        {
            if (ValidarCamposEnteros())
            {
                Registro registro = new Registro();

                int? Peso = string.IsNullOrWhiteSpace(txtPeso.Text) ? (int?)null : int.Parse(txtPeso.Text);
                int? Hombros = string.IsNullOrWhiteSpace(txtHombros.Text) ? (int?)null : int.Parse(txtHombros.Text);
                int? Pecho = string.IsNullOrWhiteSpace(txtPecho.Text) ? (int?)null : int.Parse(txtPecho.Text);
                int? AntebrazoIzquierdo = string.IsNullOrWhiteSpace(txtAntebraIzq.Text) ? (int?)null : int.Parse(txtAntebraIzq.Text);
                int? AntebrazoDerecho = string.IsNullOrWhiteSpace(txtAntebrazoDe.Text) ? (int?)null : int.Parse(txtAntebrazoDe.Text);
                int? BrazoIzquierdo = string.IsNullOrWhiteSpace(txtBrazoIzq.Text) ? (int?)null : int.Parse(txtBrazoIzq.Text);
                int? BrazoDerecho = string.IsNullOrWhiteSpace(txtBrazoDe.Text) ? (int?)null : int.Parse(txtBrazoDe.Text);
                int? Cintura = string.IsNullOrWhiteSpace(txtCintura.Text) ? (int?)null : int.Parse(txtCintura.Text);
                int? Cadera = string.IsNullOrWhiteSpace(txtCadera.Text) ? (int?)null : int.Parse(txtCadera.Text);
                int? PiernaIzquierda = string.IsNullOrWhiteSpace(txtPiernaIzq.Text) ? (int?)null : int.Parse(txtPiernaIzq.Text);
                int? PiernaDerecha = string.IsNullOrWhiteSpace(txtPiernaDe.Text) ? (int?)null : int.Parse(txtPiernaDe.Text);
                int? GemeloIzquierdo = string.IsNullOrWhiteSpace(txtGemeloIzq.Text) ? (int?)null : int.Parse(txtGemeloIzq.Text);
                int? GemeloDerecho = string.IsNullOrWhiteSpace(txtGemeloDe.Text) ? (int?)null : int.Parse(txtGemeloDe.Text);
                int? Altura = string.IsNullOrWhiteSpace(txtAltura.Text) ? (int?)null : int.Parse(txtAltura.Text);


                registro.Peso = Peso;
                registro.Hombros = Hombros;
                registro.Pecho = Pecho;
                registro.AntebrazoIzquierdo = AntebrazoIzquierdo;
                registro.AntebrazoDerecho = AntebrazoDerecho;
                registro.BrazoIzquierdo = BrazoIzquierdo;
                registro.BrazoDerecho = BrazoDerecho;
                registro.Cintura = Cintura;
                registro.Cadera = Cadera;
                registro.PiernaIzquierda = PiernaIzquierda;
                registro.PiernaDerecha = PiernaDerecha;
                registro.GemeloIzquierdo = GemeloIzquierdo;
                registro.GemeloDerecho = GemeloDerecho;
                registro.Altura = Altura;
                registro.Foto = imageBytes;

                Historial historial = new Historial();
                historial.Miembro = miembroRecibido;
                historial.Fecha = DateTime.Now;
                historial.Registro = registro;

                MessageBox.Show(historialService.Registrar(historial));
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistroBD();
            this.Visible = false;
        }
        private void btnsubirfoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Asegúrate de que este diálogo solo se muestre una vez
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string filePath = openFileDialog.FileName;
                    imageBytes = File.ReadAllBytes(filePath);
                    MessageBox.Show("Imagen seleccionada: " + filePath);
                }
            }
            byte[] foto = imageBytes;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
    }
}