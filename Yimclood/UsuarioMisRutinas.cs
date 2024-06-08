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
    public partial class UsuarioMisRutinas : Form
    {
        public UsuarioMisRutinas()
        {
            InitializeComponent();
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
     
        private void pnlPadre_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarElemento();
        }                 
    }
}