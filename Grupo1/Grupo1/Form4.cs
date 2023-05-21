using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {

        MySqlConnection myCon;
        String query;

        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar();
            string query = "SELECT * FROM `indumentaria` WHERE tipo = gorra";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conectar();
            string query = "SELECT * FROM `indumentaria` WHERE tipo = zapatilla";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try{
                reader = comandoDB.ExecuteReader();
            }
            catch(Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
