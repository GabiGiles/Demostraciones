using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Clinica
{
    public class Paciente:Persona
    {
        public int NroHistClinica { get; set; }

        public override string Imprimir()
        {
            return base.Imprimir() + " N° historia Clinica " + NroHistClinica ; 
        }
    }
}
