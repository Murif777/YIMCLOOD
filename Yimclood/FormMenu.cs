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

namespace Presentacion
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
            butonregistrar.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            buttonConsultar.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private bool menuAbierto = true;
        private Form currentChildForm;
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuAbierto)
            {
                
                menuVertical.Width = 0;
                butonregistrar.Visible = false;
                buttonConsultar.Visible = false;
            }
            else
            {
                
                menuVertical.Width = 250;
                butonregistrar.Visible = true;
                buttonConsultar.Visible = true;
            }

            
            menuAbierto = !menuAbierto;
            if (currentChildForm != null)
            {
                AdjustChildForm();
            }
        }


        //TRATABA DE ACOMODAR EL FROM HIJO EN EL MISMO PANEL PIRNCIPAL
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill; 

            panelContenedor.Controls.Add(currentChildForm);
            panelContenedor.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                AdjustChildForm();
            }
        }

        private void AdjustChildForm()
        {
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.Refresh();
        }




        private void btnMMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btnMCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelMYIMCLOOD_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        

        private void butonregistrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegistrar());
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void btnMMinimizar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
