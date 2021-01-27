using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaInformePlantilla
    {
        public int CdInforme { get; set; }
        public byte[] FsPlantilla { get; set; }
        public string DsExtension { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaInforme CdInformeNavigation { get; set; }
    }
}
