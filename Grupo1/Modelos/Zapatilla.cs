using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Modelos
{
    public class Zapatilla
    {
      

        public int Id { set; get; }
        public string Nombre { set; get; }
          public string Tipo { set; get; }    
        public string Detalle { set; get; }
        public int Genero_id { set; get; }
        public int Categoria_id { set; get; }
        public int Talle { set; get; }
        public int Stock { set; get; }
        public int Precio { set; get; }

        public string Img { set; get; }
        public Zapatilla()
        {
        }
        public Zapatilla(int id, string nombre, string tipo, string detalle, int precio, int genero_id, int categoria_id, int talle, int stock, string img) 
        {
              Id=id;
           Nombre=nombre;
            Tipo = tipo;
            Detalle = detalle;
            Precio = precio;
            Genero_id = genero_id;
            Categoria_id = categoria_id;
            Talle = talle;
            Stock = stock;
            Img = img;
        }      

      

        public Zapatilla(String line) { 
  
     
        
        }

        
    }
}
