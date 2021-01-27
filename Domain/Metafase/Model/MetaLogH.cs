using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaLogH
    {
        public Guid Rowguid { get; set; }
        public string DsAccion { get; set; }
        public DateTime FcFecha { get; set; }
        public bool ItSistema { get; set; }
        public int CdTipoRegistro { get; set; }
        public string UserName { get; set; }
        public string Hostname { get; set; }
        public bool? ItHistorico { get; set; }

        public virtual MetaCTipoRegistro CdTipoRegistroNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
    }
}
