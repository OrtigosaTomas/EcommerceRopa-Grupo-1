﻿using Grupo1.Controlador;
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
                Boolean validaciones = false;

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
                    validaciones = true;
                    MessageBox.Show("Ingrese un nombre");
                }
else
                {
                    gor_nueva.Nombre = txt_nombre1.Text;
               
                }


                gor_nueva.Tipo = "gorra";



                if (string.IsNullOrEmpty(txt_detalle1.Text) || txt_detalle1.Text == "Ingrese Detalle")
                {
                    validaciones = true;
                    MessageBox.Show("Ingrese un detalle");
                }
                else
                {
                    gor_nueva.Detalle = txt_detalle1.Text;

                }



            

                gor_nueva.Genero_id = 3;



                if (string.IsNullOrEmpty(txt_precio1.Text) || txt_precio1.Text == "Ingrese Precio")
                {
                    validaciones = true;
                    MessageBox.Show("Ingrese un precio");
                }
                else
                {

                    gor_nueva.Precio = int.Parse(txt_precio1.Text);
                }


                if (string.IsNullOrEmpty(labelImagen.Text) || labelImagen.Text == "Ingrese Imagen")
                {
                    validaciones = true;
                    MessageBox.Show("Ingrese una imagen");
                }
                else
                {
                    imagenGor.Image.Save(Application.StartupPath + "\\Resources\\" + labelImagen.Text);
                    gor_nueva.Img = labelImagen.Text;
                }




                if (string.IsNullOrEmpty(talleBox2.Text))
                {
                    validaciones = true;
                    MessageBox.Show("Seleccione un talle");
                }
                else
                {
                    
                   gor_nueva.Talle = int.Parse(talleBox2.Text);

                }




                Trace.WriteLine("2");
                if (categoriaBox1.SelectedItem == null)
                {
                    validaciones = true;
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
                    validaciones = true;
                    MessageBox.Show("Ingrese un stock");
                }
                else
                {

                    gor_nueva.Stock = int.Parse(txt_stockid1.Text);

                }
                Trace.WriteLine("1");


                if (validaciones == true)
                {
                    MessageBox.Show("Ocurrio un error al crear una nueva gorra");
                }
                else
                {
                    gorController.crearGorra(gor_nueva);
                    MessageBox.Show("Se ha creado una gorra", "Éxito"); 
                }


                Trace.WriteLine("44");



                if (DEBUG_MODE == 1)
                {
                    Trace.WriteLine("Se esta creando una gorra");
                }
                if (DEBUG_MODE == 2)
                {

                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al crear una nueva gorra" + ex);
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

        private void botonSubirG_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg^;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imagenGor.ImageLocation = getImage.FileName;
                labelImagen.Text = getImage.SafeFileName;
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
