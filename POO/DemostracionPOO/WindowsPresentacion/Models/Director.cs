using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentacion.Models
{
    public class Director
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int Matricula { get; set; }
        public string Especialidad { get; set; }

        public string PostGrado { get; set; }
    }
}
