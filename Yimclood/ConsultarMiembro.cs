using BILL;
using ENTITY;
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
    public partial class ConsultarMiembro : Form
    {
        private MiembroService miembroService = new MiembroService();
        public event EventHandler OnRegresar;
        public ConsultarMiembro()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            Miembro miembro = miembroService.BuscarPorCedul(cedula);
            if(miembro!=null)
            {
                MostrarMiembroEnDataGridView(miembro);
            }
            else
            {
                MessageBox.Show("Miembro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MostrarMiembroEnDataGridView(Miembro miembro)
        {
            dataGridViewMiembro.Rows.Clear();

            // Agregar una fila al DataGridView con los datos del miembro
            dataGridViewMiembro.Rows.Add(miembro.Nombre, miembro.Cedula, miembro.Telefono, miembro.Correo);
            dataGridViewMiembro.Columns.Add("Nombre", "Nombre");
            dataGridViewMiembro.Columns.Add("Identificacion", "Identificación");
            dataGridViewMiembro.Columns.Add("Numero", "Número de Teléfono");
            dataGridViewMiembro.Columns.Add("Correo", "Correo Electrónico");
        }
    }
}
