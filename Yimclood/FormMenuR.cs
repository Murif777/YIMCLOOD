using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormMenuR : Form
    {
        public FormMenuR()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private bool menuAbierto = true;
        private void deslizar_Click(object sender, EventArgs e)
        {
            if (menuAbierto)
            {
                MenuVertical.Width = 0;
                
            }
            else
            {
                MenuVertical.Width = 250;
              
            }
            menuAbierto = !menuAbierto;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Abrirformpanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new FormRegistrar());
        }

        private void BntAgregarporducto_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new FormAgregarProductocs());
        }

        private void btn_ConsultarUsuario_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new FormCnsultarUsuario());
        }

        private void bnt_ConsultarProducto_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new FormConsultar());
        }

        private void btnAEntrenador_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new FormEntrenador());
        }
    }
}
