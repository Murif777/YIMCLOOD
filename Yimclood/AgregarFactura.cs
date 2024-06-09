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
        private ProductoService productoService = new ProductoService();
        private List<Producto> productosSeleccionados = new List<Producto>();
        private Miembro miembroSeleccionado;
        private bool productosNoGuardados = false;
        private FacturaService facturaService = new FacturaService();


        public AgregarFactura()
        {
            InitializeComponent();
            MostrarTablaMiembros();
            this.Load += new EventHandler(Form1_Load);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            comboBoxProductos.SelectedIndexChanged += new EventHandler(comboBoxProductos_SelectedIndexChanged);
            numericUpDownCantidad.ValueChanged += new EventHandler(numericUpDownCantidad_ValueChanged);
           //btnAgregarProducto.Click += new EventHandler(btnAgregarProducto_Click);
        }


        private void MostrarTablaMiembros()
        {
            List<PerfilMembresia> perfiles=null;
            if (txtCedula.Text == "")
            {
                perfiles = PMembresiaService.consultartodo();
            }
            else
            {
                string cedula = txtCedula.Text;
                perfiles = PMembresiaService.ConsultarCed(cedula);
            }
            
            if (perfiles != null && perfiles.Count > 0)
            {
                var viewList = perfiles.Select(p => new
                {
                    Foto = p.DatosUsuario.DatosMiembro.Foto,
                    Cedula = p.DatosUsuario.DatosMiembro.Cedula,
                    Nombre = p.DatosUsuario.DatosMiembro.Nombre,
                    Apellido = p.DatosUsuario.DatosMiembro.Apellido,
                    Correo = p.DatosUsuario.DatosMiembro.Correo,
                }).ToList();

                dataGridView1.DataSource = viewList;

                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Foto"].DisplayIndex = 0;
                dataGridView1.Columns["Cedula"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Apellido"].DisplayIndex = 3;
                dataGridView1.Columns["Correo"].DisplayIndex = 4;
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }
        private void MostrarTablaProductos()
        {
            string referencia = comboBoxProductos.SelectedValue.ToString();
            List<Producto> productos = productoService.ConsultarRef(referencia);
            Producto productoSeleccionado = productos.First();

            // Modificar la cantidad del producto seleccionado
            productoSeleccionado.CantidadDisponible = (int)numericUpDownCantidad.Value;

            // Modificar el valor total del producto multiplicando su valor unitario por la cantidad
            productoSeleccionado.Valor = productoSeleccionado.Valor * productoSeleccionado.CantidadDisponible;

            // Agregar el producto modificado a la lista de productos seleccionados
            productosSeleccionados.Add(productoSeleccionado);
            productosNoGuardados = true; // Marcar como no guardado cuando se añade un producto
            if (productosSeleccionados != null && productosSeleccionados.Count > 0)
                {
                    var viewList = productosSeleccionados.Select(p => new
                    {
                        Foto = p.Foto,
                        Referencia = p.Referencia,
                        Nombre = p.Nombre,
                        Precio = p.Valor,
                        Cantidad =p.CantidadDisponible
                    }).ToList();
                    dataGridView2.DataSource = viewList;
                    // Configurar las columnas para mostrar en el orden deseado
                    dataGridView2.Columns["Foto"].DisplayIndex = 0;
                    dataGridView2.Columns["Referencia"].DisplayIndex = 1;
                    dataGridView2.Columns["Nombre"].DisplayIndex = 2;
                    dataGridView2.Columns["Precio"].DisplayIndex = 3;
                    dataGridView2.Columns["Cantidad"].DisplayIndex = 4;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }

        }
        private void GenerarFactura()
        {
            Factura factura = new Factura();

            if (miembroSeleccionado != null)
            {
                factura.Miembro = miembroSeleccionado;
            }
            else
            {
                MessageBox.Show("No hay miembro seleccionado.");
                return;
            }
            factura.FechaFactura=DateTime.Now;
            factura.Productos = productosSeleccionados;
            double precioTotal = productosSeleccionados.Sum(p => p.Valor);
            factura.Precio_Total = precioTotal;
            Console.WriteLine(factura.FechaFactura.ToString(), factura.Precio_Total);
            facturaService.RegistrarFacturaProducto(factura);
            actualizarBD();
            limpiarcampos();
        }
        private void actualizarBD()
        {
            foreach (var producto in productosSeleccionados)
            {
                int cantidadDisponibleActual =int.Parse( productoService.ObtenerCantidadDisponiblePorReferencia(producto.Referencia));
                int nuevaCantidadDisponible = cantidadDisponibleActual - producto.CantidadDisponible;
                producto.CantidadDisponible = nuevaCantidadDisponible;
                productoService.ActualizarCantidadDisponible(producto);
            }
        }


        private void limpiarcampos()
        {
            comboBoxProductos.SelectedIndex = 0;
            productosSeleccionados.Clear();
            productosNoGuardados = false;
            dataGridView2.DataSource = null;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (productosNoGuardados)
            {
                var result = MessageBox.Show("Tiene productos seleccionados que no han sido guardados. ¿Está seguro que desea cambiar de miembro y perder los productos seleccionados?", "Confirmar cambio de miembro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    // Cancelar la selección y mantener la selección anterior
                    dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
                    dataGridView1.ClearSelection();
                    dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
                    return;
                }
                else
                {
                    // Borrar la lista de productos seleccionados
                    productosSeleccionados.Clear();
                    productosNoGuardados = false;
                    dataGridView2.DataSource = null; // Actualizar la tabla de productos seleccionados
                }
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LlenarComboBoxProductos();
                comboBoxProductos.Enabled = true;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                miembroSeleccionado = new Miembro(
                    selectedRow.Cells["Cedula"].Value.ToString(),
                    selectedRow.Cells["Nombre"].Value.ToString(),
                    selectedRow.Cells["Apellido"].Value.ToString(),
                    "", // Suponiendo que no tienes el teléfono en el DataGridView
                    "", // Suponiendo que no tienes el sexo en el DataGridView
                    selectedRow.Cells["Correo"].Value.ToString(),
                    DateTime.MinValue, // Suponiendo que no tienes la fecha de nacimiento en el DataGridView
                    0, // Suponiendo que no tienes el peso en el DataGridView
                    0, // Suponiendo que no tienes la estatura en el DataGridView
                    selectedRow.Cells["Foto"].Value as byte[]
                );

            }
            else
            {
                comboBoxProductos.DataSource = null;
                comboBoxProductos.Enabled = false;
            }

        }
        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            GenerarFactura();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            MostrarTablaProductos();
            Console.WriteLine("precio:"+lblPrecioTotal.Text);
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            MostrarTablaMiembros();

        }
        private void LlenarComboBoxProductos()
        {
            var productos = productoService.Consultar();
            if (productos != null && productos.Count > 0)
            {
                //productos.Insert(0, new Producto { Nombre = "Ninguno" });
                comboBoxProductos.DataSource = productos;
                comboBoxProductos.DisplayMember = "Nombre";  
                comboBoxProductos.ValueMember = "Referencia";
                comboBoxProductos.DropDownStyle = ComboBoxStyle.DropDownList; // Hacer que el ComboBox sea solo de selección
                comboBoxProductos.SelectedIndex = 0; // Seleccionar "Ninguno" por defecto

            }
            else
            {
                MessageBox.Show("No hay productos disponibles.");
            }
        }
        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem != null )
            {
                string referenciaProducto = comboBoxProductos.SelectedValue.ToString();

                string cantidadDisponible = productoService.ObtenerCantidadDisponiblePorReferencia(referenciaProducto);
                lblCantidadDisp.Text = cantidadDisponible;

                string precioUnitario = productoService.ObtenerPrecioUnitarioPorReferencia(referenciaProducto);
                numericUpDownCantidad.Maximum = int.Parse(cantidadDisponible);
                numericUpDownCantidad.Value= 0;
                lblPrecioUnitario.Text = precioUnitario;
                CalcularPrecioTotal();
            }
        }
        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }
        private void CalcularPrecioTotal()
        {
            if (comboBoxProductos.SelectedItem != null && decimal.TryParse(lblPrecioUnitario.Text, out decimal precioUnitario))
            {
                int cantidad = (int)numericUpDownCantidad.Value;
                decimal precioTotal = precioUnitario * cantidad;
                lblPrecioTotal.Text = precioTotal.ToString("F2"); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProductos.Enabled = false; 
            LlenarComboBoxProductos();
        }


    }
}
