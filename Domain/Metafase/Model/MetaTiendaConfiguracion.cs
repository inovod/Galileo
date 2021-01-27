using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaConfiguracion
    {
        public int CdConfiguracion { get; set; }
        public int CdTienda { get; set; }
        public int CdSector { get; set; }
        public int CdFamilia { get; set; }
        public int CdCategoria { get; set; }
        public int CdSegmento { get; set; }
        public int CdCluster { get; set; }
        public string DsUseralta { get; set; }
        public string DsUsermodif { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCSegmento Cd { get; set; }
        public virtual MetaCCluster CdClusterNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
    }
}
