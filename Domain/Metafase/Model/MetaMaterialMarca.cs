using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaMaterialMarca
    {
        public int CdMaterial { get; set; }
        public int CdMarca { get; set; }
        public int CdCliente { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaMarca Cd { get; set; }
        public virtual MetaMaterialVisibilidad CdMaterialNavigation { get; set; }
    }
}
