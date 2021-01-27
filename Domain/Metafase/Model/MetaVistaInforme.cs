using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaVistaInforme
    {
        public int CdVistaInforme { get; set; }
        public int? CdInforme { get; set; }
        public string DsConfiguracion { get; set; }
        public string ItDefecto { get; set; }
        public string DsDescripcion { get; set; }
        public string UserName { get; set; }

        public virtual MetaInforme CdInformeNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
    }
}
