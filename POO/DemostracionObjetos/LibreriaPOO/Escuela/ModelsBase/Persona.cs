﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Escuela.ModelsBase
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public virtual string Imprimir()
        {

            return Nombre + ", " + Apellido;
        }
    }
}
