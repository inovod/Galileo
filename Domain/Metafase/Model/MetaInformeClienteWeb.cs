using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaInformeClienteWeb
    {
        public int CdInfClteWeb { get; set; }
        public string UserName { get; set; }
        public int CdInforme { get; set; }
        public string DsNombre { get; set; }
        public DateTime FcAlta { get; set; }
        public byte[] FsInforme { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaInforme CdInformeNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
    }
}
