using Grupo1.Controlador;
using Grupo1.Modelos;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Grupo1.Form3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Grupo1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int id = int.Parse(txtBox_id.Text);


            string nombreProducto = BuscarNombreProducto(id);

            textBox_nombreProducto.Text = nombreProducto;



        }

        private string BuscarNombreProducto(int id)
        {
            string nombreProducto = "";

            try
            {
                string server = "localhost";
                string database = "mydb";
                string user = "root";
                string pass = "";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";" + "pwd=" + pass + ";";

                using (MySqlConnection myCon = new MySqlConnection(cadenaConexion))
                {
                    myCon.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM indumentaria WHERE id = @id", myCon))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombreProducto = reader.GetString("nombre");
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de conexion: " + error.Message, "Error");
            }

            return nombreProducto;
        }


        private int BuscarStockProducto(int id)
        {
            int stockProducto = 0;
            try
            {
                string server = "localhost";
                string database = "mydb";
                string user = "root";
                string pass = "";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";" + "pwd=" + pass + ";";

                using (MySqlConnection myCon = new MySqlConnection(cadenaConexion))
                {
                    myCon.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT stock FROM indumentaria WHERE id = @id", myCon))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stockProducto = reader.GetInt32("stock");
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de conexion: " + error.Message, "Error");
            }

            return stockProducto;
        }




        Ventas_Controlador ventaController = new Ventas_Controlador();

        private double BuscarPrecioProducto(int id)
        {
            double precioProducto = 0;

            try
            {
                string server = "localhost";
                string database = "mydb";
                string user = "root";
                string pass = "";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";" + "pwd=" + pass + ";";

                using (MySqlConnection myCon = new MySqlConnection(cadenaConexion))
                {
                    myCon.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT precio FROM indumentaria WHERE id = @id", myCon))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                precioProducto = reader.GetDouble("precio");
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de conexion: " + error.Message, "Error");
            }

            return precioProducto;
        }




        private double totalVenta = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBox_id.Text);
            string nombreProducto = BuscarNombreProducto(id);
            double precioProducto = BuscarPrecioProducto(id);
            int stockProducto = BuscarStockProducto(id);

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = id;
            fila.Cells[1].Value = nombreProducto;
            fila.Cells[2].Value = precioProducto;
            fila.Cells[3].Value = numericCant.Value;
            fila.Cells[4].Value = "x";

            dataGridView1.Rows.Add(fila);

            double subtotal = precioProducto * (int)numericCant.Value;
            totalVenta += subtotal;
            txtTotal.Text = totalVenta.ToString();


            RecalcularTotal();
        }




        private void numericCant_ValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txtBox_id.Text);
            int stockProducto = BuscarStockProducto(id);

            if (numericCant.Value > stockProducto)
            {
                MessageBox.Show("No hay suficiente stock para esa cantidad", "Error");
                numericCant.Value = stockProducto;
            }
            else
            {



                int rowIndex = -1;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) == id)
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }


                if (rowIndex != -1)
                {
                    dataGridView1.Rows[rowIndex].Cells[3].Value = stockProducto - (int)numericCant.Value;

                }
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecalcularTotal()
        {
           double total = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double precio = Convert.ToDouble(row.Cells["precio"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                total += precio * cantidad;
            }

            txtTotal.Text = total.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            try
            {
                string server = "localhost";
                string database = "mydb";
                string user = "root";
                string pass = "";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";" + ";pwd=" + pass + ";";

                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();


                string usuario = GlobalVariables.Usuario;
                int usuarioid = 0;
                using (MySqlCommand cmd2 = new MySqlCommand("SELECT id FROM cliente WHERE usuario = @usuario", myCon))
                {
                    cmd2.Parameters.AddWithValue("@usuario", usuario);
                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioid = reader.GetInt32(0);
                        }
                    }
                }

                MySqlCommand cmd = new MySqlCommand("SELECT MAX(idventas) FROM ventas", myCon);
                int lastId = Convert.ToInt32(cmd.ExecuteScalar());

                Venta venta_nueva = new Venta();
                venta_nueva.Id = lastId + 1;
                venta_nueva.Cliente_id = usuarioid;
                venta_nueva.Fecha = (txtBox_fecha.Text);
                venta_nueva.Total = double.Parse(txtTotal.Text);
                ventaController.crearVenta(venta_nueva);

                string path = @"C:\Users\bruno\OneDrive\Documentos\GitHub\EcommerceRopa-Grupo-1\Grupo1\Grupo1\Ventas\factura.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Fecha: " + venta_nueva.Fecha);
                    sw.WriteLine("Cliente ID: " + venta_nueva.Cliente_id);
                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        sw.WriteLine("Producto ID: " + idProducto + ", Cantidad: " + cantidad );
                    }
                    sw.WriteLine("Total: " + txtTotal.Text);

                }


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    using (MySqlCommand cmd1 = new MySqlCommand("UPDATE indumentaria SET stock = stock - @cantidad WHERE id = @idproducto AND stock >= @cantidad", myCon))
                    {
                        cmd1.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd1.Parameters.AddWithValue("@idproducto", idProducto);
                        cmd1.ExecuteNonQuery();
                    }


                    using (MySqlCommand cmd2 = new MySqlCommand("INSERT INTO indumentaria_has_ventas (indumentaria_id, ventas_id, cantidad) VALUES (@idproducto, @idventa, @cantidad)", myCon))
                    {
                        cmd2.Parameters.AddWithValue("@idproducto", idProducto);
                        cmd2.Parameters.AddWithValue("@idventa", venta_nueva.Id);
                        cmd2.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd2.ExecuteNonQuery();
                    }


                }

                myCon.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al crear una nueva venta" + ex);
            }




        }














        private void txtBox_idCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     double total = 0.0;



            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
           
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    double precio = Convert.ToDouble(row.Cells["precio"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    total += precio * cantidad;
                }

                txtTotal.Text = total.ToString();
            }
        }

    }
}
