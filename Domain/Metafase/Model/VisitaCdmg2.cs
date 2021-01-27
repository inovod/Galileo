using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class VisitaCdmg2
    {
        public DateTime? Mes { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public string Canal { get; set; }
        public string Cadena { get; set; }
        public string Ensena { get; set; }
        public string Provincia { get; set; }
        public string Vendedor { get; set; }
        public string Direccion { get; set; }
        public int? Tienda { get; set; }
        public DateTime? Fecha { get; set; }
        public string ItEstado { get; set; }
        public int? CdEstado { get; set; }
        public int? Realizada { get; set; }
    }
}
