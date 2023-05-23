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
        String query;

        public Form4()
        {
            InitializeComponent();
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
            Conectar();
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
            EjecutarQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "SELECT `nombre`, `tipo`, `detalle`, `precio` FROM `indumentaria` WHERE `tipo` = \"zapatilla\";";
            EjecutarQuery();
        }

    }
}
