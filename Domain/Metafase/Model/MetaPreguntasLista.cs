using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPreguntasLista
    {
        public MetaPreguntasLista()
        {
            MetaPreguntas = new HashSet<MetaPreguntas>();
            MetaPreguntasListaValores = new HashSet<MetaPreguntasListaValores>();
            MetaPreguntasSubtipoLista = new HashSet<MetaPreguntasSubtipoLista>();
        }

        public int CdListaRespuesta { get; set; }
        public string DsListaRespuesta { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaPreguntas> MetaPreguntas { get; set; }
        public virtual ICollection<MetaPreguntasListaValores> MetaPreguntasListaValores { get; set; }
        public virtual ICollection<MetaPreguntasSubtipoLista> MetaPreguntasSubtipoLista { get; set; }
    }
}
