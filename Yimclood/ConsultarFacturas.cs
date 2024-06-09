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
    public partial class ConsultarFacturas : Form

    {

        private FacturaService FacturaService = new FacturaService();
        public event EventHandler OnRegresar;
        public ConsultarFacturas()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            TablaFacturas.SelectionChanged += new EventHandler(DataGridViewFacturas_SelectionChanged);
            MostrarTablaFacturas();
            pnlProductos.Visible= false;
        }
        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
        private void MostrarTablaFacturas()
        {
            List<Factura> facturas = null;
            if (txtCedula.Text=="")
            {
               facturas  = FacturaService.ConsultarTodo();

            }
            else
            {
                string cedula = txtCedula.Text;
                facturas = FacturaService.ConsultarCed(cedula);
            }
            if (facturas != null && facturas.Count > 0)
            {
                var viewList = facturas.Select(p => new
                {
                    Id = p.Id,
                    Nombre = p.Miembro.Nombre,
                    Apellido= p.Miembro.Apellido,
                    Fecha_Factura = p.FechaFactura,
                    Coste_Total = p.Precio_Total
                }).ToList();
                TablaFacturas.DataSource = viewList;
                TablaFacturas.Columns["Id"].DisplayIndex = 0;
                TablaFacturas.Columns["Nombre"].DisplayIndex = 1;
                TablaFacturas.Columns["Apellido"].DisplayIndex = 2;
                TablaFacturas.Columns["Fecha_Factura"].DisplayIndex = 3;
                TablaFacturas.Columns["Coste_Total"].DisplayIndex = 4;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario");
            }
        }
        private void MostrarProductosDeFactura(int facturaId)
        {
            var factura = FacturaService.ConsultarTodo().FirstOrDefault(f => f.Id == facturaId);

            if (factura != null)
            {
                var viewList = factura.Productos.Select(p => new
                {
                    Foto = p.Foto,
                    Referencia = p.Referencia,
                    Nombre = p.Nombre,
                    Precio = p.Valor,
                    Cantidad = p.CantidadDisponible,
                }).ToList();

                TablaProductos.DataSource = viewList;
                // Configurar las columnas para mostrar en el orden deseado
                TablaProductos.Columns["Foto"].DisplayIndex = 0;
                TablaProductos.Columns["Referencia"].DisplayIndex = 1;
                TablaProductos.Columns["Nombre"].DisplayIndex = 2;
                TablaProductos.Columns["Precio"].DisplayIndex = 3;
                TablaProductos.Columns["Cantidad"].DisplayIndex = 4;
                // Ajustar la altura de las filas para mostrar correctamente las imágenes
                foreach (DataGridViewRow row in TablaProductos.Rows)
                {
                    row.Height = 100; // Establece la altura deseada para cada fila
                }
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)TablaProductos.Columns["Foto"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            else
            {
                MessageBox.Show("No se encontraron productos para la factura seleccionada.");
            }
        }



        private void DataGridViewFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (TablaFacturas.SelectedRows.Count > 0)
            {
                int facturaId = (int)TablaFacturas.SelectedRows[0].Cells["Id"].Value;
                pnlProductos.Visible = true;
                MostrarProductosDeFactura(facturaId);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarTablaFacturas();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            MostrarTablaFacturas();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible =false;
        }
    }
}
