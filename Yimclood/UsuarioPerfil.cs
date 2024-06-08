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
        private Login login = new Login();


        public UsuarioPerfil()
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
            Miembro miembro = login.DatosPerfil();
            lblNombre.Text = miembro.Nombre;
        }

        private void pnlPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void rbtnActual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

        }

        private void lblValorPesoIdeal_Click(object sender, EventArgs e)
        {

        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {

        }

        private void lblValorGrasa_Click(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void rbtDiferencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void rbtObjetivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl59_Click(object sender, EventArgs e)
        {

        }

        private void btnPeso_Click(object sender, EventArgs e)
        {

        }

        private void lblValorBMI_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Eventos

    }
}