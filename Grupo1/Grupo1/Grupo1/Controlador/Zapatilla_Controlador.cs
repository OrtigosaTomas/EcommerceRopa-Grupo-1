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
    public class Zapatilla_Controlador
    {

      

        public bool crearZapatilla(Zapatilla zap)
        {

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

                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO indumentaria (id, nombre, tipo, detalle, precio, genero_id, categoria_id, talle_id, stock_id) VALUES (@id, @nombre, @tipo, @detalle, @precio, @genero, @categoria, @talle, @stock)", myCon))
                        {
                        cmd.Parameters.AddWithValue("@id", zap.Id);
                        cmd.Parameters.AddWithValue("@nombre", zap.Nombre);
                        cmd.Parameters.AddWithValue("@tipo", zap.Tipo);
                        cmd.Parameters.AddWithValue("@detalle", zap.Detalle);
                        cmd.Parameters.AddWithValue("@precio", zap.Precio);
                        cmd.Parameters.AddWithValue("@genero", zap.Genero_id);
                        cmd.Parameters.AddWithValue("@categoria", zap.Categoria_id);
                        cmd.Parameters.AddWithValue("@talle", zap.Talle_id);
                        cmd.Parameters.AddWithValue("@stock", zap.Stock_id);



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


     

 
        public Zapatilla getOne(int id)
        {
            return new Zapatilla();
        }

        public List<Zapatilla> getAll(){
        
        return new List<Zapatilla>();
                }

    }
}
