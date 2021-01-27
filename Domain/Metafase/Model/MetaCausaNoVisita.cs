using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCausaNoVisita
    {
        public MetaCausaNoVisita()
        {
            MetaVisita = new HashSet<MetaVisita>();
        }

        public int CdCausaNoVisita { get; set; }
        public string DsCausaNoVisita { get; set; }
        public string ItRecuperable { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<MetaVisita> MetaVisita { get; set; }
    }
}
