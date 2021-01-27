using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCEnsena
    {
        public MetaCEnsena()
        {
            MetaAviso = new HashSet<MetaAviso>();
            MetaCCluster = new HashSet<MetaCCluster>();
            MetaCartaVentasEnsena = new HashSet<MetaCartaVentasEnsena>();
            MetaCuestionario = new HashSet<MetaCuestionario>();
            MetaLimites = new HashSet<MetaLimites>();
            MetaMaterialEnsena = new HashSet<MetaMaterialEnsena>();
            MetaPromocionCodigoInterno = new HashSet<MetaPromocionCodigoInterno>();
            MetaPromocionEnsena = new HashSet<MetaPromocionEnsena>();
            MetaReferenciaCodigoInterno = new HashSet<MetaReferenciaCodigoInterno>();
            MetaReferenciaPrioridad = new HashSet<MetaReferenciaPrioridad>();
            MetaSurtido = new HashSet<MetaSurtido>();
            MetaTienda = new HashSet<MetaTienda>();
            MetaUsuarioClienteEnsena = new HashSet<MetaUsuarioClienteEnsena>();
        }

        public int CdEnsena { get; set; }
        public int CdCadena { get; set; }
        public string DsEnsena { get; set; }
        public string DsAbreviatura { get; set; }
        public int? CdSubagrupacion { get; set; }
        public string DsRutaLogo { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCSubagrupacion Cd { get; set; }
        public virtual MetaCCadena CdCadenaNavigation { get; set; }
        public virtual ICollection<MetaAviso> MetaAviso { get; set; }
        public virtual ICollection<MetaCCluster> MetaCCluster { get; set; }
        public virtual ICollection<MetaCartaVentasEnsena> MetaCartaVentasEnsena { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionario { get; set; }
        public virtual ICollection<MetaLimites> MetaLimites { get; set; }
        public virtual ICollection<MetaMaterialEnsena> MetaMaterialEnsena { get; set; }
        public virtual ICollection<MetaPromocionCodigoInterno> MetaPromocionCodigoInterno { get; set; }
        public virtual ICollection<MetaPromocionEnsena> MetaPromocionEnsena { get; set; }
        public virtual ICollection<MetaReferenciaCodigoInterno> MetaReferenciaCodigoInterno { get; set; }
        public virtual ICollection<MetaReferenciaPrioridad> MetaReferenciaPrioridad { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtido { get; set; }
        public virtual ICollection<MetaTienda> MetaTienda { get; set; }
        public virtual ICollection<MetaUsuarioClienteEnsena> MetaUsuarioClienteEnsena { get; set; }
    }
}
