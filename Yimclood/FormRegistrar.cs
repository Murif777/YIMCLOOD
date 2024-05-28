using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrar : Form
    {
        MiembroService miembroService = new MiembroService();
        public FormRegistrar()
        {
            
            InitializeComponent();
            this.Shown += new EventHandler(FormRegistrar_Shown);
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtCedula.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarMiembro();
            Limpiar_Campos();

        }
        private void registrarMiembro()
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string sexo = Sexo();
            string correo = txtCorreo.Text;
            DateTime FechaNacimiento = fechaNacimiento.Value;
            PerfilMembresia tipoMembresia = null;//Falta agregar listado de membresias
            Miembro miembro = new Miembro(
                cedula, nombre, apellido, telefono, sexo, correo, FechaNacimiento,
                0, 0, tipoMembresia, null);
            MessageBox.Show(miembroService.Registrar(miembro));
            //MessageBox.Show("correo+"+miembro.Correo + "+" + miembro.DatosUsuario.Clave);
        
        }
        private string Sexo()
        {
            if (rdbtnHombre.Checked)
            {
                return "Hombre";
            }
            if (rdbtnMujer.Checked)
            {
                return "Mujer";
            }
            return null;
        }
        private void Limpiar_Campos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            rdbtnHombre.Checked = false;
            rdbtnMujer.Checked = false;
        }
    }

}
