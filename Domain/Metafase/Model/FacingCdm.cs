using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class FacingCdm
    {
        public DateTime? Mes { get; set; }
        public string DsPregunta { get; set; }
        public int? Facing { get; set; }
        public int? Potencial { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
        public double? Promedio { get; set; }
        public int? Pdv { get; set; }
    }
}
