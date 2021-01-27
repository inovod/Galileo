using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSegmento
    {
        public MetaCSegmento()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaCSubsegmento = new HashSet<MetaCSubsegmento>();
            MetaLimites = new HashSet<MetaLimites>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaReferencia = new HashSet<MetaReferencia>();
            MetaSegmentoOrden = new HashSet<MetaSegmentoOrden>();
            MetaTiendaConfiguracion = new HashSet<MetaTiendaConfiguracion>();
            MetaTiendaSegmento = new HashSet<MetaTiendaSegmento>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdSegmento { get; set; }
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public string DsSegmento { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCategoria Cd { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaCSubsegmento> MetaCSubsegmento { get; set; }
        public virtual ICollection<MetaLimites> MetaLimites { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferencia { get; set; }
        public virtual ICollection<MetaSegmentoOrden> MetaSegmentoOrden { get; set; }
        public virtual ICollection<MetaTiendaConfiguracion> MetaTiendaConfiguracion { get; set; }
        public virtual ICollection<MetaTiendaSegmento> MetaTiendaSegmento { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
