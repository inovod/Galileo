using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaPreguntasSubtipoListaValores
    {
        public int CdListaRespuesta { get; set; }
        public int CdSubtipoLista { get; set; }
        public int CdValorRespuesta { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaPreguntasSubtipoLista Cd { get; set; }
        public virtual MetaPreguntasListaValores CdNavigation { get; set; }
    }
}
