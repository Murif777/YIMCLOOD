using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using BILL;
using ENTITY;

namespace Presentacion
{
    public partial class Login : Form
    {
        private UsuarioService UsuarioService = new UsuarioService();

        public Login()
        {
            InitializeComponent();
            metododeprueba();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txt_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }
        private void metododeprueba()
        {
            txtUsuario.Text= "faridelcapo0107@gmail.com";
            txtContrasena.Text = "1021667065";
            //txtUsuario.Text= "dariobernatte@hotmail.com";
            //txtContrasena.Text = "1066864190";
        }
        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }
        private void txtContra_Leave(object sender, EventArgs e)
        { 
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void _MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            login();
        }

        private Usuario login()
        {
            string correo= txtUsuario.Text;
            string clave = txtContrasena.Text;
            Usuario usuario = new Usuario(correo,clave);
            if (UsuarioService.Login(usuario))
            {
                AbrirMenu(usuario);
                //MessageBox.Show("Acceso Exitoso");
                return usuario;
            }
            else
            {
                MessageBox.Show("Correo electronico o contraseña incorrectos");
                return null;
            }
        }
        private void AbrirMenu(Usuario usuario)
        {
            if (usuario.CorreoElectronico=="admin@admin")
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                Miembro miembro = DatosPerfil();
                UsuarioMenuPrincipal usuarioMenuPrincipal = new UsuarioMenuPrincipal(miembro);
                usuarioMenuPrincipal.Show();
                this.Hide();
            }
            
        }

        private Miembro DatosPerfil()
        {
            string correo = txtUsuario.Text;
            string clave = txtContrasena.Text;
            Usuario usuario =new Usuario(correo,clave);
            Miembro miembro = UsuarioService.DatosMiembro(usuario);
            return miembro;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña recuperarContraseña = new RecuperarContraseña();
            recuperarContraseña.Show();
            this.Hide();
        }
    }
}
