using System;
using System.Collections.Generic;

namespace Domain.Identity.Model
{
    public partial class GalLogTransactionsErr
    {
        public int Iderror { get; set; }
        public int? Idtr { get; set; }
        public string Ierror { get; set; }
        public string Verror { get; set; }
        public int? Idkey { get; set; }
        public DateTime? Dinserted { get; set; }
        public string Verrorshort { get; set; }
    }
}
