using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPreguntas
    {
        public MetaPreguntas()
        {
            InverseCdDependenciaNavigation = new HashSet<MetaPreguntas>();
            MetaLimites = new HashSet<MetaLimites>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public int CdPregunta { get; set; }
        public string DsPregunta { get; set; }
        public string DsDescripcion { get; set; }
        public int ItTipoPregunta { get; set; }
        public decimal? NmMin { get; set; }
        public decimal? NmMax { get; set; }
        public int? NmDecimales { get; set; }
        public int? NmLongitud { get; set; }
        public int? CdListaRespuesta { get; set; }
        public int? CdSubtipoLista { get; set; }
        public int NmOrden { get; set; }
        public int? CdDependencia { get; set; }
        public int? ItOperadorDep { get; set; }
        public string DsValorDep { get; set; }
        public byte ItObjeto { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPreguntasSubtipoLista Cd { get; set; }
        public virtual MetaPreguntas CdDependenciaNavigation { get; set; }
        public virtual MetaPreguntasLista CdListaRespuestaNavigation { get; set; }
        public virtual ICollection<MetaPreguntas> InverseCdDependenciaNavigation { get; set; }
        public virtual ICollection<MetaLimites> MetaLimites { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
