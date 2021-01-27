using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class PromocionCdm
    {
        public DateTime? Mes { get; set; }
        public int? Pdv { get; set; }
        public double? Respuesta { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
    }
}
