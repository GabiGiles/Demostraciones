using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentacion.Models
{
    public class Paciente
    {
        //constructor default
        public Paciente() { }


        //constructor con parámetros
        public Paciente(string Nombre, string apellido, DateTime pFechaNacimiento, string paramHistClinica)
        {
            this.Nombre = Nombre;
            Apellido=apellido;
            FechaNacimiento = pFechaNacimiento;
            NroHitoriaClinica = paramHistClinica;
        }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NroHitoriaClinica { get; set; }
    }
}
