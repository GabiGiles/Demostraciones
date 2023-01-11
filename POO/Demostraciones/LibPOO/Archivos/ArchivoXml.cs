using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Archivos
{
    public class ArchivoXml : Archivo
    {
        public override string Log()
        {
            // codificar System.XML -->XmlDocument
            return "Log en XML";
        }
    }
}
