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
        private void GuardarRegistroBD()
        {
            Registro registro = new Registro();

            registro.Peso = int.Parse(txtPeso.Text);
            registro.Hombros=int.Parse(txtHombros.Text);
            registro.Pecho = int.Parse(txtPecho.Text);
            registro.AntebrazoIzquierdo = int.Parse(txtAntebraIzq.Text);
            registro.AntebrazoDerecho = int.Parse(txtAntebrazoDe.Text);
            registro.BrazoIzquierdo = int.Parse(txtBrazoIzq.Text);
            registro.BrazoDerecho= int.Parse(txtBrazoDe.Text);
            registro.Cintura = int.Parse(txtCintura.Text);
            registro.Cadera= int.Parse(txtCadera.Text);
            registro.PiernaIzquierda = int.Parse(txtPiernaIzq.Text);
            registro.PiernaDerecha = int.Parse(txtPiernaDe.Text);
            registro.GemeloIzquierdo = int.Parse(txtGemeloIzq.Text);
            registro.GemeloDerecho= int.Parse(txtGemeloDe.Text);
            registro.Altura = int.Parse(txtAltura.Text);
            registro.Foto = imageBytes;

            Historial historial = new Historial();
            historial.Miembro = miembroRecibido;
            historial.Fecha = DateTime.Now;
            historial.Registro = registro;

            MessageBox.Show(historialService.Registrar(historial));
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