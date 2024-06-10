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
    public partial class UsuarioAgregarMedidas : Form
    {
        private Login login = new Login();


        public UsuarioAgregarMedidas()
        {
            InitializeComponent();
            DatosMiembro();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
                
        private void DatosMiembro()
        {
            //Miembro miembro = login.DatosPerfil();
            //lblNombre.Text = miembro.Nombre;
        }
        private void cbPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }
    }
}