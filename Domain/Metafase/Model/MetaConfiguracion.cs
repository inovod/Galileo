using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaConfiguracion
    {
        public int CdConfiguracion { get; set; }
        public string CdClave { get; set; }
        public string DsValor { get; set; }
        public string DsDescripcion { get; set; }
        public byte ItMantenible { get; set; }
        public Guid ApplicationId { get; set; }
        public string UserName { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
    }
}
