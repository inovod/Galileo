using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPreguntasCuestionario
    {
        public MetaPreguntasCuestionario()
        {
            InverseCd = new HashSet<MetaPreguntasCuestionario>();
            MetaRespuestasCuestionario = new HashSet<MetaRespuestasCuestionario>();
        }

        public int CdPreguntaCuestionario { get; set; }
        public int CdCuestionario { get; set; }
        public int CdPregunta { get; set; }
        public string DsDescripcion { get; set; }
        public int? CdSector { get; set; }
        public int? CdFamilia { get; set; }
        public int? CdCategoria { get; set; }
        public int? CdSubcategoria { get; set; }
        public int? CdSegmento { get; set; }
        public int? CdSubsegmento { get; set; }
        public int? CdReferencia { get; set; }
        public int? CdPromocion { get; set; }
        public int? CdMaterial { get; set; }
        public int? CdMarca { get; set; }
        public int? CdCliente { get; set; }
        public int NmOrden { get; set; }
        public string ItObligatoria { get; set; }
        public int? CdListaRespuesta { get; set; }
        public int? CdSubtipoLista { get; set; }
        public int? CdDependencia { get; set; }
        public int? ItOperadorDep { get; set; }
        public string DsValorDep { get; set; }
        public byte ItObjeto { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPreguntasCuestionario Cd { get; set; }
        public virtual MetaMarca Cd1 { get; set; }
        public virtual MetaCCategoria Cd2 { get; set; }
        public virtual MetaCSegmento Cd3 { get; set; }
        public virtual MetaCuestionario CdCuestionarioNavigation { get; set; }
        public virtual MetaMaterialVisibilidad CdMaterialNavigation { get; set; }
        public virtual MetaPreguntasSubtipoLista CdNavigation { get; set; }
        public virtual MetaPreguntas CdPreguntaNavigation { get; set; }
        public virtual MetaPromocion CdPromocionNavigation { get; set; }
        public virtual MetaReferencia CdReferenciaNavigation { get; set; }
        public virtual MetaCSubcategoria CdSubcategoriaNavigation { get; set; }
        public virtual MetaCSubsegmento CdSubsegmentoNavigation { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> InverseCd { get; set; }
        public virtual ICollection<MetaRespuestasCuestionario> MetaRespuestasCuestionario { get; set; }
    }
}
