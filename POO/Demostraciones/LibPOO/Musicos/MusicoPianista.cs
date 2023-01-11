using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Musicos
{
    public class MusicoPianista : Musico
    {
        public override string Afinar()
        {
            return "Afinando Piano...tarda más tiempo";
        }
    }
}
