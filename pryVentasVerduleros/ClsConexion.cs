using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVentasVerduleros
{
    internal class ClsConexion
    {
        OleDbConnection cnn;
        OleDbCommand cmdVendedor;
        OleDbCommand cmdProducto;
        OleDbCommand cmdVentas;
        OleDbDataReader rdrVendedor;
        OleDbDataReader rdrProducto;
        OleDbDataReader rdrVentas;
        

        public void CargarDatos(ComboBox lstProducto, ComboBox lstVendedor)
        {
            string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";
            lstProducto.SelectedIndex = -1;
            lstVendedor.SelectedIndex = -1;
            try
            {
                cnn = new OleDbConnection(conexion);
                cmdVendedor = new OleDbCommand();
                cmdVendedor.Connection = cnn;
                cmdVendedor.CommandType = CommandType.TableDirect;
                cmdVendedor.CommandText = "Vendedores";
                cmdProducto = new OleDbCommand();
                cmdProducto.Connection = cnn;
                cmdProducto.CommandType = CommandType.TableDirect;
                cmdProducto.CommandText = "Productos";
                cmdVentas = new OleDbCommand();
                cmdVentas.Connection = cnn;
                cmdVentas.CommandType = CommandType.TableDirect;
                cmdVentas.CommandText = "Ventas";
                cnn.Open();
                rdrVendedor = cmdVendedor.ExecuteReader();
                rdrProducto = cmdProducto.ExecuteReader();
                rdrVentas = cmdVentas.ExecuteReader();

                HashSet<string> Vendedores = new HashSet<string>();
                HashSet<string> Productos = new HashSet<string>();


                while (rdrVendedor.Read())
                {
                    string Vendedor = rdrVendedor[1].ToString();
                    Vendedores.Add(Vendedor);
                }

                while (rdrProducto.Read())
                {
                    string Producto = rdrProducto[1].ToString();
                    Productos.Add(Producto);
                }

                lstProducto.Items.AddRange(Productos.ToArray());
                lstVendedor.Items.AddRange(Vendedores.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }
    }
}
