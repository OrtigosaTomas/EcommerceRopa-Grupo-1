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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grupo1.Properties
{
    public partial class Form4 : Form
    {

        MySqlConnection myCon;
        String query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE 1";

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
                Console.WriteLine("Error de conexion " + error);
            }
        }

        private void EjecutarQuery(){
          
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
                    }
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("no hay indumentaria");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error al ejecutar la query" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"gorra\";";

            if (radSinFg.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"gorra\";";
            }
            if (radCurvas.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"3\";";
            }
            if (radPiluso.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"1\";";
            }
            if (radPlanas.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"2\";";
            }

            EjecutarQuery();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"zapatilla\";";

            if (radSinFz.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"zapatilla\";";
            }
            if (radHombre.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `genero_id` = \"1\";";
            }
            if (radMujer.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `genero_id` = \"2\";";
            }
            if (radMinimal.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"6\";";
            }
            if (radRunning.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"5\";";
            }
            if (radTenis.Checked == true)
            {
                query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `categoria_id` = \"4\";";
            }

            EjecutarQuery();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string where = "where 1 = 1";
            if (tboxNombre.Text != "")
            {
                where = where + " AND nombre like \"%" + tboxNombre.Text + "%\"; ";
            }
            if (txtBoxTipo.Text != "")
            {
                where = where + " AND tipo like \"%" + txtBoxTipo.Text + "%\"; ";
            }
            if (txtBoxPrecio.Text != "")
            {
                where = where + " AND precio like \"%" + txtBoxPrecio.Text + "%\"; ";
            }
            query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria`" + where;
            EjecutarQuery();
        }
    }
}