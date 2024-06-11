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
using System.IO;



namespace Presentacion
{
    public partial class UsuarioConsultarMedidas : Form
    {
        private HistorialService HistorialService = new HistorialService();
        private Miembro miembroRecibido;
        public UsuarioConsultarMedidas(Miembro miembro)
        {
            InitializeComponent();
            miembroRecibido = miembro;
        }

        private void UsuarioConsultarMedidas_Load(object sender, EventArgs e)
        {
            AsignarDatos();
        }
        private void AsignarDatos()
        {
            lblFecha.Text = $"{UsuarioHistorial.static_year}/{UsuarioHistorial.static_month}/{UserControlDays.static_day}";
            lblFecha.Enabled = false;

            List<Historial> historialesMiembro = HistorialService.ConsultarCed(miembroRecibido.Cedula);
            DateTime fechaLblFecha = DateTime.Parse(lblFecha.Text);

            foreach (var historial in historialesMiembro)
            {
                if (historial.Fecha.Date == fechaLblFecha.Date)
                {
                    lblPeso.Text = historial.Registro.Peso.ToString();
                    lblHombros.Text = historial.Registro.Hombros.ToString();
                    lblPecho.Text = historial.Registro.Pecho.ToString();
                    lblAntebrazoIzq.Text = historial.Registro.AntebrazoIzquierdo.ToString();
                    lblAntebrazoDe.Text = historial.Registro.AntebrazoDerecho.ToString();
                    lblBrazoIzq.Text = historial.Registro.BrazoIzquierdo.ToString();
                    lblBrazoDe.Text = historial.Registro.BrazoDerecho.ToString();
                    lblCintura.Text = historial.Registro.Cintura.ToString();
                    lblCadera.Text = historial.Registro.Cadera.ToString();
                    lblPiernaIzq.Text = historial.Registro.PiernaIzquierda.ToString();
                    lblPiernasDe.Text = historial.Registro.PiernaDerecha.ToString();
                    lblGemeloIzq.Text = historial.Registro.GemeloIzquierdo.ToString();
                    lblGemeloDe.Text = historial.Registro.GemeloDerecho.ToString();
                    lblAltura.Text = historial.Registro.Altura.ToString();

                    if (historial.Registro.Foto != null)
                    {
                        using (var ms = new MemoryStream(historial.Registro.Foto))
                        {
                            var originalImage = Image.FromStream(ms);

                            var resizedImage = new Bitmap(217, 192);

                            using (var graphics = Graphics.FromImage(resizedImage))
                            {
                                graphics.DrawImage(originalImage, 0, 0, 217, 192);
                            }

                            pbFoto.Image = resizedImage;
                        }
                    }
                    else
                    {
                        pbFoto.Image = null;
                    }

                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }
            private void btnMinimizar_Click(object sender, EventArgs e)
        {
            minimizarFormulario();
        }
    }
}