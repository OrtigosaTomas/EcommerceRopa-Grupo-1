using Grupo1.Modelos;
using Grupo1.Conexion;
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


        public bool altaZapatilla(Zapatilla zap)
        {

             try
            {
                Conexion.DB_Conexion();

                string myQuery = "INSERT INTO indumentaria(nombre,detalle,precio) VALUES("+zap.nombre+","+zap.descripcion+","+zap.precio")";
                
                
                MySqlCommand cmd = new MySqlCommand(myQuery, Conexion.DB_Conexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                Trace.WriteLine("zapatilla dada de alta exitosamente "+reader["id"]+" "+reader["nombre"]);
                }
                reader.Close();
                Conexion.DB_Conexion().Close();
                return true;

            }catch(Exception E)
            {
                Trace.WriteLine(E.Message); 
                Conexion.DB_Conexion().Close();
                return false;

            }
        }


     

        public bool eliminarZapatilla(Zapatilla zap)
        {

            try
            {
                Conexion.DB_Conexion();
                Zapatilla zapaEncontrada = getOne(zap);

                string myQuery = "DELETE * FROM indumentaria WHERE id="+zap.id;

                if(zapaEncontrada!=null){

                    MySqlCommand cmd = new MySqlCommand(myQuery, Conexion.DB_Conexion());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Trace.WriteLine("zapatilla eliminada "+reader["id"]+" "+reader["nombre"]);
                    }

                    reader.Close();
                    Conexion.DB_Conexion().Close();
                    return true;
                }
                
                
            }catch(Exception E)
            {
                Trace.WriteLine(E.Message); 
                Conexion.DB_Conexion().Close();
                return false;

            }
            
        }


        public bool editarZapatilla(Zapatilla zap)
        {
             try
            {
                Conexion.DB_Conexion();
                Zapatilla zapaEncontrada = getOne(zap);

                string myQuery = "UPDATE indumentaria SET id="+zap.id+",nombre="+zap.nombre+",detalle="+zap.descripcion+",precio="+zap.precio+
                                  "WHERE id="zapaEncontrada.Id;
                
                
                if(zapaEncontrada!=null){
                    MySqlCommand cmd = new MySqlCommand(myQuery, Conexion.DB_Conexion());
                    MySqlDataReader reader = cmd.ExecuteReader();
                     while(reader.Read())
                    {
                    Trace.WriteLine("zapatilla editada "+reader["id"]+" "+reader["nombre"]);
                    }
                    reader.Close();
                    Conexion.DB_Conexion().Close();
                    return true;
                }

            }catch(Exception E)
            {
                Trace.WriteLine(E.Message); 
                Conexion.DB_Conexion().Close();
                return false;

            }
        }



        public Zapatilla getOne(int id)
        {
            Zapatilla zapatilla = new Zapatilla();

            try{
                Conexion.DB_Conexion();
                string myQuery = "SELECT * FROM indumentaria WHERE id="+id;
                MySqlCommand cmd = new MySqlCommand(myQuery, Conexion.DB_Conexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                

                while(reader.Read())
                {
                    zapatilla.Add({
                    Id = int.Parse(reader["id"]),
                    Nombre = reader["nombre"].ToString(),
                    Descripcion = reader["detalle"].ToString(),
                    Precio = int.Parse(reader["precio"])
                    });
                }

            reader.Close();
            Conexion.DB_Conexion().Close();
            return zapatilla;
            }catch(Exception E)
            {
                Trace.WriteLine(E.Message); 

            }finally{
                return zapatilla;
            }
                
        }


        public List<Zapatilla> getAll(){
        
          List<Zapatilla> Zapatillas = new List<Zapatilla>();

            try{

                string myQuery = "SELECT * FROM indumentaria";
                MySqlCommand cmd = new MySqlCommand(myQuery, Conexion.DB_Conexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                

                while(reader.Read())
                {
                    Zapatillas.Add(new Zapatilla{
                    Id = int.Parse(reader["id"]),
                    Nombre = reader["nombre"].ToString(),
                    Descripcion = reader["detalle"].ToString(),
                    Precio = int.Parse(reader["precio"])
                    });
                }

            reader.Close();
            Conexion.DB_Conexion().Close();
            return Zapatillas;

            }catch(Exception E)
            {
                Trace.WriteLine(E.Message); 

            }finally{
                return Zapatillas;
                }
        }


    }
}
