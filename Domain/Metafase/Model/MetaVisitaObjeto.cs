using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaVisitaObjeto
    {
        public int CdVisitaObjeto { get; set; }
        public Guid RowguidVisita { get; set; }
        public int CdCuestionario { get; set; }
        public int? CdPregunta { get; set; }
        public int? CdFamilia { get; set; }
        public int? CdSector { get; set; }
        public int? CdCategoria { get; set; }
        public int? CdSubcategoria { get; set; }
        public int? CdSegmento { get; set; }
        public int? CdSubsegmento { get; set; }
        public int? CdReferencia { get; set; }
        public int? CdPromocion { get; set; }
        public int? CdMaterial { get; set; }
        public int? CdMarca { get; set; }
        public int? CdCliente { get; set; }
        public byte ItObjeto { get; set; }
        public bool? ItSurtido { get; set; }
        public int? CdCluster { get; set; }
        public bool ItDwh { get; set; }

        public virtual MetaMarca Cd { get; set; }
        public virtual MetaCSegmento Cd1 { get; set; }
        public virtual MetaCCluster CdClusterNavigation { get; set; }
        public virtual MetaCuestionario CdCuestionarioNavigation { get; set; }
        public virtual MetaMaterialVisibilidad CdMaterialNavigation { get; set; }
        public virtual MetaCCategoria CdNavigation { get; set; }
        public virtual MetaPreguntas CdPreguntaNavigation { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
        public virtual MetaCSubcategoria CdSubcategoriaNavigation { get; set; }
        public virtual MetaCSubsegmento CdSubsegmentoNavigation { get; set; }
        public virtual MetaVisita RowguidVisitaNavigation { get; set; }
    }
}
