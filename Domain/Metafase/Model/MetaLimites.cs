using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaLimites
    {
        public int CdLimite { get; set; }
        public int? CdSector { get; set; }
        public int? CdFamilia { get; set; }
        public int? CdCategoria { get; set; }
        public int? CdSegmento { get; set; }
        public int CdReferencia { get; set; }
        public int CdCadena { get; set; }
        public int? CdEnsena { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime? FcFin { get; set; }
        public int? CdPregunta { get; set; }
        public int NmLimiteMax { get; set; }
        public int NmLimiteMin { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaCSegmento CdNavigation { get; set; }
        public virtual MetaPreguntas CdPreguntaNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
    }
}
