using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVentasVerduleros
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClsConexion objClase = new ClsConexion();
            objClase.CargarDatos1(lstVendedor);
        }

        private void lstVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
