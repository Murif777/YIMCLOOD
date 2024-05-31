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
    public partial class AgregarMembresia : Form
    {
        EntrenadorService entrenadorService = new EntrenadorService();
        MembresiaService MembresiaService = new MembresiaService();
        public AgregarMembresia()
        {
            InitializeComponent();
            ComboboxEntrenadores();
            cbEntrenadores.Hide();
            this.Shown += new EventHandler(FormRegistrar_Shown);
        }

        private void FormRegistrar_Shown(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
        private void rbEntrenador_CheckedChanged(object sender, EventArgs e)
        {
            cbEntrenadores.Show();
        }

        private void rbEntrenadoresNo_CheckedChanged(object sender, EventArgs e)
        {
            cbEntrenadores.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            registrarMembresia();
            //Limpiar_Campos();
        }
        private void registrarMembresia()
        {
            string nombre = txtNombre.Text;
            string Descripcion = txtDescripcion.Text;
            int valor = int.Parse(txtValor.Text);
            int duracion = int.Parse(txtDuracion.Text);
            TimeSpan Duracion = TimeSpan.FromDays(duracion);
            Entrenador entrenador = ObtenerEntrenador();
            Membresia membresia = new Membresia( nombre, Descripcion, valor, Duracion, entrenador);
            MessageBox.Show(MembresiaService.Registrar(membresia));
            //MessageBox.Show(cbEntrenadores.SelectedItem != null ? cbEntrenadores.SelectedItem.ToString() : null);
        }
        //private void Limpiar_Campos()
        //{
        //    txtReferencia.Clear();
        //    txtNombre.Clear();
        //    txtDescripcion.Clear();
        //    txtPrecio.Clear();
        //    //foto
        //}
        private void ComboboxEntrenadores()
        {
            List<Entrenador> listaEntrenadores = entrenadorService.Consultar();
            listaEntrenadores.Insert(0, new Entrenador { Nombre = "Ninguno" });
            cbEntrenadores.DataSource = listaEntrenadores;
            cbEntrenadores.DisplayMember = "Nombre";
        }
        private Entrenador ObtenerEntrenador()
        {
            string nombreSeleccionado = cbEntrenadores.SelectedItem != null ? cbEntrenadores.SelectedItem.ToString() : null;
            List<Entrenador> listaEntrenadores = cbEntrenadores.DataSource as List<Entrenador>;
            Entrenador entrenadorSeleccionado = listaEntrenadores.Find(entrenador => entrenador.Nombre == nombreSeleccionado);

            return entrenadorSeleccionado;
        }
    }
}
