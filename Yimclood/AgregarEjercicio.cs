using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class AgregarEjercicio : Form
    {
        private byte[] imageBytes;
        private EjercicioService ejercicioService = new EjercicioService();
        public event EventHandler OnRegresar;
        public AgregarEjercicio()
        {
            InitializeComponent();
            DatosPorDefecto();
        }

        private bool registrarEjercicio()
        {
            // Obtener los valores de los controles de la interfaz de usuario
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            TimeSpan duracion = TimeSpan.FromMinutes((double)numDuracion.Value);
            string musculo = cbMusculo.SelectedItem?.ToString();
            string categoria = cbCategorias.SelectedItem?.ToString();
            int series = (int)NumSeries.Value;
            int repeticiones = (int)nmRepeticiones.Value;

            // Validaciones
            if (!ValidarCamposEjercicio(nombre, descripcion))
            {
                return false;
            }

            // Crear el objeto Ejercicio con los valores obtenidos
            Ejercicio ejercicio;

            if (series == 0 && repeticiones == 0)
            {
                ejercicio = new Ejercicio(nombre, descripcion, duracion, musculo, categoria, imageBytes);
            }
            else
            {
                ejercicio = new Ejercicio(nombre, descripcion, repeticiones, series, musculo, categoria, imageBytes);
            }

            // Llamar al servicio o método para guardar el ejercicio
            MessageBox.Show(ejercicioService.Registrar(ejercicio));
            return true;
        }

        private bool ValidarCamposEjercicio(string nombre, string descripcion)
        {
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

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de validación");
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (registrarEjercicio())
            {
                Limpiar_Campos();
            }
        }
        private void Limpiar_Campos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            numDuracion.Value = 0;
            cbMusculo.SelectedIndex = -1;
            cbCategorias.SelectedIndex = -1;
            NumSeries.Value = 0;
            nmRepeticiones.Value = 0;
            imageBytes = null;
            pbFoto.Image = null;
        }
        private void DatosPorDefecto()
        {
            ComboboxCategorias();
            ComboboxMusculos();
            numDuracion.Value = 0;
            NumSeries.Value = 0;
            nmRepeticiones.Value = 0;
        }
        private void ComboboxMusculos()
        {
            List<string> musculos = new List<string>()
            {
                "Hombros", "Pecho", "Bíceps", "Abdominales", "Piernas", "Espalda", "Tríceps", "Antebrazos", "Glúteos", "Pantorrillas"
            };  
            cbMusculo.DataSource = musculos;
            cbMusculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ComboboxCategorias()
        {
            List<string> categorias = new List<string>()
            {
                "Ejercicios Cardiovasculares",
                "Entrenamiento de Fuerza",
                "Flexibilidad y Movilidad",
                "Entrenamiento Funcional",
                "Yoga y Pilates",
                "Entrenamiento de Intervalos de Alta Intensidad (HIIT)",
                "Entrenamiento de Resistencia",
                "Ejercicios de Equilibrio y Estabilidad"
            };

            cbCategorias.DataSource = categorias;
            cbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnSubirfoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                //Asegúrate de que este diálogo solo se muestre una vez
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string filePath = openFileDialog.FileName;
                    imageBytes = File.ReadAllBytes(filePath);
                    MessageBox.Show("Imagen seleccionada: " + filePath);
                }
            }
            byte[] foto = imageBytes;
            if (foto != null)
            {
                Image image = Image.FromStream(new MemoryStream(foto));

                int nuevoAncho = 175;
                int nuevoAlto = 175;
                Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

                pbFoto.Image = imagenRedimensionada;
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
    }


}
