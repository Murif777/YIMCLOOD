using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ConsultarMiembro : Form
    {
        private PMembresiaService PMembresiaService = new PMembresiaService();
        public event EventHandler OnRegresar;
        private MiembroService miembroService = new MiembroService();
        private List<Miembro> listaMiembros;


        public ConsultarMiembro()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            MostrarTabla();
            pnlActualizar.Visible = false;
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
                    Correo = p.DatosUsuario.DatosMiembro.Correo,
                    Telefono = p.DatosUsuario.DatosMiembro.Telefono,
                    Sexo = p.DatosUsuario.DatosMiembro.Sexo,
                    FechaNacimiento = p.DatosUsuario.DatosMiembro.FechaNacimiento,
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
                dataGridView1.Columns["Telefono"].DisplayIndex = 5;
                dataGridView1.Columns["Sexo"].DisplayIndex = 6;
                dataGridView1.Columns["FechaNacimiento"].DisplayIndex = 7;
                dataGridView1.Columns["Membresia"].DisplayIndex = 8;
                dataGridView1.Columns["Estado"].DisplayIndex = 9;
                dataGridView1.Columns["SaldoDebe"].DisplayIndex = 10;
                dataGridView1.Columns["FechaInicio"].DisplayIndex = 11;
                dataGridView1.Columns["FechaFinal"].DisplayIndex = 12;
                dataGridView1.Columns["DuracionAcumulada"].DisplayIndex = 13;
                dataGridView1.Columns["TiempoRestante"].DisplayIndex = 14;
                dataGridView1.Columns["Pagado"].DisplayIndex = 15;

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
        private PerfilMembresia AsignaciondeValores()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string cedula = selectedRow.Cells["Cedula"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string telefono = selectedRow.Cells["Telefono"].Value.ToString();
                string correo = selectedRow.Cells["Correo"].Value.ToString();
                string fechanacimiento = selectedRow.Cells["FechaNacimiento"].Value.ToString();
                string sexo = selectedRow.Cells["Sexo"].Value.ToString();
                byte[] foto = (byte[])selectedRow.Cells["Foto"].Value;
                string nombreMembresia = selectedRow.Cells["Membresia"].Value.ToString();
                string fechafinal = selectedRow.Cells["FechaNacimiento"].Value.ToString();
                Miembro miembro = new Miembro();

                miembro.Cedula = cedula;
                miembro.Nombre = nombre;
                miembro.Apellido = apellido;
                miembro.Telefono = telefono;
                miembro.Correo = correo;
                miembro.FechaNacimiento = Convert.ToDateTime(fechanacimiento);
                miembro.Sexo = sexo;
                miembro.Foto = foto;

                Membresia membresia = new Membresia();
                membresia.Nombre = nombreMembresia;

                Usuario usuario = new Usuario();
                usuario.DatosMiembro = miembro;
                PerfilMembresia perfil = new PerfilMembresia();

                perfil.DatosUsuario = usuario;
                perfil.TipoMembresia = membresia;
                perfil.Fechafinal = Convert.ToDateTime(fechafinal);
                return perfil;
            }
            MessageBox.Show("Seleccione un usuario de la tabla");
            return null; 
        }
        private void Abrirformpanel(Form formHijo)
        {
            if (this.pnlActualizar.Controls.Count > 0)
                this.pnlActualizar.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del panel
            formHijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Ancla el formulario al panel
            this.pnlActualizar.Controls.Add(formHijo);
            this.pnlActualizar.Tag = formHijo;
            formHijo.Show();

            if (formHijo is Registrar)
            {
                Registrar registrarForm = (Registrar)formHijo;
                registrarForm.btnRegistrar.Visible = false;
                registrarForm.Btnregresar.Visible = false;
                registrarForm.btnActualizar.Visible = true;
                registrarForm.Asignar_Campos();
            }
        }

        private void FormActualizar()
        {
            PerfilMembresia miembro = AsignaciondeValores();
            if (miembro != null)
            {
                pnlActualizar.Visible = true;
                Registrar registrar = new Registrar(miembro);
                Abrirformpanel(registrar);
            }
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectrow = dataGridView1.SelectedRows[0];
                try
                {
                    string cedulaMiembro = selectrow.Cells[1].Value.ToString();

                    // Mostrar mensaje de confirmación
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este miembro?",
                                                                "Confirmación de eliminación",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Eliminar miembro
                        string resultadoEliminacion = miembroService.EliminarMiembro(cedulaMiembro);
                        MessageBox.Show(resultadoEliminacion);

                        // Actualizar el DataGridView después de la eliminación
                        MostrarBusqueda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el miembro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un dato de la tabla");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FormActualizar();
        }
        private void ConsultarMiembro_Click(object sender, EventArgs e)
        {
            this.pnlActualizar.Visible=false;
        }
    }
}
