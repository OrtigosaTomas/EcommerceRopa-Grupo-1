using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Modelos
{
    internal class Venta
    {
     


            public int Id { set; get; }
      public string Fecha { set; get; }

        public double Total { set; get; }
        public int Cliente_id { set; get; }
        

        public Venta() { }

            public Venta(int id, string fecha, double total, int cliente_id)
            {
                Id = id;
                Fecha = fecha;
               Total = total;
            Cliente_id = cliente_id;


            }



            public Venta(String line)
            {



            }


        }
    }









