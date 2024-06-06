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
    public partial class ConsultarMiembro : Form
    {
        private PMembresiaService PMembresiaService=new PMembresiaService();
        public event EventHandler OnRegresar;
        public ConsultarMiembro()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            MostrarTabla();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarBusqueda();
        }
        private void MostrarTabla()
        {
            var perfiles = PMembresiaService.consultartodo();
            if (perfiles != null && perfiles.Count > 0)
            {
                var viewList = perfiles.Select(p => new
                {
                    Foto = p.DatosUsuario.DatosMiembro.Foto,
                    Cedula = p.DatosUsuario.DatosMiembro.Cedula,
                    Nombre = p.DatosUsuario.DatosMiembro.Nombre,
                    Apellido = p.DatosUsuario.DatosMiembro.Apellido,
                    Membresia = p.TipoMembresia.Nombre,
                    Estado = p.Estado,
                    SaldoDebe = p.SaldoDebe,
                    FechaInicio = p.Fechainicio,
                    FechaFinal = p.Fechafinal,
                    DuracionAcumulada = p.DuracionAcumulada,
                    TiempoRestante = p.TiempoRestante,
                    Pagado = p.Pagado
                }).ToList();

                dataGridView1.DataSource = viewList;

                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Cedula"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Apellido"].DisplayIndex = 3;
                dataGridView1.Columns["Membresia"].DisplayIndex = 4;
                dataGridView1.Columns["Estado"].DisplayIndex = 5;
                dataGridView1.Columns["SaldoDebe"].DisplayIndex = 6;
                dataGridView1.Columns["FechaInicio"].DisplayIndex = 7;
                dataGridView1.Columns["FechaFinal"].DisplayIndex = 8;
                dataGridView1.Columns["DuracionAcumulada"].DisplayIndex = 9;
                dataGridView1.Columns["TiempoRestante"].DisplayIndex = 10;
                dataGridView1.Columns["Pagado"].DisplayIndex = 11;

                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }
        private void MostrarBusqueda()
        {
            string cedula= txtCedula.Text;
            var perfiles = PMembresiaService.ConsultarCed(cedula);
            if (perfiles != null && perfiles.Count > 0)
            {
                var viewList = perfiles.Select(p => new
                {
                    Foto=p.DatosUsuario.DatosMiembro.Foto,
                    Cedula = p.DatosUsuario.DatosMiembro.Cedula,
                    Nombre = p.DatosUsuario.DatosMiembro.Nombre,
                    Apellido = p.DatosUsuario.DatosMiembro.Apellido,
                    Membresia = p.TipoMembresia.Nombre,
                    Estado = p.Estado,
                    SaldoDebe = p.SaldoDebe,
                    FechaInicio = p.Fechainicio,
                    FechaFinal = p.Fechafinal,
                    DuracionAcumulada = p.DuracionAcumulada,
                    TiempoRestante = p.TiempoRestante,
                    Pagado = p.Pagado
                }).ToList();

                dataGridView1.DataSource = viewList;

                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Cedula"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Apellido"].DisplayIndex = 3;
                dataGridView1.Columns["Membresia"].DisplayIndex = 4;
                dataGridView1.Columns["Estado"].DisplayIndex = 5;
                dataGridView1.Columns["SaldoDebe"].DisplayIndex = 6;
                dataGridView1.Columns["FechaInicio"].DisplayIndex = 7;
                dataGridView1.Columns["FechaFinal"].DisplayIndex = 8;
                dataGridView1.Columns["DuracionAcumulada"].DisplayIndex = 9;
                dataGridView1.Columns["TiempoRestante"].DisplayIndex = 10;
                dataGridView1.Columns["Pagado"].DisplayIndex = 11;
                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int fotoColumnIndex = 0;

                byte[] foto = (byte[])selectedRow.Cells[fotoColumnIndex].Value;

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
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MostrarTabla();
        }
    }
}
