using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class ExhibicionesCdm
    {
        public DateTime? Mes { get; set; }
        public int? Pdv { get; set; }
        public int? Unidadescolocadas { get; set; }
        public int? Unidadesencontradas { get; set; }
        public int? Unidadesmantenidas { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
        public int? Escala { get; set; }
    }
}
