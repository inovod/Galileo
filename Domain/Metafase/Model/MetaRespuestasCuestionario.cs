using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaRespuestasCuestionario
    {
        public Guid Rowguid { get; set; }
        public int CdPreguntaCuestionario { get; set; }
        public int CdCuestionario { get; set; }
        public int CdTienda { get; set; }
        public DateTime FcFecha { get; set; }
        public string DsRespuesta { get; set; }
        public bool? ItSurtido { get; set; }
        public int? CdCluster { get; set; }
        public string UserName { get; set; }
        public Guid RowguidVisita { get; set; }

        public virtual MetaPreguntasCuestionario Cd { get; set; }
        public virtual MetaCCluster CdClusterNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual MetaRespuestasCuestionarioDwh MetaRespuestasCuestionarioDwh { get; set; }
    }
}
