using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido= txtApellido.Text;
            string legajo=txtLegajo.Text;

            Alumno alumno = new Alumno(nombre,apellido, legajo);

            MessageBox.Show(alumno.Apellido + ", " + alumno.Nombre);
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            Director director = new Director("Marcos", "Pint", "Licenciado");

            MessageBox.Show(director.Apellido + " Título: " + director.Titulo);
        }
    }
}
