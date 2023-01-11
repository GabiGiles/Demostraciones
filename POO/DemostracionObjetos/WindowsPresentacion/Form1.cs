using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreriaPOO.Models.Derivada;
using LibreriaPOO.Escuela.Models;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearArchivos_Click(object sender, EventArgs e)
        {
            ArchivoTxt archivo= new ArchivoTxt();

            MessageBox.Show(archivo.Registrar("Gaby", "Hola", "C:/"));

            ArchivoXml archivoXml = new ArchivoXml();

            MessageBox.Show(archivoXml.Registrar("GabyXML", "Hola XML", "C:/"));

        }

        private void btnCrearPersonas_Click(object sender, EventArgs e)
        {
            //Notación declarativa
            Alumno alumno = new Alumno()
            {
                 Apellido="Rosa", Nombre="Margarita", Matricula="A111"
            };

            Profesor profesor = new Profesor() 
            {
                 Apellido="DiPaola", Nombre="Diana", Titulo="Profe de Italiano" 
            };

            MessageBox.Show(alumno.Imprimir());
            MessageBox.Show(profesor.Imprimir());
        }
    }
}
