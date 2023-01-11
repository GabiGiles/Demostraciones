using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using WindowsException.Models;

namespace WindowsException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPruebaException_Click(object sender, EventArgs e)
        {
            int num1=0, num2=10, resultado=0;

            try
            {
                //código ejecutable
                resultado = num2 / num1;
                MessageBox.Show(resultado.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " Ingrese un número mayor a cero");
                /*
                 error log a un archivo de texto 
                 * */
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :(");

                /*
                 error log a un archivo de texto -->ex.ErrorMessage
                 * */
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cadena de conexión que indica a que servidor/base de datos me voy a conectar
            string cadenaConexion = @"Data Source=.;Initial Catalog=msdb;Integrated Security=True";
            //Objeto para conectarnos a la base de datos establecida en la cadena de conexión
            SqlConnection conexion = conexion = new SqlConnection(cadenaConexion); ;
            
            try
            {    
                //abrimos la conexión
                conexion.Open();
                MessageBox.Show(conexion.State.ToString());
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message);
                MessageBox.Show(conexion.State.ToString());
            }
            finally 
            {
                if (conexion.State== ConnectionState.Open)
                {
                    conexion.Close();
                }
                MessageBox.Show(conexion.State.ToString());
            }
           
        }

        private void btnMiExepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento(new DateTime(2022, 11, 02), new DateTime(2022, 11, 03));

                evento.Nombre = "  Charla de SQL";

                MessageBox.Show(evento.Nombre);
            }
            catch (Exception ex)
            {
                try
                {
                    MessageBox.Show("Ocurrio un error :( " + " " + ex.Message);
                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un error :( " + " " + ex.Message);
                }
                
            }
      
        }
    }
}
