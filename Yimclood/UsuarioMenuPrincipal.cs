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



namespace Presentacion
{
    public partial class UsuarioMenuPrincipal : Form
    {
        public UsuarioMenuPrincipal()
        {
            InitializeComponent();
            btnMaxRes.Image = Properties.Resources.minimizarVentana;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Funciones
        private void FormInterfaz_Load(object sender, EventArgs e)
        {

        }

        private void arrastrarElemento()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void maiximizarVentana()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void restaurarVentana()
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void cerrarApp()
        {
            Application.Exit();
        }

        private void Abrirformpanel(Form formHijo)
        {
            if (this.pnlPadre.Controls.Count > 0)
                this.pnlPadre.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.pnlPadre.Controls.Add(formHijo);
            this.pnlPadre.Tag = formHijo;
            formHijo.Show();
        }

        //Eventos
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarElemento();
        }

        private void pnlPadre_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarElemento();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            minimizarFormulario();
        }

        private void btnMaxRes_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Minimized)
            {
                maiximizarVentana();
                btnMaxRes.Image = Properties.Resources.minimizarVentana;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                restaurarVentana();
                btnMaxRes.Image = Properties.Resources.maximizarVentana;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrarApp();
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            UsuarioEjercicios rutinasRecomendadas = new UsuarioEjercicios();
            Abrirformpanel(rutinasRecomendadas);
        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            UsuarioRutinasPrees rutinasPersonalizadas = new UsuarioRutinasPrees();
            Abrirformpanel(rutinasPersonalizadas);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            UsuarioHistorial historial = new UsuarioHistorial();
            Abrirformpanel(historial);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            UsuarioPerfil perfilPesoCliente = new UsuarioPerfil();
            Abrirformpanel(perfilPesoCliente);
        }
    }
}