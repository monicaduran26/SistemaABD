using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SistemaABD.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "127.0.0.1";
        static string bd = "escuela";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Conectado, error:"+ ex.ToString());
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();      
        }
    }
}
