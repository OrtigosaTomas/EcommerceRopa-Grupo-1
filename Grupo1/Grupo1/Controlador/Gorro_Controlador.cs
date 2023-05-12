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

	public class Gorro_Controlador
	{
		//public Gorro_Controlador(){}

        public static string ruta = "../../Resources/Gorros.txt";


        public int getLastId()
        {
            StreamReader archivo = new StreamReader(ruta);
            int lastId = 1;


            while (!archivo.EndOfStream)
            {
                string gorro = archivo.ReadLine();
                Gorro g = new Gorro(gorro);
                lastId = g.Id;
            }
            archivo.Close();

            return lastId + 1;
        }



        public bool crearGorro(Gorro g)
        {

            try
            {

                String linea = g.Id + ";" + g.Nombre + ";" + zap.Descripcion + ";" + zap.Precio;
                StreamWriter archivo = new StreamWriter(ruta, true);
                archivo.WriteLine(linea);
                archivo.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error" + ex.ToString());
            }

            return true;
        }



        public bool eliminarGorro(Gorro g)
        {
            return true;
        }


        public bool editarGorro(Gorro g)
        {
            return true;
        }


        public Gorro getOne(int id)
        {
            StreamReader archivo = new StreamReader(ruta);


            while (!archivo.EndOfStream)
            {
                string gorro = archivo.ReadLine();
                gorro g = new Gorro(gorro);
                if (id == g.Id)
                {
                    return g;
                }
            }
            archivo.Close();

            return new Gorro();
        }


        public List<Gorro> getAll()
        {

            List<Gorro> Gorros = new List<Gorro>();
            StreamReader archivo = new StreamReader(ruta);


            while (!archivo.EndOfStream)
            {
                string gorro = archivo.ReadLine();
                Gorro g = new Gorro(gorro);
                Gorros.Add(g);
            }
            archivo.Close();

            return Gorros;

        }
    }

}
