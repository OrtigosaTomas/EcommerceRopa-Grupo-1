using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grupo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try{

            string server = "localhost";
            string database = "mydb";
            string user = "root";
            string pass = "";
            string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";"+";pwd="+pass+";" ;

            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            labelResultado.Text = "Conexion exitosa";

            }
                catch (Exception error){
                labelResultado.Text = "Error de conexion " + error;
            }
        }
    }
}
