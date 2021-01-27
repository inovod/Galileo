using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class LogAurora
    {
        public int IdLog { get; set; }
        public string Json { get; set; }
        public Guid? GuidVisita { get; set; }
    }
}
