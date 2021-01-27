using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class SurtidoCdm
    {
        public DateTime? Mes { get; set; }
        public int? Pdv { get; set; }
        public int? Distribucion { get; set; }
        public int? Oos { get; set; }
        public int? Potencial { get; set; }
        public double? Distribucion1 { get; set; }
        public double? Fuerastock { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
    }
}
