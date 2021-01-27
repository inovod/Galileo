using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCartaVentasEnsena
    {
        public int CdCartaVentasEnsena { get; set; }
        public int CdCartaVentas { get; set; }
        public int CdEnsena { get; set; }
        public int CdCadena { get; set; }
        public string DsObjetivo { get; set; }
        public string DsLanzamiento { get; set; }
        public string DsCompetencia { get; set; }
        public string DsPromociones { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaCartaVentas CdCartaVentasNavigation { get; set; }
    }
}
