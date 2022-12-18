using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace SistemaABD.Clases
{
    internal class CAlumnos
    {

        //METODO MOSTRAR ALUMNOS//
        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "select * from alumnos";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostrarón los datos de la base de datos, error: " + ex.ToString());
            } 
        }


        //METODO GUARDAR ALUMNOS//
        public void guardarAlumnos(TextBox nombres, TextBox apellidos)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "insert into alumnos(nombres, apellidos)" + "values('" + nombres.Text + "','" + apellidos.Text + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se registró correctamente.");
                while (reader.Read()) //para recorrer y muestre los datos en el dgv
                {
               
                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostrarón los datos de la base de datos, error: " + ex.ToString());
            }
        }

        //METODO SELECCIONAR ALUMNOS//
        public void seleccionarAlumnos(DataGridView tablaAlumnos, TextBox id, TextBox nombres, TextBox apellidos)
        {
            try
            {
                id.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();//Para recorrer las filas y las columnas (cadena)
                nombres.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se seleccionó el alumno, error: " + ex.ToString());
            }
        }

        //METODO MODIFICAR ALUMNOS//
        public void modificarAlumnos(TextBox id, TextBox nombres, TextBox apellidos)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update alumnos set nombres='" + nombres.Text + "', apellidos='" + apellidos.Text + "' where id = '" + id.Text + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion()); ;
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se modificó correctamente.");
                while (reader.Read()) //para recorrer y muestre los datos en el dgv
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostrarón los datos de la base de datos, error: " + ex.ToString());
            }
        }

        //METODO ELIMINAR ALUMNOS//
        public void eliminarAlumnos(TextBox id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from alumnos where id='" + id.Text + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion()); ;
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se eliminó correctamente.");
                while (reader.Read()) //para recorrer y muestre los datos en el dgv
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostrarón los datos de la base de datos, error: " + ex.ToString());
            }
        }
    }
}
