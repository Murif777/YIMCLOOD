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
    public partial class UsuarioConsultarMedidas : Form
    {
        private Login login = new Login();


        public UsuarioConsultarMedidas()
        {
            InitializeComponent();
        }

        private void UsuarioConsultarMedidas_Load(object sender, EventArgs e)
        {
            lblFecha.Text= UsuarioHistorial.static_year+"/"+UsuarioHistorial.static_month+"/"+UserControlDays.static_day;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }
            private void btnMinimizar_Click(object sender, EventArgs e)
        {
            minimizarFormulario();
        }

    }
}