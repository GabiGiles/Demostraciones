using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaPOO.Escuela.ModelsBase;
namespace LibreriaPOO.Escuela.Models
{
    public class Alumno:Persona
    {
        public string Matricula{ get; set; }

        public override string Imprimir()
        {
            return base.Imprimir() + " Matricula: "+Matricula; 
        }

    }
}
