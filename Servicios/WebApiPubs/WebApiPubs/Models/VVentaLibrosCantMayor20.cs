using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class VVentaLibrosCantMayor20
    {
        public string Publicador { get; set; }
        public string Título { get; set; }
        public string OrdNum { get; set; }
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string StorName { get; set; }
        public string City { get; set; }
    }
}
