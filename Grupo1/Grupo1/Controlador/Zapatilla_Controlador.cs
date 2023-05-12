using Grupo1.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Controlador
{
    public class Zapatilla_Controlador
    {

        public static string ruta = "../../Resources/zapatillas.txt";

        
        public int getLastId()
        {
            StreamReader archivo = new StreamReader(ruta);
            int lastId = 1;


                while (!archivo.EndOfStream)
                {
                    string zapatilla = archivo.ReadLine();
                    Zapatilla zap = new Zapatilla(zapatilla);
                    lastId = zap.Id;
                }
                archivo.Close();

            return lastId +1;
        }



        public bool crearZapatilla(Zapatilla zap)
        {

            try {

                String linea = zap.Id + ";" + zap.Nombre + ";" + zap.Precio + ";" +zap.Descripcion;
                StreamWriter archivo = new StreamWriter(ruta, true);
                archivo.WriteLine(linea);
                archivo.Close();
            }
            catch(Exception ex)
            {
                Trace.WriteLine("Ocurrio un error"+ex.ToString());
            }

            return true;
        }



        public bool eliminarZapatilla(Zapatilla zap)
        {
            return true;
        }


        public bool editarZapatilla(Zapatilla zap)
        {
            return true;
        }


        public Zapatilla getOne(int id)
        {
            StreamReader archivo = new StreamReader(ruta);


                while (!archivo.EndOfStream)
                {
                    string zapatilla = archivo.ReadLine();
                    Zapatilla zap = new Zapatilla(zapatilla);
                    if(id == zap.Id)
                    {
                        return zap;
                    }
                }
            archivo.Close();

            return new Zapatilla();
        }


        public List<Zapatilla> getAll(){

            List<Zapatilla> Zapatillas = new List<Zapatilla>();
            StreamReader archivo = new StreamReader(ruta);


                while (!archivo.EndOfStream)
                {
                    string zapatilla = archivo.ReadLine();
                    Zapatilla zap = new Zapatilla(zapatilla);
                    Zapatillas.Add(zap);
                }
            archivo.Close();

            return Zapatillas;

        }

    }
}
