using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCategoriaCliente
    {
        public MetaCategoriaCliente()
        {
            MetaMaterialVisibilidad = new HashSet<MetaMaterialVisibilidad>();
            MetaPromocion = new HashSet<MetaPromocion>();
            MetaReferencia = new HashSet<MetaReferencia>();
        }

        public int CdCategoriaCliente { get; set; }
        public int CdCliente { get; set; }
        public int? CdNivel1 { get; set; }
        public int? CdNivel2 { get; set; }
        public int? CdNivel3 { get; set; }
        public int? CdNivel4 { get; set; }
        public int? CdNivel5 { get; set; }
        public int? CdNivel6 { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaNivelCategoriaCliente CdNivel1Navigation { get; set; }
        public virtual MetaNivelCategoriaCliente CdNivel2Navigation { get; set; }
        public virtual MetaNivelCategoriaCliente CdNivel3Navigation { get; set; }
        public virtual MetaNivelCategoriaCliente CdNivel4Navigation { get; set; }
        public virtual MetaNivelCategoriaCliente CdNivel5Navigation { get; set; }
        public virtual MetaNivelCategoriaCliente CdNivel6Navigation { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidad { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocion { get; set; }
        public virtual ICollection<MetaReferencia> MetaReferencia { get; set; }
    }
}
