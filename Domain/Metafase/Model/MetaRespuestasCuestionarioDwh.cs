using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaRespuestasCuestionarioDwh
    {
        public Guid Rowguid { get; set; }

        public virtual MetaRespuestasCuestionario Rowgu { get; set; }
    }
}
