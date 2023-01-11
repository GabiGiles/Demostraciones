using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsAppNorthwind.Models;
namespace WindowsAppNorthwind
{
    public partial class Form1 : Form
    {

        //Creamos instancia de EF DbContext
        private NorthwindContext context = new NorthwindContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           

            //creamos la instancia
            Shipper shipper = new Shipper() { CompanyName= "Express SRL", Phone= "(503) 555-9001"};

            //DBset
            context.Shippers.Add(shipper);

            //Guardar en la tabla

            int filasAfectadas= context.SaveChanges();

            if (filasAfectadas > 0) {
                MessageBox.Show("OK");
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //buscar shipper
            int id = 4;
            Shipper shipperDB= context.Shippers.Find(id);

            //Modificación del objeto
            if (shipperDB != null)
            {
                shipperDB.CompanyName = "Express Latam SRL";
                shipperDB.Phone = "(503) 555-0001";

            }

            //Guadar en la DB
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            //Buscar el objeto en la DB

            var shipperDb = context.Shippers.Find(id);

            if (shipperDb != null)
            {
                // remover
                context.Shippers.Remove(shipperDb);
                //guardar cambio en la DB
                //Guadar en la DB
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Eliminar OK");
                }

            }
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Shipper> lista= context.Shippers.ToList();//conectar db, select..., cierra conexion

            gridShippers.DataSource = lista;
        }
    }
}
