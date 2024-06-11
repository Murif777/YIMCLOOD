using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Controls.Primitives;
using System.Drawing.Text;
using MySqlX.XDevAPI.Relational;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Globalization;
using ENTITY;
using BILL;



namespace Presentacion
{
    public partial class UsuarioHistorial : Form
    {
        private Miembro miembro;
        private UsuarioMenuPrincipal _usuarioMenuPrincipal;
        private HistorialService HistorialService = new HistorialService();
        int month, year;
        public static int static_month,static_year;
        public UsuarioHistorial(UsuarioMenuPrincipal usuarioMenuPrincipal,Miembro miembro)
        {
            InitializeComponent();
            this.miembro = miembro;
            _usuarioMenuPrincipal = usuarioMenuPrincipal;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<Historial> historialesMiembro = HistorialService.ConsultarCed(miembro.Cedula);
            DateTime fechaActual = DateTime.Now.Date;
            var historialDelDia = historialesMiembro.FirstOrDefault(h => h.Fecha.Date == fechaActual);

            if (historialDelDia != null)
            {
                MessageBox.Show("Ya existe un historial registrado para hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _usuarioMenuPrincipal.Abrirformpanel(new UsuarioAgregarMedidas(miembro));
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void UsuarioHistorial_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            DisplayDaysForMonth(month, year);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            month--;
            DisplayDaysForMonth(month, year);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            month++;
            DisplayDaysForMonth(month, year);
        }

        private void DisplayDaysForMonth(int month, int year)
        {
            daycontainer.Controls.Clear();

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " | " + year;
            List<Historial> historialesMiembro = HistorialService.ConsultarCed(miembro.Cedula);

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(miembro);
                ucdays.days(i);

                DateTime fechaDia = new DateTime(year, month, i);
                var historialDelDia = historialesMiembro.FirstOrDefault(h => h.Fecha.Date == fechaDia.Date);
                if (historialDelDia != null)
                {
                    ucdays.peso(historialDelDia.Registro.Peso);
                    ucdays.ShowPesoLabels(true);
                    ucdays.CambiarColor(true);
                }
                else
                {
                    ucdays.ShowPesoLabels(false);
                }

                daycontainer.Controls.Add(ucdays);
            }
        }

    }
}