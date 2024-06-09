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



namespace Presentacion
{
    public partial class UsuarioPerfil : Form
    {
        private Miembro Miembro;
        public UsuarioPerfil(Miembro miembro)
        {
            InitializeComponent();
            this.Miembro = miembro;
            datosperfil();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


       private void datosperfil()
        {
            lblNombre.Text=Miembro.Nombre;
        }
        private void rbtnActual_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void rbtDiferencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtObjetivo_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}