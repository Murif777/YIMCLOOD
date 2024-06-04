using BILL;
using ENTITY;
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

namespace Presentacion
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO ELECTRONICO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "CORREO ELECTRONICO";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.LightGray;
                txtConfirmar.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmar.ForeColor = Color.DimGray;
                txtConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void FormCrear_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            RecuperarContra();
        }
        private void RecuperarContra()
        {
            if (txtContraseña.Text == txtConfirmar.Text)
            {
                UsuarioService usuarioService = new UsuarioService();
                Usuario usuario = new Usuario();
                Login login = new Login();
                usuario.CorreoElectronico = txtCorreo.Text;
                usuario.Clave = txtContraseña.Text;
                MessageBox.Show(usuarioService.Actualizar(usuario));
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales");
                
            }
        }


    }
  }

