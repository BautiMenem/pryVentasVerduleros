using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            objClase.CargarDatos(lstProducto, lstVendedor);
        }

        private void lstVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ClsConexion objClase = new ClsConexion();
            objClase.Insertardatos(Convert.ToInt32(lstVendedor.SelectedValue), Convert.ToInt32(lstProducto.SelectedValue), dtpFecha.Value, Convert.ToInt32(txtKilos.Text));
            MessageBox.Show("Venta registrada!", "", MessageBoxButtons.OK);
        }
    }
}
