using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Presentacion
{
    public partial class UserControlDays : UserControl
    {
        //CREATE ANOTHER STATIC VARIABLE FOR DAYS;
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }
        public void days(int numday)
        {
            lbldays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day=lbldays.Text;
            UsuarioConsultarMedidas usuarioConsultarMedidas =new UsuarioConsultarMedidas();
            usuarioConsultarMedidas.Show();
        }
        //CREATE A NEW METHOD TO DISPLAY EXERCISE
        private void displayEvent()
        {
            //CONSULTAR TABLA REGISTRO FILTRADO POR EL DATO DEL REGISTRO "DateTime Fecha", QUE COINCIDA CON LOS DATOS DE ABAJO
            //(UsuarioHistorial.static_year,UsuarioHistorial.static_month,UserControlDays.static_day)
            //https://www.youtube.com/watch?v=6W6DpEkghoQ&list=PLKi6cAy1kMqi5NOu0d-rohbgAv1O82vuO&index=3&ab_channel=CodingIdeas


        }
    }
}
