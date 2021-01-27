using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoObservacion
    {
        public MetaCTipoObservacion()
        {
            InverseCdTipoSuperiorNavigation = new HashSet<MetaCTipoObservacion>();
            MetaAnotacionTipo = new HashSet<MetaAnotacionTipo>();
        }

        public int CdTipoObservacion { get; set; }
        public string DsTipoObservacion { get; set; }
        public int? CdTipoSuperior { get; set; }
        public int? CdCliente { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaCTipoObservacion CdTipoSuperiorNavigation { get; set; }
        public virtual ICollection<MetaCTipoObservacion> InverseCdTipoSuperiorNavigation { get; set; }
        public virtual ICollection<MetaAnotacionTipo> MetaAnotacionTipo { get; set; }
    }
}
