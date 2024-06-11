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
using System.Data.SqlTypes;
using System.IO;



namespace Presentacion
{
    public partial class UsuarioPerfil : Form
    {
        private Miembro Miembro;
        private UsuarioMenuPrincipal _usuarioMenuPrincipal;
        public UsuarioPerfil(UsuarioMenuPrincipal usuarioMenuPrincipal,Miembro miembro)
        {
            InitializeComponent();
            this.Miembro = miembro;
            _usuarioMenuPrincipal = usuarioMenuPrincipal;
            datosperfil();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


       private void datosperfil()
        {
            string NombreyApellido= $"{Miembro.Nombre} {Miembro.Apellido}";
            int peso = Miembro.Peso;
            string correo = Miembro.Correo;
            DateTime fecha = Miembro.FechaNacimiento;
            int estatura = Miembro.Estatura;
            byte[] foto = Miembro.Foto;

            if (foto != null)
            {
                Image image = Image.FromStream(new MemoryStream(foto));

                int nuevoAncho = 242;
                int nuevoAlto =  212;
                Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

                fotoPerfil.Image = imagenRedimensionada;
            }

            else
            {
                fotoPerfil.Image = null;
            }
            lblNombreApellido.Text=NombreyApellido;
            lblCorreo.Text=correo;
            lblPeso.Text= peso.ToString();
            lblEstatura.Text= estatura.ToString();
            lblFecha.Text= fecha.ToString("dd-MM-yyyy   ");
        }
        
        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            _usuarioMenuPrincipal.Abrirformpanel(new UsuarioActualizarMiembro(Miembro));
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
             
        }
    }
}