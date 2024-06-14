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
    public partial class Reportes : Form
    {
        private MembresiaService membresiaService = new MembresiaService();
        private PMembresiaService PmembresiaService = new PMembresiaService();
        private ConexionService conexionService = new ConexionService();
        private FacturaService facturaService = new FacturaService();
        private EntrenadorService entrenadorService = new EntrenadorService();
        private MiembroService miembroService = new MiembroService();
        private DateTime fechainicio;
        private DateTime fechafinal;

        private string ReporteSeleccionado;
        private string MembresiaSeleccionado;
        private string filtroestado;
        private int Cantidad;
        private int Ingresos;

        private int CantidadProducto;
        private int IngresosProducto;

        private int CantidadMembresia;
        private int IngresosMembresia;
        public Reportes()
        {
            InitializeComponent();
            conexionService.prueba();
            ComboboxReportes();
            //filtroMiembro();
            groupBox1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
        }
        private void ComboboxReportes()
        {
            List<string> reportes = new List<string>
            {
                "Ninguno",
                "Todos los ingresos",
                "Membresias",
                "Productos",
                "Entrenadores",
                "Miembros"
            };

            cbReportes.DataSource= reportes;
            cbTipoReportes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ComboboxTipoReportes()
        {
            List<string> Tiporeportes = new List<string>
            {
                "Ninguno",
                "Hoy",
                "Ayer",
                "Esta semana",
                "Semana pasada",
                "Este mes",
                "Mes anterior",
                "Este año",
                "Año anterior"
            };
            cbTipoReportes.DataSource=(Tiporeportes);
            cbTipoReportes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CbTipoReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = cbTipoReportes.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);
            DateTime startOfLastWeek = startOfWeek.AddDays(-7);

            switch (seleccionado)
            {
                case "Hoy":
                    fechainicio = today;
                    fechafinal = today;
                    break;
                case "Ayer":
                    fechainicio = today.AddDays(-1);
                    fechafinal = today.AddDays(-1);
                    break;
                case "Esta semana":
                    fechainicio = startOfWeek;
                    fechafinal = startOfWeek.AddDays(6);
                    break;
                case "Semana pasada":
                    fechainicio = startOfLastWeek;
                    fechafinal = startOfLastWeek.AddDays(6);
                    break;
                case "Este mes":
                    fechainicio = new DateTime(today.Year, today.Month, 1);
                    fechafinal = fechainicio.AddMonths(1).AddDays(-1);
                    break;
                case "Mes pasado":
                    fechainicio = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
                    fechafinal = fechainicio.AddMonths(1).AddDays(-1);
                    break;
                case "Este año":
                    fechainicio = new DateTime(today.Year, 1, 1);
                    fechafinal = new DateTime(today.Year, 12, 31);
                    break;
                case "Año pasado":
                    fechainicio = new DateTime(today.Year - 1, 1, 1);
                    fechafinal = new DateTime(today.Year - 1, 12, 31);
                    break;
                default:
                    // Aquí puedes manejar el caso por defecto si es necesario
                    break;
            }

            // Si el reporte seleccionado es "Miembros", actualiza la tabla de miembros
            if (ReporteSeleccionado == "Miembros")
            {
                mostrarTablaMiembro();
            }
            // Si el reporte seleccionado es "Membresias", actualiza la tabla de membresías
            else if (ReporteSeleccionado == "Membresias")
            {
                mostrarTablaMembresias();
            }
            fechafinal = DateTime.Today;
            fechainicio = DateTime.Today;
        }

        private void mostrarTablaEntrenadores()
        {
            dataGridView1.DataSource = null;
            var listaEntrenadores = entrenadorService.Consultar();
            var entrenadoresFiltrados = listaEntrenadores;
            if (fechainicio != DateTime.MinValue && fechafinal != DateTime.MaxValue && ReporteSeleccionado != "Ninguno")
            {
                entrenadoresFiltrados = listaEntrenadores
                    .Where(p => p.FechaNacimiento >= fechainicio && p.FechaNacimiento <= fechafinal)
                    .ToList();
            }
            if (listaEntrenadores != null && listaEntrenadores.Count > 0)
            {
                var viewList = listaEntrenadores.Select(p => new
                {
                    Cedula = p.Cedula,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Correo = p.Correo,
                    Telefono = p.Telefono,
                }).ToList();
                Cantidad=listaEntrenadores.Count;
                dataGridView1.DataSource = viewList;

                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Cedula"].DisplayIndex = 0;
                dataGridView1.Columns["Nombre"].DisplayIndex = 1;
                dataGridView1.Columns["Apellido"].DisplayIndex = 2;
                dataGridView1.Columns["Correo"].DisplayIndex = 3;
                dataGridView1.Columns["Telefono"].DisplayIndex = 4;
                lblCantidad.Text = Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("Lista vacía");
            }
        }
        private void mostrarTablaProductos()
        {
            dataGridView1.DataSource = null;
            var facturas = facturaService.ConsultarTodo();

            List<Producto> productos = new List<Producto>();
            var facturasFiltrados = facturas;
            if (fechainicio != DateTime.MinValue && fechafinal != DateTime.MaxValue && ReporteSeleccionado!="Ninguno")
            {
                facturasFiltrados = facturas
                    .Where(p => p.FechaFactura >= fechainicio && p.FechaFactura <= fechafinal)
                    .ToList();
            }
            foreach (var factura in facturasFiltrados)
            {
                foreach (var producto in factura.Productos)
                {
                    productos.Add(producto);
                }
            }
            
            if (productos != null && productos.Count > 0)
            {
                var viewList = productos.Select(p => new
                {
                    Referencia = p.Referencia,
                    Nombre = p.Nombre,
                    Precio = p.Valor,
                    Cantidad = p.CantidadDisponible,
                }).ToList();
                Cantidad = productos.Count;
                Ingresos = productos.Sum(p => p.Valor);
                dataGridView1.DataSource = viewList;
                // Configurar las columnas para mostrar en el orden deseado
                dataGridView1.Columns["Referencia"].DisplayIndex = 0;
                dataGridView1.Columns["Nombre"].DisplayIndex = 1;
                dataGridView1.Columns["Precio"].DisplayIndex = 2;
                dataGridView1.Columns["Cantidad"].DisplayIndex = 3;
                lblCantidad.Text = Cantidad.ToString();
                lblIngresos.Text = Ingresos.ToString();
                
            }
            else
            {
                MessageBox.Show("Lista vacía");
            }
        }
        private void mostrarTablaMembresias()
        {
            dataGridView1.DataSource = null;
            var perfiles = PmembresiaService.consultartodo();
            if (perfiles != null && perfiles.Count > 0)
            {
                var perfilesFiltrados = perfiles;

                if (!string.IsNullOrEmpty(MembresiaSeleccionado) && MembresiaSeleccionado != "Todo")
                {
                    perfilesFiltrados = perfilesFiltrados.Where(p => p.TipoMembresia.Nombre == MembresiaSeleccionado).ToList();
                }
                if (fechainicio != DateTime.MinValue && fechafinal != DateTime.MaxValue && ReporteSeleccionado != "Ninguno")
                {
                    perfilesFiltrados = perfilesFiltrados
                        .Where(p => p.Fechainicio >= fechainicio && p.Fechainicio <= fechafinal)
                        .ToList();
                }
                // Agrupar por nombre de membresía y calcular la cantidad y el valor total
                var agrupados = perfilesFiltrados
                    .GroupBy(p => p.TipoMembresia.Nombre)
                    .Select(g => new
                    {
                        Membresia = g.Key,
                        Cantidad = g.Count(),
                        Valor = g.Count() * g.First().TipoMembresia.Valor
                    })
                    .ToList();

                Cantidad = perfilesFiltrados.Count;
                Ingresos = perfilesFiltrados.Sum(p => p.TipoMembresia.Valor);
                if (agrupados.Count > 0)
                {
                    dataGridView1.DataSource = agrupados;
                    dataGridView1.Columns["Membresia"].DisplayIndex = 0;
                    dataGridView1.Columns["Cantidad"].DisplayIndex = 1;
                    dataGridView1.Columns["Valor"].DisplayIndex = 2;
                    lblCantidad.Text = Cantidad.ToString();
                    lblIngresos.Text = Ingresos.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros que coincidan con el filtro.");
                }
            }
            else
            {
                MessageBox.Show("Lista vacía");
            }
        }

        private void mostrarTablaMiembro()
        {
            dataGridView1.DataSource = null;
            var perfiles = PmembresiaService.consultartodo();
            if (perfiles != null && perfiles.Count > 0)
            {
                var perfilesFiltrados = perfiles;

                switch (filtroestado)
                {
                    case "Activos":
                        perfilesFiltrados = perfiles.Where(p => p.Estado == "Activo").ToList();
                        break;
                    case "Inactivos":
                        perfilesFiltrados = perfiles.Where(p => p.Estado == "Inactivo").ToList();
                        break;
                    case "Deudores":
                        perfilesFiltrados = perfiles.Where(p => p.SaldoDebe > 0).ToList();
                        break;
                    case "Pronta a acabar":
                        perfilesFiltrados = perfiles.Where(p => (p.Fechafinal - DateTime.Today).Days <= 7).ToList();
                        break;
                    default:
                        perfilesFiltrados = perfiles;
                        break;

                }
                if (fechainicio != DateTime.MinValue && fechafinal != DateTime.MaxValue && ReporteSeleccionado != "Ninguno")
                {
                    perfilesFiltrados = perfilesFiltrados
                        .Where(p => p.Fechainicio >= fechainicio && p.Fechainicio <= fechafinal)
                        .ToList();
                }
                Cantidad = perfilesFiltrados.Count;
                if (perfilesFiltrados.Count > 0)
                {
                    var viewList = perfilesFiltrados.Select(p => new
                    {
                        Cedula = p.DatosUsuario.DatosMiembro.Cedula,
                        Nombre = p.DatosUsuario.DatosMiembro.Nombre,
                        Apellido = p.DatosUsuario.DatosMiembro.Apellido,
                        Correo = p.DatosUsuario.DatosMiembro.Correo,
                        Telefono = p.DatosUsuario.DatosMiembro.Telefono,
                        Membresia = p.TipoMembresia.Nombre,
                        Estado = p.Estado,
                        SaldoDebe = p.SaldoDebe,
                        FechaInicio = p.Fechainicio,
                        FechaFinal = p.Fechafinal,
                    }).ToList();

                    dataGridView1.DataSource = viewList;
                    dataGridView1.Columns["Cedula"].DisplayIndex = 0;
                    dataGridView1.Columns["Nombre"].DisplayIndex = 1;
                    dataGridView1.Columns["Apellido"].DisplayIndex = 2;
                    dataGridView1.Columns["Correo"].DisplayIndex = 3;
                    dataGridView1.Columns["Telefono"].DisplayIndex = 4;
                    dataGridView1.Columns["Membresia"].DisplayIndex = 5;
                    dataGridView1.Columns["Estado"].DisplayIndex = 6;
                    dataGridView1.Columns["SaldoDebe"].DisplayIndex = 7;
                    dataGridView1.Columns["FechaInicio"].DisplayIndex = 8;
                    dataGridView1.Columns["FechaFinal"].DisplayIndex = 9;
                    lblCantidad.Text = Cantidad.ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron registros que coincidan con el filtro.");
                }
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }

        private void filtroMiembro()
        {
            if (rbActivos.Checked)
            {
                filtroestado = "Activos";
            }
            if (rbInactivos.Checked)
            {
                filtroestado = "Inactivos";

            }
            if (rbMora.Checked)
            {
                filtroestado = "Deudores";

            }
            if (rbInactivos.Checked)
            {
                filtroestado = "Pronta a acabar";

            }
        }
        private void CargarMembresias()
        {
            List<Membresia> membresias = membresiaService.ConsultarTodo();

            if (membresias == null)
            {
                MessageBox.Show("Lista vacía");
            }
            else
            {
                membresias.Insert(0, new Membresia { Nombre = "Todo" });
                cbMembresias.DropDownStyle = ComboBoxStyle.DropDownList;
                cbMembresias.DataSource = membresias;
                cbMembresias.DisplayMember = "Nombre";
            }
        }
        private void CbMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            MembresiaSeleccionado = cbMembresias.SelectedItem.ToString();
            mostrarTablaMembresias();
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            filtroMiembro();
            mostrarTablaMiembro();

        }

        private void CbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxTipoReportes();
            ReporteSeleccionado = cbReportes.SelectedItem.ToString();

            switch (ReporteSeleccionado)
            {
                case "Todos los ingresos":
                    MessageBox.Show("Seleccione imprimir para ver los ingresos totales");
                    break;
                case "Membresias":
                    cbMembresias.Visible = true;
                    groupBox1.Visible = false;
                    
                    CargarMembresias();
                    mostrarTablaMembresias();
                    break;
                case "Productos":
                    groupBox1.Visible = false;
                    cbMembresias.Visible = false;
                    lblCantidad.Text = Cantidad.ToString();
                    lblIngresos.Text = Ingresos.ToString();
                    mostrarTablaProductos();
                    break;
                case "Entrenadores":
                    cbMembresias.Visible = false;
                    groupBox1.Visible = false;
                    lblCantidad.Text = Cantidad.ToString();
                    lblIngresos.Visible = false;

                    mostrarTablaEntrenadores();
                    break;
                case "Miembros":
                    cbMembresias.Visible = false;
                    lblCantidad.Text = Cantidad.ToString();
                    lblIngresos.Visible = false;
                    groupBox1.Visible = true;
                    mostrarTablaMiembro();
                    break;
                default:
                    break;
            }
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            fechainicio = dtFechaInicio.Value;
            fechafinal = dtFechaFinal.Value;

            // Llamar al método correspondiente para mostrar los datos según el reporte seleccionado
            switch (ReporteSeleccionado)
            {
                case "Membresias":
                    mostrarTablaMembresias();
                    break;
                case "Miembros":
                    mostrarTablaMiembro();
                    break;
                case "Productos":
                    mostrarTablaProductos();
                    break;
                case "Entrenadores":
                    mostrarTablaEntrenadores();
                    break;
                default:
                    break;
            }

            // Resetear los valores de fecha a hoy después de actualizar los datos
            fechafinal = DateTime.Today;
            fechainicio = DateTime.Today;
        }
        private void generarPDF()
        {
           Factura factura = new Factura();
            factura.FechaFactura =DateTime.Today;
            factura.
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                facturaService.GenerarYEnviarPDFReporte( guardar.FileName);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
