using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPreguntasListaValores
    {
        public MetaPreguntasListaValores()
        {
            MetaPreguntasSubtipoListaValores = new HashSet<MetaPreguntasSubtipoListaValores>();
        }

        public int CdValorRespuesta { get; set; }
        public int CdListaRespuesta { get; set; }
        public string DsValor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPreguntasLista CdListaRespuestaNavigation { get; set; }
        public virtual ICollection<MetaPreguntasSubtipoListaValores> MetaPreguntasSubtipoListaValores { get; set; }
    }
}
