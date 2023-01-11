using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar namespace
using Microsoft.VisualBasic;
namespace WindowsApp
{
    public partial class frmVector : Form
    {
        //declarar vector
        private int[] numeros;

        public frmVector()
        {
            InitializeComponent();
        }

        private void btnCrearVector_Click(object sender, EventArgs e)
        {
            

            //crear en memoria
            numeros = new int[4];

            for (int i = 0; i < numeros.Length; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese número"));
                numeros[i] = numero;

            }

            MessageBox.Show(numeros.Count().ToString());


        }

        private void btnMostrarVector_Click(object sender, EventArgs e)
        {
            foreach (int item in numeros)
            {
                lstVector.Items.Add(item);
            }
        }
    }
}
