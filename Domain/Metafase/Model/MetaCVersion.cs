using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCVersion
    {
        public DateTime FcVersion { get; set; }
        public short NmPrim { get; set; }
        public short NmSec { get; set; }
        public int NmRev { get; set; }
        public int NmComp { get; set; }
        public string DsAplicacion { get; set; }
        public Guid Rowguid { get; set; }
    }
}
