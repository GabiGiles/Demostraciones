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
    public partial class frmMetodos : Form
    {
        public frmMetodos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();

            int resultado = Suma(10, 20, 30);

            MessageBox.Show(resultado.ToString());
        }
        
        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            Imprimir("Gaby","Giles");
        }

        #region mis métodos

        private void Imprimir()
        {
            MessageBox.Show("Bienvenido");
        }

        private void Imprimir(string nombre)
        {
            MessageBox.Show("Bienvenido " + nombre);
        }


        private void Imprimir(string nombre,string apellido)
        {
            MessageBox.Show("Bienvenido " + nombre + " " + apellido);
        }


        private int Suma(int numero1, int numero2)
        {
            int total;
            total= numero1 + numero2;
            return total;
        }

        private int Suma(int numero1, int numero2, int numero3)
        {
            int total;
            total = numero1 + numero2 + numero3;
            return total;
        }
        #endregion
    }
}
