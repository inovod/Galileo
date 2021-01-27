using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaInformeQuery
    {
        public int CdQuery { get; set; }
        public int CdInforme { get; set; }
        public string DsComando { get; set; }
        public string DsHoja { get; set; }
        public int NmColumna { get; set; }
        public string DsDiagrama { get; set; }

        public virtual MetaInforme CdInformeNavigation { get; set; }
    }
}
