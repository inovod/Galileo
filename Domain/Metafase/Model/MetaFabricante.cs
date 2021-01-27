using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaFabricante
    {
        public MetaFabricante()
        {
            MetaCliente = new HashSet<MetaCliente>();
        }

        public int CdFabricante { get; set; }
        public string DsFabricante { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaCliente> MetaCliente { get; set; }
    }
}
