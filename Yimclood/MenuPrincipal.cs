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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Abrirformpanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }


        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            var registrarForm = new Registrar();
            registrarForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(registrarForm);
        }

        private void BntAgregarporducto_Click(object sender, EventArgs e)
        {
            var agregarProductoForm = new AgregarProducto();
            agregarProductoForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(agregarProductoForm);
        }

        private void btn_ConsultarUsuario_Click(object sender, EventArgs e)
        {
            var consultarMiembroForm = new ConsultarMiembro();
            consultarMiembroForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(consultarMiembroForm);
        }

        private void bnt_ConsultarProducto_Click(object sender, EventArgs e)
        {
            var consultarProdForm = new ConsultarProd();
            consultarProdForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(consultarProdForm);
        }

        private void btnAEntrenador_Click(object sender, EventArgs e)
        {
            var registrarEntrenadorForm = new RegistrarEntrenador();
            registrarEntrenadorForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(registrarEntrenadorForm);
        }

        private void RegistrarForm_OnRegresar(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                var form = (Form)sender;
                this.panelContenedor.Controls.Remove(form);
                form.Close();
            }
        }

        bool menuExpandAgregar = false;
        bool menuExpandConsultar = false;
        bool slidebarExpand = true;
        private bool menuAbierto = true;

        private void sliderbartransicion_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                MenuVertical.Width -= 10;
                if (MenuVertical.Width <= 70)
                {
                    slidebarExpand = false;
                    sliderbartransicion.Stop();
                }
            }
            else
            {
                MenuVertical.Width += 10;
                if (MenuVertical.Width >= 294)
                {
                    slidebarExpand = true;
                    sliderbartransicion.Stop();
                }
            }

            menuAbierto = !menuAbierto;
        }

        private void deslizar_Click(object sender, EventArgs e)
        {
            sliderbartransicion.Start();
        }

        private void menuTransicion_Tick(object sender, EventArgs e)
        {
            if (!menuExpandAgregar)
            {
                Agregarcontenedor.Height += 10;
                ConsultarContenedor.Top += 10;
                if (Agregarcontenedor.Height >= 230)
                {
                    menuTransicion.Stop();
                    menuExpandAgregar = true;
                }
            }
            else
            {
                Agregarcontenedor.Height -= 10;
                ConsultarContenedor.Top -= 10;
                if (Agregarcontenedor.Height <= 53)
                {
                    menuTransicion.Stop();
                    menuExpandAgregar = false;
                }
            }
        }

        private void consultarTransicion_Tick(object sender, EventArgs e)
        {
        }

        private void menuanimacion_Click(object sender, EventArgs e)
        {
            menuTransicion.Start();
        }

        private void bntconsultar_Click(object sender, EventArgs e)
        {
            consultarTransicion.Start();
        }

        private void consultarTransicion_Tick_1(object sender, EventArgs e)
        {
            if (!menuExpandConsultar)
            {
                ConsultarContenedor.Height += 10;
                if (ConsultarContenedor.Height >= 250)
                {
                    consultarTransicion.Stop();
                    menuExpandConsultar = true;
                }
            }
            else
            {
                ConsultarContenedor.Height -= 10;
                if (ConsultarContenedor.Height <= 58)
                {
                    consultarTransicion.Stop();
                    menuExpandConsultar = false;
                }
            }
        }

        private void ConsultarContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
            
            
        }

        private void btnconsultarfacturas_Click(object sender, EventArgs e)
        {
            var consultarfacturafrom = new ConsultarFacturas();
            consultarfacturafrom.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(consultarfacturafrom);
        }

        

        private void panelsuperior_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnconsultarentrenador_Click(object sender, EventArgs e)
        {
            var consultarentrenadorForm = new ConsultarEntrenador();
            consultarentrenadorForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(consultarentrenadorForm);
        }

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void agregarmembresia_Click(object sender, EventArgs e)
        {
            var agregarmembresiaForm = new AgregarMembresia();
            agregarmembresiaForm.OnRegresar += RegistrarForm_OnRegresar;
            Abrirformpanel(agregarmembresiaForm);

        }

        private void panelsuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}