using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Models.Base
{
    public abstract class Archivo
    {
        public abstract string Registrar(string usuario, string msj, string path);
    }
}
