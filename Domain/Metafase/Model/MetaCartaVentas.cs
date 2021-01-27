using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCartaVentas
    {
        public MetaCartaVentas()
        {
            MetaCartaVentasDocumentos = new HashSet<MetaCartaVentasDocumentos>();
            MetaCartaVentasEnsena = new HashSet<MetaCartaVentasEnsena>();
            MetaCartaVentasFaq = new HashSet<MetaCartaVentasFaq>();
        }

        public int CdCartaVentas { get; set; }
        public string DsCartaVentas { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime? FcFin { get; set; }
        public int CdCliente { get; set; }
        public string DsObjetivo { get; set; }
        public string DsLanzamiento { get; set; }
        public string DsCompetencia { get; set; }
        public string DsPromociones { get; set; }
        public string DsOtros { get; set; }
        public Guid Rowguid { get; set; }
        public bool ItHistorico { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual ICollection<MetaCartaVentasDocumentos> MetaCartaVentasDocumentos { get; set; }
        public virtual ICollection<MetaCartaVentasEnsena> MetaCartaVentasEnsena { get; set; }
        public virtual ICollection<MetaCartaVentasFaq> MetaCartaVentasFaq { get; set; }
    }
}
