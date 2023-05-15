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

namespace Grupo1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool login(string username, string password)
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

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cliente WHERE usuario=@username AND contraseña=@password", myCon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                return reader.HasRows;
                
            }
            catch (Exception error)
            {
                 Console.WriteLine("Error de conexion " + error);
                return false;
            }
        }


     

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (isValid())
                {
                    string username = textBox1.Text.Trim();
                    string password = textBox2.Text.Trim();

                    if (login(username, password))
                    {
                        MessageBox.Show("Inicio de sesión exitoso", "Éxito");
                        Hide();
                        Form1 form1 = new Form1();  
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error");
                    }
                }
            }
        }

        private void uername_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isValid()
        {
            if(textBox1.Text.TrimStart()== string.Empty)
            {

                MessageBox.Show("Ingresa un usuario","error");
                return false;
            }else if (textBox2.Text.TrimStart()== string.Empty)
            {

                MessageBox.Show("Ingresa una contraseña","error");
                return false;
            }
            return true;
        }

    }
    }

