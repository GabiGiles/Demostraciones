using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibPOO.Clinica; //agregar
namespace WindowsAppDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            // otra forma de instanciar objetos e inicializar las propiedades
            //notación literal
            Paciente paciente = new Paciente()
            {
                 NroHistClinica =111, Apellido ="Giles", Nombre="Gaby"
            };

            MessageBox.Show(paciente.Imprimir());

            Medico medico = new Medico() { Apellido="Perez", Nombre="Juan", Matricula=4444 };
            MessageBox.Show(medico.Imprimir());

        }
    }
}
