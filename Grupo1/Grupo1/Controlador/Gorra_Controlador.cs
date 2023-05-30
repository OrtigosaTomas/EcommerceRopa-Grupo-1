using Grupo1.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Controlador
{
    public class Gorra_Controlador
    {



        public bool crearGorra(Gorra gor)
        {


            Trace.WriteLine("error");

            try
            {
                string server = "localhost";
                string database = "mydb";
                string user = "root";
                string pass = "";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";" + "pwd=" + pass + ";";

                using (MySqlConnection myCon = new MySqlConnection(cadenaConexion))
                {
                    myCon.Open();

                    Trace.WriteLine("error1");
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO indumentaria (id, nombre, tipo, detalle, precio, genero_id, categoria_id, talle_id, stock_id) VALUES (@id, @nombre, @tipo, @detalle, @precio, @genero, @categoria, @talle, @stock)", myCon))
                    {
                        cmd.Parameters.AddWithValue("@id", gor.Id);
                        cmd.Parameters.AddWithValue("@nombre", gor.Nombre);
                        cmd.Parameters.AddWithValue("@tipo", gor.Tipo);
                        cmd.Parameters.AddWithValue("@detalle", gor.Detalle);
                        cmd.Parameters.AddWithValue("@precio", gor.Precio);
                        cmd.Parameters.AddWithValue("@genero", gor.Genero_id);
                        cmd.Parameters.AddWithValue("@categoria", gor.Categoria_id);
                        cmd.Parameters.AddWithValue("@talle", gor.Talle_id);
                        cmd.Parameters.AddWithValue("@stock", gor.Stock_id);


                        


                        Trace.WriteLine("error2");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;




                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }




        }





     

    }
}
