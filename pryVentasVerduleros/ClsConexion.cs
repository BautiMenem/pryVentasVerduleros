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
        OleDbDataReader rdrVendedor;
        OleDbDataReader rdrProducto;
        
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
                cnn.Open();
                rdrVendedor = cmdVendedor.ExecuteReader();
                rdrProducto = cmdProducto.ExecuteReader();

                lstVendedor.Items.Clear();
                lstProducto.Items.Clear();

                DataTable dtVendedor = new DataTable();
                DataTable dtProducto = new DataTable();

                if (rdrVendedor.HasRows)
                {
                    dtVendedor.Load(rdrVendedor);
                    lstVendedor.DataSource = dtVendedor;
                    lstVendedor.ValueMember = "IdVendedor";
                    lstVendedor.DisplayMember = "NombreVendedor";
                }

                if (rdrProducto.HasRows)
                {
                    dtProducto.Load(rdrProducto);
                    lstProducto.DataSource = dtProducto;
                    lstProducto.ValueMember = "IdProducto";
                    lstProducto.DisplayMember = "NomProducto";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }


        public void Insertardatos(int idVendedor, int idProducto, DateTime Fecha, int Kilos)
        {
             string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";
            string sql = "INSERT INTO Ventas ([Cod Vendedor], [Cod Producto], Fecha, Kilos) VALUES (@vendedor, @producto, @fechaventa, @cantidad)";
            try 
            {
                cnn = new OleDbConnection(conexion);
                cmdVendedor = new OleDbCommand();
                cmdVendedor.Connection = cnn;
                cmdVendedor.Connection.Open();
                cmdVendedor.CommandType = CommandType.Text;
                cmdVendedor.CommandText = sql;
                string FechaString = Fecha.ToShortDateString();
                cmdVendedor.Parameters.AddWithValue("@vendedor", idVendedor);
                cmdVendedor.Parameters.AddWithValue("@producto", idProducto);
                cmdVendedor.Parameters.AddWithValue("@fechaventa", FechaString);
                cmdVendedor.Parameters.AddWithValue("@cantidad", Kilos);

                
                cmdVendedor.ExecuteNonQuery();





            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }

        }
        
       
    }
}
