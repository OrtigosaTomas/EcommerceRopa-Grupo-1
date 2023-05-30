using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Modelos
{
    public class Gorra
    {


        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Tipo { set; get; }
        public string Detalle { set; get; }
        public int Genero_id { set; get; }
        public int Categoria_id { set; get; }
        public int Talle_id { set; get; }
        public int Stock_id { set; get; }
        public int Precio { set; get; }
        public Gorra()
        {
        }
        public Gorra(int id, string nombre, string tipo, string detalle, int precio, int genero_id, int categoria_id, int talle_id, int stock_id)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Detalle = detalle;
            Precio = precio;
            Genero_id = genero_id;
            Categoria_id = categoria_id;
            Talle_id = talle_id;
            Stock_id = stock_id;

        }



        public Gorra(String line)
        {



        }


    }
}
