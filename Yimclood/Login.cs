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
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
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

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            login();
            DatosPerfil();
        }

        private void registrar() 
        {
            
            //UsuarioService.Conexion(txtUsuario.Text,txtContrasena.Text);
        }

        private Usuario login()
        {
            string correo= txtUsuario.Text;
            string clave = txtContrasena.Text;
            Usuario usuario = new Usuario(correo,clave);
            if (UsuarioService.Login(usuario))
            {
                MessageBox.Show("Acceso Exitoso");
                AbrirMenu(usuario);
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
                UsuarioMenuPrincipal usuarioMenuPrincipal = new UsuarioMenuPrincipal();
                usuarioMenuPrincipal.Show();
                this.Hide();
            }
            
        }

        public Miembro DatosPerfil()
        {
            string correo = txtUsuario.Text;
            string clave = txtContrasena.Text;
            Usuario usuario = new Usuario(correo, clave);
            //Usuario usuario = login();
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
