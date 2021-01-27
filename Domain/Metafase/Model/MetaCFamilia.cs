using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCFamilia
    {
        public MetaCFamilia()
        {
            MetaCCategoria = new HashSet<MetaCCategoria>();
            MetaTiendaPotencialFamilia = new HashSet<MetaTiendaPotencialFamilia>();
        }

        public int CdFamilia { get; set; }
        public int CdSector { get; set; }
        public string DsFamilia { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCSector CdSectorNavigation { get; set; }
        public virtual ICollection<MetaCCategoria> MetaCCategoria { get; set; }
        public virtual ICollection<MetaTiendaPotencialFamilia> MetaTiendaPotencialFamilia { get; set; }
    }
}
