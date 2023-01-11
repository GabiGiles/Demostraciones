using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class VAuthorsBookTypeCook
    {
        public string IdAutor { get; set; }
        public string NombreAutor { get; set; }
        public string Apellido { get; set; }
        public string CiudadAutor { get; set; }
        public string Título { get; set; }
        public string Tipo { get; set; }
        public string Publicador { get; set; }
        public string CiudadPublicador { get; set; }
    }
}
