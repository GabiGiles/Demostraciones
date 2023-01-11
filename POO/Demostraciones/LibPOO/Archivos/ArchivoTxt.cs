using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Archivos
{
    public class ArchivoTxt : Archivo
    {
        public override string Log()
        {
            // escribir todo el código --->System.IO
            return "Registrando log en txt";
        }
    }
}
