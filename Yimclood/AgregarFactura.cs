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
using static System.Net.WebRequestMethods;

namespace Presentacion
{
    public partial class AgregarFactura : Form
    {
        private PMembresiaService PMembresiaService = new PMembresiaService();
        public event EventHandler OnRegresar;
        private MiembroService miembroService = new MiembroService();
        private List<Miembro> listaMiembros;
        private ProductoService productoService = new ProductoService();
        public AgregarFactura()
        {
            InitializeComponent();
            MostrarTabla();
            this.Load += new EventHandler(Form1_Load);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            comboBoxProductos.SelectedIndexChanged += new EventHandler(comboBoxProductos_SelectedIndexChanged);
            numericUpDownCantidad.ValueChanged += new EventHandler(numericUpDownCantidad_ValueChanged);
            //btnAgregarProducto.Click += new EventHandler(btnAgregarProducto_Click);
            agregarviewcolumnas();
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
                    Correo = p.DatosUsuario.DatosMiembro.Correo,
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
                dataGridView1.Columns["Correo"].DisplayIndex = 4;
                dataGridView1.Columns["Membresia"].DisplayIndex = 5;
                dataGridView1.Columns["Estado"].DisplayIndex = 6;
                dataGridView1.Columns["SaldoDebe"].DisplayIndex = 7;
                dataGridView1.Columns["FechaInicio"].DisplayIndex = 8;
                dataGridView1.Columns["FechaFinal"].DisplayIndex = 9;
                dataGridView1.Columns["DuracionAcumulada"].DisplayIndex = 10;
                dataGridView1.Columns["TiempoRestante"].DisplayIndex = 11;
                dataGridView1.Columns["Pagado"].DisplayIndex = 12;

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
            string cedula = txtCedula.Text;
            var perfiles = PMembresiaService.ConsultarCed(cedula);
            if (perfiles != null && perfiles.Count > 0)
            {
                var viewList = perfiles.Select(p => new
                {
                    Foto = p.DatosUsuario.DatosMiembro.Foto,
                    Cedula = p.DatosUsuario.DatosMiembro.Cedula,
                    Nombre = p.DatosUsuario.DatosMiembro.Nombre,
                    Apellido = p.DatosUsuario.DatosMiembro.Apellido,
                    Correo = p.DatosUsuario.DatosMiembro.Correo,
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
                dataGridView1.Columns["Correo"].DisplayIndex = 4;
                dataGridView1.Columns["Membresia"].DisplayIndex = 5;
                dataGridView1.Columns["Estado"].DisplayIndex = 6;
                dataGridView1.Columns["SaldoDebe"].DisplayIndex = 7;
                dataGridView1.Columns["FechaInicio"].DisplayIndex = 8;
                dataGridView1.Columns["FechaFinal"].DisplayIndex = 9;
                dataGridView1.Columns["DuracionAcumulada"].DisplayIndex = 10;
                dataGridView1.Columns["TiempoRestante"].DisplayIndex = 11;
                dataGridView1.Columns["Pagado"].DisplayIndex = 12;
                int primeraColumna = 0;
                dataGridView1.Columns[primeraColumna].Visible = false;
            }
            else
            {
                MessageBox.Show("Lista vacía");
            }
        }
        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

        //        int fotoColumnIndex = 0;

        //        byte[] foto = (byte[])selectedRow.Cells[fotoColumnIndex].Value;

        //        if (foto != null)
        //        {
        //            Image image = Image.FromStream(new MemoryStream(foto));

        //            int nuevoAncho = 175;
        //            int nuevoAlto = 175;
        //            Image imagenRedimensionada = new Bitmap(image, nuevoAncho, nuevoAlto);

        //            pbFoto.Image = imagenRedimensionada;
        //        }

        //        else
        //        {
        //            pbFoto.Image = null;
        //        }
        //    }
        //}
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LlenarComboBoxProductos();
                comboBoxProductos.Enabled = true; 
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string cedulaMiembro = selectedRow.Cells["Cedula"].Value.ToString();
            }
            else
            {
                comboBoxProductos.DataSource = null; 
                comboBoxProductos.Enabled = false;  
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarBusqueda();
        }
        private void LlenarComboBoxProductos()
        {
            var productos = productoService.Consultar();
            if (productos != null && productos.Count > 0)
            {
                comboBoxProductos.DataSource = productos;
                comboBoxProductos.DisplayMember = "Nombre";  
                comboBoxProductos.ValueMember = "Referencia"; 

            }
            else
            {
                MessageBox.Show("No hay productos disponibles.");
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem != null)
            {
                string referenciaProducto = comboBoxProductos.SelectedValue.ToString();
                string cantidadDisponible = productoService.ObtenerCantidadDisponiblePorReferencia(referenciaProducto);
                txtCantidadDisponible.Text = cantidadDisponible;

                string precioUnitario = productoService.ObtenerPrecioUnitarioPorReferencia(referenciaProducto);
                txtPrecioUnitario.Text = precioUnitario; 
                CalcularPrecioTotal();
            }
        }
        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }
        private void CalcularPrecioTotal()
        {
            if (comboBoxProductos.SelectedItem != null && decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                int cantidad = (int)numericUpDownCantidad.Value;
                decimal precioTotal = precioUnitario * cantidad;
                txtPrecioTotal.Text = precioTotal.ToString("F2"); 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProductos.Enabled = false; 
            LlenarComboBoxProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem != null && int.TryParse(txtCantidadDisponible.Text, out int cantidadDisponible) &&
            decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) && (int)numericUpDownCantidad.Value <= cantidadDisponible)
            {
                string referenciaProducto = comboBoxProductos.SelectedValue.ToString();
                string nombreProducto = comboBoxProductos.Text;
                int cantidad = (int)numericUpDownCantidad.Value;
                decimal precioTotal = precioUnitario * cantidad;
                dataGridViewProductosFactura.Rows.Add(referenciaProducto, nombreProducto, cantidad, precioUnitario, precioTotal);
                int nuevaCantidadDisponible = cantidadDisponible - cantidad;
                txtCantidadDisponible.Text = nuevaCantidadDisponible.ToString();
            }
            else
            {
                MessageBox.Show("Cantidad no disponible.");
            }
        }
        private void agregarviewcolumnas()
        {
            dataGridViewProductosFactura.Columns.Add("Referencia", "Referencia");
            dataGridViewProductosFactura.Columns.Add("Nombre", "Nombre");
            dataGridViewProductosFactura.Columns.Add("Cantidad", "Cantidad");
            dataGridViewProductosFactura.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridViewProductosFactura.Columns.Add("PrecioTotal", "Precio Total");
        }
    }
}
