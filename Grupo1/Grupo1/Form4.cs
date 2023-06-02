using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Grupo1.Form3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grupo1.Properties
{
    public partial class Form4 : Form
    {

        MySqlConnection myCon;
        String query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE 1";

        public Form4()
        {
            InitializeComponent();
            Conectar();
            EjecutarQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Conectar()
        {
            try
            {
                string server = "localhost";
                string database = "mydb";
                string user = "root";
                string pass = "";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";" + ";pwd=" + pass + ";";

                myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();

            }
            catch (Exception error)
            {
                System.Console.WriteLine("Error de conexion " + error);
            }
        }

        private void EjecutarQuery() {
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            dgIndumentaria.Rows.Clear();
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        int n = dgIndumentaria.Rows.Add();
                        dgIndumentaria.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgIndumentaria.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgIndumentaria.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgIndumentaria.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgIndumentaria.Rows[n].Cells[4].Value = reader.GetString(4);
                    }
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("no hay indumentaria");
                    reader.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error al ejecutar la query" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"gorra\";";

            if (radSinFg.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"gorra\";";
            }
            if (radCurvas.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"3\";";
            }
            if (radPiluso.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"1\";";
            }
            if (radPlanas.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"2\";";
            }

            EjecutarQuery();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"zapatilla\";";

            if (radSinFz.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"zapatilla\";";
            }
            if (radHombre.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `genero_id` = \"1\";";
            }
            if (radMujer.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `genero_id` = \"2\";";
            }
            if (radMinimal.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"6\";";
            }
            if (radRunning.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"5\";";
            }
            if (radTenis.Checked == true)
            {
                query = "SELECT `id`,`nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"4\";";
            }

            EjecutarQuery();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgIndumentaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = dgIndumentaria.Rows[indexRow];

            textBox_nombre.Text = row.Cells[0]?.Value?.ToString();
            textBox_detalle.Text = row.Cells[2]?.Value?.ToString();
            textBox_tipo.Text = row.Cells[1]?.Value?.ToString();
            textBox_precio.Text = row.Cells[3]?.Value?.ToString();



        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        int indexRow;




        private bool editar(string nombre, string detalle, string tipo, Decimal precio, string valorActual)
        {




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

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE indumentaria SET nombre = @nombre, detalle = @detalle, tipo = @tipo, precio = @precio WHERE nombre = @valorActual", myCon))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@detalle", detalle);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@precio", precio);

                        cmd.Parameters.AddWithValue("@valorActual", valorActual);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error de conexion: " + error.Message, "Error");
                return false;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
         
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

                    using (MySqlCommand cmd = new MySqlCommand("SELECT `rol` FROM `cliente` WHERE `usuario` = @usuario ", myCon))
                    {
                        System.Console.WriteLine("1");

                        string usuario = GlobalVariables.Usuario;


                        System.Console.WriteLine("usuario " + usuario);


                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        System.Console.WriteLine(usuario);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {


                            if (reader.Read())
                            {
                                
                                int rol = reader.GetInt32(0);


                                if (rol == 0)
                                {
                                  
                                    MessageBox.Show("No tienes el permiso de administrador");
                                }
                                else
                                {

                                    System.Console.WriteLine("3");

                                    DataGridViewRow row = dgIndumentaria.Rows[indexRow];

                                    string nombre = textBox_nombre.Text;
                                    string detalle = textBox_detalle.Text;
                                    string tipo = textBox_tipo.Text;
                                    Decimal precio = Decimal.Parse(textBox_precio.Text);
                                    string valorActual = row.Cells[0].Value.ToString();
                                    editar(nombre, detalle, tipo, precio, valorActual);



                                    MessageBox.Show("Editado correctamente");
                                    EjecutarQuery();
                                   
                                }

                            }

                        }
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de conexion: " + error.Message, "Error");

            }

                //   DataGridViewRow newDataRow = dgIndumentaria.Rows[indexRow];
                // newDataRow.Cells[0].Value = textBox_nombre.Text;

            }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void radCurvas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string where = "where 1 = 1";
            if (txtboxNombre.Text != "")
            {
                where = where + " AND nombre like \"%" + txtboxNombre.Text + "%\"; ";
            }
            if (txtboxTipo.Text != "")
            {
                where = where + " AND tipo like \"%" + txtboxTipo.Text + "%\"; ";
            }
            if (txtboxPrecio.Text != "")
            {
                where = where + " AND precio like \"%" + txtboxPrecio.Text + "%\"; ";
            }
            query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria`" + where;
            EjecutarQuery();
        }

        private void cerrarCon()
        {
            myCon.Close();
        }

        private void txtboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM `indumentaria` WHERE id = " + txtBorrar.Text;
            EjecutarQuery();
        }
    }
    }
