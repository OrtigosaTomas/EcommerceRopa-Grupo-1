using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Grupo1.Conexion
{
    public class Conexion
    {
        string server = "localhost";
        string db = "mydb";
        string user = "root";
        string pass = "";

        string stringDeConexion = "server=" + server + ";database=" + db + ";user=" + user + ";password=" + pass + ";";

        public void DB_Conexion()
        {
            try
            {

                MySqlConnection connection = MySqlConnection(stringDeConexion);
                connection.Open();
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception.ToString());
                connection.Close();
            }
            
        }

       
    }
}
