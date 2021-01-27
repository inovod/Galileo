using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCCanal
    {
        public MetaCCanal()
        {
            InverseCdCanalSuperiorNavigation = new HashSet<MetaCCanal>();
            MetaAviso = new HashSet<MetaAviso>();
            MetaCCanalCadena = new HashSet<MetaCCanalCadena>();
            MetaCCanalCaracteristica = new HashSet<MetaCCanalCaracteristica>();
            MetaCPalanca = new HashSet<MetaCPalanca>();
            MetaCSeccion = new HashSet<MetaCSeccion>();
            MetaCuestionario = new HashSet<MetaCuestionario>();
            MetaDuracionVisita = new HashSet<MetaDuracionVisita>();
            MetaMaterialVisibilidad = new HashSet<MetaMaterialVisibilidad>();
            MetaPromocion = new HashSet<MetaPromocion>();
            MetaSurtido = new HashSet<MetaSurtido>();
            MetaTienda = new HashSet<MetaTienda>();
        }

        public int CdCanal { get; set; }
        public string DsCanal { get; set; }
        public int? CdCanalSuperior { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCCanal CdCanalSuperiorNavigation { get; set; }
        public virtual ICollection<MetaCCanal> InverseCdCanalSuperiorNavigation { get; set; }
        public virtual ICollection<MetaAviso> MetaAviso { get; set; }
        public virtual ICollection<MetaCCanalCadena> MetaCCanalCadena { get; set; }
        public virtual ICollection<MetaCCanalCaracteristica> MetaCCanalCaracteristica { get; set; }
        public virtual ICollection<MetaCPalanca> MetaCPalanca { get; set; }
        public virtual ICollection<MetaCSeccion> MetaCSeccion { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionario { get; set; }
        public virtual ICollection<MetaDuracionVisita> MetaDuracionVisita { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidad { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocion { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtido { get; set; }
        public virtual ICollection<MetaTienda> MetaTienda { get; set; }
    }
}
