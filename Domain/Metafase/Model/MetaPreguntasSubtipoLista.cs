using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPreguntasSubtipoLista
    {
        public MetaPreguntasSubtipoLista()
        {
            MetaPreguntas = new HashSet<MetaPreguntas>();
            MetaPreguntasCuestionario = new HashSet<MetaPreguntasCuestionario>();
            MetaPreguntasSubtipoListaValores = new HashSet<MetaPreguntasSubtipoListaValores>();
        }

        public int CdListaRespuesta { get; set; }
        public int CdSubtipoLista { get; set; }
        public string DsSubtipoLista { get; set; }
        public DateTime FcAlta { get; set; }
        public string DsColor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPreguntasLista CdListaRespuestaNavigation { get; set; }
        public virtual ICollection<MetaPreguntas> MetaPreguntas { get; set; }
        public virtual ICollection<MetaPreguntasCuestionario> MetaPreguntasCuestionario { get; set; }
        public virtual ICollection<MetaPreguntasSubtipoListaValores> MetaPreguntasSubtipoListaValores { get; set; }
    }
}
