using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
namespace WindowsApp
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnPruebaLoop_Click(object sender, EventArgs e)
        {
            int total = 0;

            MessageBox.Show(" Ingresar 10 números menores a 100");

            for (int i = 1; i <= 4; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese número: ","Carga de números"));

                while (numero >=100)
                {
                    MessageBox.Show("Números menores a 100. Intente de nuevo: ");

                     numero = Convert.ToInt32(Interaction.InputBox("Ingrese número: ", "Carga de números"));
                }

                total= total + numero;
            }

            MessageBox.Show("Total: " + total.ToString());

        }
    }
}
