using Grupo1.Controlador;
using Grupo1.Modelos;
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

namespace Grupo1
{
    public partial class Form1 : Form
    {
        Zapatilla_Controlador zapController = new Zapatilla_Controlador();
        int DEBUG_MODE = 1;
        public Form1()
        {
           
            InitializeComponent();
            txt_id.Text= zapController.getLastId().ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_crear_Click(object sender, EventArgs e)
        {

            try
            {

                Trace.WriteLine("Se esta creando una zapatilla");
                Zapatilla zap_nueva = new Zapatilla();

               

                zap_nueva.Descripcion = txt_descripcion.Text;

                zap_nueva.Id = int.Parse(txt_id.Text);

                zap_nueva.Precio = int.Parse(txt_precio.Text);
                zap_nueva.Nombre = txt_nombre.Text;
                zapController.crearZapatilla(zap_nueva);

                txt_id.Text = zapController.getLastId().ToString();


                if(DEBUG_MODE == 1)
                {

                    Trace.WriteLine("Se esta creando una zapatilla");
                }
                if (DEBUG_MODE == 2)
                {

                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al crear una nueva zapatilla");
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
    }
    }
