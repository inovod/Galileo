using System;
using System.Collections.Generic;

namespace Domain.Identity.Model
{
    public partial class GalLogTransactions
    {
        public int Idtr { get; set; }
        public int Idapp { get; set; }
        public int? Ioper { get; set; }
        public DateTime? Dinserted { get; set; }
        public string Voper { get; set; }
        public int? Idstatuscode { get; set; }
    }
}
