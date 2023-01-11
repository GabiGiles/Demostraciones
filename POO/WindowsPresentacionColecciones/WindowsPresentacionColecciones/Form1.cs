using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsPresentacionColecciones.Models;
using WindowsPresentacionColecciones.Colecciones;
using WindowsPresentacionColecciones.PruebaStatic;
namespace WindowsPresentacionColecciones
{
    public partial class Form1 : Form
    {
        //declarar
        List<Producto> productos;
        public Form1()
        {
            InitializeComponent();
        }

      private void btnGuardarProductsLista_Click(object sender, EventArgs e)
        {

            List<Producto> productos = AdminProducto.TraerPorCategoria("Hardware");
            //// crear la lista
            //productos = new List<Producto>();

            ////crear objeto producto
            //Producto producto = new Producto() { Nombre = "Teclado", Categoria = "Hardware", Precio = 222 };

            ////agregar el producto a la lista
            //productos.Add(producto);

            ////Agregar otro producto a la colección de productos - Tipo Anonimo

            //productos.Add(new Producto() { Nombre = "Monitor", Categoria = "Hardware", Precio = 44 });
            //productos.Add(new Producto() { Nombre = "Impresora", Categoria = "Hardware", Precio = 414 });
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Producto> lista;

            //AdminProducto adminProducto = new AdminProducto();

            lista = AdminProducto.Carga();
            

            gridProductos.DataSource = lista;

            foreach (Producto producto in lista)
            {
                lstPrecioProducto.Items.Add(producto.Nombre + " Precio:" + producto.Precio.ToString());
            }
        }

        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Gaby");
            Cliente cliente2 = new Cliente("Gustavo");

            MessageBox.Show(Cliente.Instancias.ToString());

            Cliente cliente3 = new Cliente("Pedro");
            Cliente cliente4 = new Cliente("Cecilia");

            MessageBox.Show(Cliente.Instancias.ToString());

        }
    }
}
