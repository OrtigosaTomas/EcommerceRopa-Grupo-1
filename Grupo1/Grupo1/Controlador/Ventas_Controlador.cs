using Grupo1.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1.Controlador
{
    internal class Ventas_Controlador
    {






        public bool crearVenta(Venta vent)
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

                    
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ventas (idventas, fecha,total,cliente_id) VALUES (@id, @fecha, @total, @cliente_id)", myCon))
                    {
                        cmd.Parameters.AddWithValue("@id", vent.Id);
                        cmd.Parameters.AddWithValue("@fecha", vent.Fecha);
                        cmd.Parameters.AddWithValue("@total", vent.Total);
                        cmd.Parameters.AddWithValue("@cliente_id", vent.Cliente_id);






                   

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

