using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetSchemaVersions
    {
        public string Feature { get; set; }
        public string CompatibleSchemaVersion { get; set; }
        public bool IsCurrentVersion { get; set; }
        public Guid Rowguid { get; set; }
    }
}
