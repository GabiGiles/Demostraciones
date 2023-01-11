using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director:Profesor
    {
        //constructor por defecto
        public Director() { }

        //constructor con parámetro
        public Director(string nombre, string apellido, string titulo) : base(nombre, apellido, titulo) { }
    }
}
