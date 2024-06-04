using BILL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ConsultarEntrenador : Form
    {
        private EntrenadorService entrenadorService = new EntrenadorService();
        private UsuarioService usuarioService = new UsuarioService();
        public event EventHandler OnRegresar;
        public ConsultarEntrenador()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtCedula.KeyPress += new KeyPressEventHandler(txtCedula_KeyPress);
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            var entrenador = entrenadorService.BuscarPorCedula(cedula);

            if (entrenador != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Identificación");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Sexo");
                dt.Columns.Add("Teléfono");
                dt.Columns.Add("Correo");

                DataRow row = dt.NewRow();
                row["Identificación"] = entrenador.Cedula;
                row["Nombre"] = entrenador.Nombre;
                row["Apellido"] = entrenador.Apellido;
                row["Sexo"] = entrenador.Sexo;
                row["Teléfono"] = entrenador.Telefono;
                row["Correo"] = entrenador.Correo;

                dt.Rows.Add(row);

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Entrenador no encontrado.");
            }
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                MessageBox.Show("Por favor, ingresa solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                e.Handled = true;
            }
        }
    }
}
