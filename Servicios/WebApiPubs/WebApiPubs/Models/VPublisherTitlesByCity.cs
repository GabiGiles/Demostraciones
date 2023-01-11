using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class VPublisherTitlesByCity
    {
        public string Publicador { get; set; }
        public string Ciudad { get; set; }
        public string País { get; set; }
        public string CódigoLibro { get; set; }
        public string Título { get; set; }
    }
}
