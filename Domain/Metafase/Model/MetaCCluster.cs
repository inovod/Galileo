using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCluster
    {
        public MetaCCluster()
        {
            MetaRespuestasCuestionario = new HashSet<MetaRespuestasCuestionario>();
            MetaSurtidoReferencias = new HashSet<MetaSurtidoReferencias>();
            MetaTiendaConfiguracion = new HashSet<MetaTiendaConfiguracion>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdCluster { get; set; }
        public int CdEnsena { get; set; }
        public int CdCadena { get; set; }
        public string DsCluster { get; set; }
        public int? NmOrden { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual ICollection<MetaRespuestasCuestionario> MetaRespuestasCuestionario { get; set; }
        public virtual ICollection<MetaSurtidoReferencias> MetaSurtidoReferencias { get; set; }
        public virtual ICollection<MetaTiendaConfiguracion> MetaTiendaConfiguracion { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
