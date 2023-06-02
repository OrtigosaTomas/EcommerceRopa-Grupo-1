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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }


        Gorra_Controlador gorController = new Gorra_Controlador();
        int DEBUG_MODE = 1;


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click1(object sender, EventArgs e)
        {

        }



        private void boton_crear_Click_1(object sender, EventArgs e)
        {
            Trace.WriteLine("asd " );
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
                Trace.WriteLine("asd " + lastId);

                Gorra gor_nueva = new Gorra();

                gor_nueva.Id = lastId + 1;

                myCon.Close();


                Trace.WriteLine("4");



                if(string.IsNullOrEmpty(txt_nombre1.Text) || txt_nombre1.Text == "Ingrese Nombre")
{
                    MessageBox.Show("Ingrese un nombre");
                }
else
                {
                    gor_nueva.Nombre = txt_nombre1.Text;
               
                }


                gor_nueva.Tipo = "gorra";



                if (string.IsNullOrEmpty(txt_detalle1.Text) || txt_detalle1.Text == "Ingrese Detalle")
                {
                    MessageBox.Show("Ingrese un detalle");
                }
                else
                {
                    gor_nueva.Detalle = txt_detalle1.Text;

                }



            

                gor_nueva.Genero_id = 3;



                if (string.IsNullOrEmpty(txt_precio1.Text) || txt_precio1.Text == "Ingrese Precio")
                {
                    MessageBox.Show("Ingrese un precio");
                }
                else
                {

                    gor_nueva.Precio = int.Parse(txt_precio1.Text);
                }


                if (string.IsNullOrEmpty(txtBox_img.Text) || txtBox_img.Text == "Ingrese Imagen")
                {
                    MessageBox.Show("Ingrese una imagen");
                }
                else
                {

                    gor_nueva.Img = txtBox_img.Text;
                }




                if (talleBox2.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un talle");
                }
                else if (talleBox2.SelectedItem.ToString() == "10")
                {
                    gor_nueva.Talle = 1;
                }
                else if (talleBox2.SelectedItem.ToString() == "20")
                {

                    gor_nueva.Talle = 2;
                }
                else if (talleBox2.SelectedItem.ToString() == "30")
                {

                    gor_nueva.Talle = 3;
                }
                else if (talleBox2.SelectedItem.ToString() == "40")
                {

                    gor_nueva.Talle = 4;
                }
                else if (talleBox2.SelectedItem.ToString() == "50")
                {

                    gor_nueva.Talle = 5;
                }
                else if (talleBox2.SelectedItem.ToString() == "60")
                {

                    gor_nueva.Talle = 6;
                }




                Trace.WriteLine("2");
                if (categoriaBox1.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una categoria");
                }

                else if (categoriaBox1.SelectedItem.ToString() == "Piluso")
                {
                    gor_nueva.Categoria_id = 1;
                }
                else if (categoriaBox1.SelectedItem.ToString() == "Plana")
                {

                    gor_nueva.Categoria_id = 2;
                }
                else if (categoriaBox1.SelectedItem.ToString() == "Curva")
                {

                    gor_nueva.Categoria_id = 3;
                }



                if (string.IsNullOrEmpty(txt_stockid1.Text) )
                {
                    MessageBox.Show("Ingrese un stock");
                }
                else
                {

                    gor_nueva.Stock = int.Parse(txt_stockid1.Text);

                }
                Trace.WriteLine("1");



                gorController.crearGorra(gor_nueva);


                Trace.WriteLine("44");



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

        private void btn_form21(object sender, EventArgs e)
        {


        }

        private void boton_form2_Click1(object sender, EventArgs e)
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

        private void txt_nombre_TextChanged1(object sender, EventArgs e)
        {

        }

        private void generoBox_SelectedIndexChanged1(object sender, EventArgs e)
        {


        }

    

        private void txt_id1_TextChanged1(object sender, EventArgs e)
        {

        }

        private void categoriaBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        private void talleBox2_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            DialogResult dialogResult = form4.ShowDialog();
            
        }

        private void generoBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_stockid1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_img_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
