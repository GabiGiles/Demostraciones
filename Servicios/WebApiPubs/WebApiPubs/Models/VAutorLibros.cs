using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class VAutorLibros
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CódigoLibro { get; set; }
        public string Título { get; set; }
    }
}
