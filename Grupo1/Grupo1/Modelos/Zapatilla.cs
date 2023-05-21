
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

        public string Descripcion { set; get; } 

        public string img { set; get; }

        public int Precio { set; get; }

        public Zapatilla(){};

        public Zapatilla(int id, string nombre, string descripcion, int precio) 
        {
        Id=id;
        Nombre=nombre;
        Descripcion=descripcion;
        Precio=precio;
        }
      

        public Zapatilla(String line) { 
            string[] datos = line.Split(';');
            Id= int.Parse(datos[0]);    
            Nombre = datos[1];
            Precio = int.Parse(datos[2]);
            Descripcion = datos[3];
        }

        
    }
}
