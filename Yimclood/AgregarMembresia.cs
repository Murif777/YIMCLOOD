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
        public event EventHandler OnRegresar;
        public AgregarMembresia()
        {
            InitializeComponent();
            ComboboxEntrenadores();
            cbEntrenadores.Hide();
            this.Shown += new EventHandler(FormRegistrar_Shown);
            btnsalir.Click += new EventHandler(btnsalir_Click);
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
            if (registrarMembresia())
            {
                Limpiar_Campos();
            }
        }

        private bool registrarMembresia()
        {
            // Obtén los valores de los campos de texto
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string valorTexto = txtValor.Text.Trim();
            string duracionTexto = txtDuracion.Text.Trim();

            // Validaciones
            if (!ValidarCamposMembresia(nombre, descripcion, valorTexto, duracionTexto, out int valor, out int duracion))
            {
                return false;
            }

            TimeSpan Duracion = TimeSpan.FromDays(duracion);
            Entrenador entrenador = ObtenerEntrenador();
            Membresia membresia = new Membresia(nombre, descripcion, valor, Duracion, entrenador);
            MessageBox.Show(MembresiaService.Registrar(membresia));
            return true;
        }

        private bool ValidarCamposMembresia(string nombre, string descripcion, string valorTexto, string duracionTexto, out int valor, out int duracion)
        {
            valor = 0;
            duracion = 0;

            if (!EsNombreValido(nombre))
            {
                MostrarMensajeError("El nombre debe contener solo letras y no puede estar vacío.");
                return false;
            }

            if (!EsDescripcionValida(descripcion))
            {
                MostrarMensajeError("La descripción debe contener solo letras y no puede estar vacía.");
                return false;
            }

            if (!EsNumeroValido(valorTexto, out valor))
            {
                MostrarMensajeError("El valor debe ser un número válido y no puede estar vacío.");
                return false;
            }

            if (!EsNumeroValido(duracionTexto, out duracion))
            {
                MostrarMensajeError("La duración debe ser un número válido y no puede estar vacía.");
                return false;
            }

            return true;
        }

        private bool EsNombreValido(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre) && nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsDescripcionValida(string descripcion)
        {
            return !string.IsNullOrWhiteSpace(descripcion) && descripcion.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsNumeroValido(string texto, out int numero)
        {
            return int.TryParse(texto, out numero);
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de validación");
        }

        private void Limpiar_Campos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtValor.Clear();
            txtDuracion.Clear();
            // Si tienes más campos, añádelos aquí
        }

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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
    }
}
