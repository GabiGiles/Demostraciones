using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //herencia ":" Alumno hereda de persona 
    public class Alumno:Persona
    {
        #region constructores
       
        public Alumno(string nombre, string apellido,string legajo):base(nombre, apellido) 
        { 
            Legajo = legajo;
        }
        #endregion

        #region propiedades
      
        public string Legajo { get; set; }
        #endregion
    }
}
