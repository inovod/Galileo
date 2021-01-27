using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaSurtido
    {
        public MetaSurtido()
        {
            MetaSurtidoReferencias = new HashSet<MetaSurtidoReferencias>();
        }

        public int CdSurtido { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime FcFin { get; set; }
        public int CdCliente { get; set; }
        public int? CdCadena { get; set; }
        public int? CdEnsena { get; set; }
        public int? CdCanal { get; set; }
        public int? CdZona { get; set; }
        public string ItPublicado { get; set; }
        public DateTime? FcAltaSistema { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUseralta { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public Guid Rowguid { get; set; }
        public bool ItHistorico { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaCZona CdZonaNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaSurtidoReferencias> MetaSurtidoReferencias { get; set; }
    }
}
