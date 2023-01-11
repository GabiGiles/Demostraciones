using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        #region constructores

        //constructor por defecto
        public Profesor() { }

        //con parámetros
        public Profesor(string nombre, string apellido, string titulo):base(nombre, apellido)
        {
            Titulo = titulo;
        }
        #endregion

        #region propiedades
        public string Titulo { get; set; }

        #endregion

    }
}
