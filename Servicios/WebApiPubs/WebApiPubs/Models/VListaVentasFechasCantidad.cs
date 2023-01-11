using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class VListaVentasFechasCantidad
    {
        public string Tienda { get; set; }
        public string IdTitulo { get; set; }
        public DateTime Fecha { get; set; }
        public short Cantidad { get; set; }
    }
}
