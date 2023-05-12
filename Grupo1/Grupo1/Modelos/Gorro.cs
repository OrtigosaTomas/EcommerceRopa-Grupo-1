using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Modelos
{

    public class Gorro
    {
        public int Id { set; get; }

        public string Nombre { set; get; }

        public string Descripcion { set; get; }

        public string Img { set; get; }

        public double Precio { set; get; }

        //public int TipoGorro;

        public Gorro() { }

        public Gorro(int Id, string nombre, string desc, double precio ) {

            Id = Id;
            Nombre = nombre;
            Descripcion = desc;
            Precio = precio;

        }

        public Gorro(String line)
        {

            string[] datos = line.Split(';');
            Id = int.Parse(datos[0]);
            Nombre = datos[1];
            Descripcion = datos[2];
            Precio = int.Parse(datos[3]);

        }

    }
}
