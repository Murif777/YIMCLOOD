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
    public partial class ConsultarEntrenador : Form
    {
        public event EventHandler OnRegresar;
        public ConsultarEntrenador()
        {
            InitializeComponent();
            Btnregresar.Click += new EventHandler(Btnregresar_Click);
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            OnRegresar?.Invoke(this, EventArgs.Empty);
        }
    }
}
