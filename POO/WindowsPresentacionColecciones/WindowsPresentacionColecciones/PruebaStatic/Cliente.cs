using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentacionColecciones.PruebaStatic
{
    public class Cliente
    {
        public Cliente(string nombre)
        {
            Nombre = nombre;
            instancias++;
        }
        public string Nombre { get; set; }

        private static int instancias;
        public static int Instancias
        {
            get { return instancias; }
        }

    }
}
