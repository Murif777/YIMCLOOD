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



namespace Presentacion
{
    public partial class UsuarioHistorial : Form
    {
        private Miembro miembro;
        int month, year;
        //CREATE A STATIC VARIABLE THAT WE CAN PASS TO ANOTHER FORM FOR MOTH AND YEAR
        public static int static_month,static_year;
        public UsuarioHistorial(Miembro miembro)
        {
            InitializeComponent();
            this.miembro = miembro;
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
            DateTime now= DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname=DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname+" | "+year;

            static_month = month;
            static_year = year;

            //GET FIRST DAY OF THE MONTH.
            DateTime startOfTheMonth = new DateTime(year,month,1);
            //GET THE COUNT OF DAYS OF THE MONTH.
            int days = DateTime.DaysInMonth(year,month);
            //CONVERT THE STARTOFTHEMONTH TO INTEGER
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //FIRST LESTS CREATE  BLANK USERCONTROL
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //NOW LETS CREATE USERCONTROL FOR DAYS
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays= new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }   
       

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //CLEAR CONTAINER
            daycontainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " | " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //GET THE COUNT OF DAYS OF THE MONTH.
            int days = DateTime.DaysInMonth(year, month);
            //CONVERT THE STARTOFTHEMONTH TO INTEGER
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //FIRST LESTS CREATE  BLANK USERCONTROL
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //NOW LETS CREATE USERCONTROL FOR DAYS
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //CLEAR CONTAINER
            daycontainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " | " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //GET THE COUNT OF DAYS OF THE MONTH.
            int days = DateTime.DaysInMonth(year, month);
            //CONVERT THE STARTOFTHEMONTH TO INTEGER
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            //FIRST LESTS CREATE  BLANK USERCONTROL
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //NOW LETS CREATE USERCONTROL FOR DAYS
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }
    }
}