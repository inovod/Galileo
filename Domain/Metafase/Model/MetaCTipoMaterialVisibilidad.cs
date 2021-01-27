using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCTipoMaterialVisibilidad
    {
        public MetaCTipoMaterialVisibilidad()
        {
            MetaMaterialVisibilidad = new HashSet<MetaMaterialVisibilidad>();
        }

        public int CdTipoMaterial { get; set; }
        public string DsTipoMaterial { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidad { get; set; }
    }
}
