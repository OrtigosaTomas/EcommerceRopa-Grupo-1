using Grupo1.Controlador;
using Grupo1.Modelos;
using Grupo1.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupo1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "My Application";
            txt_nombre.Text = "Default Name";
        }


        Zapatilla_Controlador zapController = new Zapatilla_Controlador();
        int DEBUG_MODE = 1;
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void boton_crear_Click(object sender, EventArgs e)
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

                MySqlCommand cmd = new MySqlCommand("SELECT MAX(Id) FROM indumentaria", myCon);
                int lastId = Convert.ToInt32(cmd.ExecuteScalar());
                Trace.WriteLine("asd "+ lastId);

                Zapatilla zap_nueva = new Zapatilla();

                zap_nueva.Id = lastId + 1;
              
                myCon.Close();
                
                Trace.WriteLine("hola");
             
               
                zap_nueva.Tipo = "zapatilla";

                if(txt_stockid.Text.TrimStart() == string.Empty &&  txt_detalle.Text.TrimStart() == string.Empty && txt_nombre.Text.TrimStart() == string.Empty && txt_precio.Text.TrimStart() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el dato solicitado");
                

                }else if (IsNumeric(int.Parse(txt_precio.Text).TrimStart()) && IsNumeric(int.Parse(txt_precio.Text).TrimStart()))
                {
                    MessageBox.Show("Ingrese un numero");

                 }
                else
                {
                    zap_nueva.Detalle = txt_detalle.Text;
            
                    zap_nueva.Nombre = txt_nombre.Text;

                    zap_nueva.Precio = int.Parse(txt_precio.Text);

                    zap_nueva.Stock = int.Parse(txt_stockid.Text);
                }
            
                
              

             
                if (generoBox.SelectedItem.ToString() == "Masculino")
                {
                    zap_nueva.Genero_id = 1;
                }
                else if (generoBox.SelectedItem.ToString() == "Femenino")
                {

                    zap_nueva.Genero_id = 2;
                }



                if (talleBox.SelectedItem.ToString() == "10")
                {
                    zap_nueva.Talle = 1;
                }
                else if (talleBox.SelectedItem.ToString() == "20")
                {

                    zap_nueva.Talle = 2;
                }
                else if (talleBox.SelectedItem.ToString() == "30")
                {

                    zap_nueva.Talle = 3;
                }
                else if (talleBox.SelectedItem.ToString() == "40")
                {

                    zap_nueva.Talle = 4;
                }
                else if (talleBox.SelectedItem.ToString() == "50")
                {

                    zap_nueva.Talle = 5;
                }






                if (categoriaBox.SelectedItem.ToString() == "Tennis")
                {
                    zap_nueva.Categoria_id = 4;
                }
                else if (categoriaBox.SelectedItem.ToString() == "Running")
                {

                    zap_nueva.Categoria_id = 5;
                }
                else if (categoriaBox.SelectedItem.ToString() == "Minimalista")
                {

                    zap_nueva.Categoria_id = 6;
                }


            


                zapController.crearZapatilla(zap_nueva);

              


                if (DEBUG_MODE == 1)
                {

                    Trace.WriteLine("Se esta creando una zapatilla");
                }
                if (DEBUG_MODE == 2)
                {

                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al crear una nueva zapatilla" + ex);
            }
            }

        private void btn_form2(object sender, EventArgs e)
        {

            
        }

        private void boton_form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult dialogResult = form2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Trace.WriteLine("OK");
            }


            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            DialogResult dialogResult = form4.ShowDialog();
            this.Hide();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void generoBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void talleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_stockid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_detalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

    }
    }
