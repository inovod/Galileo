using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class PromocionCdmg1
    {
        public DateTime? Mes { get; set; }
        public int? Pdv { get; set; }
        public int? Respuesta { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
        public string Promocion { get; set; }
        public string Canal { get; set; }
        public string Cadena { get; set; }
        public string Ensena { get; set; }
        public string Provincia { get; set; }
        public string Vendedor { get; set; }
    }
}
