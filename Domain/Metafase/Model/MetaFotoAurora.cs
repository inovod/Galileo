using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaFotoAurora
    {
        public int IdFoto { get; set; }
        public int? Referencia { get; set; }
        public string Fecha { get; set; }
        public int? Tipo { get; set; }
        public Guid? UidVisita { get; set; }
        public int? TipoObservacion { get; set; }
        public Guid? UidFoto { get; set; }
        public string Comentario { get; set; }
    }
}
