using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre= txtNombre.Text;
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);

            if (sueldo > 0)
            {
                MessageBox.Show(nombre.ToUpper() + " Sueldo: " + sueldo.ToString());
            }
            else
            {
                MessageBox.Show("El sueldo debe ser mayor a cero");
            }

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }
    }
}
