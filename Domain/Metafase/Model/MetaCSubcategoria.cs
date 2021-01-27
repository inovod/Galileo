using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCSubcategoria
    {
        public MetaCSubcategoria()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaReferencia = new HashSet<MetaReferencia>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdSubcategoria { get; set; }
        public int CdCategoria { get; set; }
        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public string DsSubcategoria { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCategoria Cd { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferencia { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
