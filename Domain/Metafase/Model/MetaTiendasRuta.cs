using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendasRuta
    {
        public int CdTienda { get; set; }
        public int CdRuta { get; set; }
        public int? NmOrden { get; set; }
        public int? NmDuracionVisita { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }
        public Guid Rowguid { get; set; }
        public bool ItHistorico { get; set; }
        public string DsNombreEquipo { get; set; }

        public virtual MetaRuta CdRutaNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
