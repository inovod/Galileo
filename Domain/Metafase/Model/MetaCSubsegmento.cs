using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSubsegmento
    {
        public MetaCSubsegmento()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaReferencia = new HashSet<MetaReferencia>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdSubsegmento { get; set; }
        public int CdSegmento { get; set; }
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public string DsSubsegmento { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCSegmento Cd { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferencia { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
