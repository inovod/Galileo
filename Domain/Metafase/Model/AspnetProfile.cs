﻿using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetProfile
    {
        public Guid UserId { get; set; }
        public string PropertyNames { get; set; }
        public string PropertyValuesString { get; set; }
        public byte[] PropertyValuesBinary { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetUsers User { get; set; }
    }
}
