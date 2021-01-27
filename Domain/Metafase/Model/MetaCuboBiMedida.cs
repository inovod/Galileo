using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCuboBiMedida
    {
        public int CdCubo { get; set; }
        public int CdMedida { get; set; }

        public virtual MetaCuboBi CdCuboNavigation { get; set; }
        public virtual MetaCMedida CdMedidaNavigation { get; set; }
    }
}
