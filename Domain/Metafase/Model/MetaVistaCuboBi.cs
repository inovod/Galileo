using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaVistaCuboBi
    {
        public MetaVistaCuboBi()
        {
            MetaClienteVistaCuboBi = new HashSet<MetaClienteVistaCuboBi>();
        }

        public int CdVistaCubo { get; set; }
        public int CdCubo { get; set; }
        public string DsConfiguracion { get; set; }
        public string ItDefecto { get; set; }
        public string DsDescripcion { get; set; }
        public string UserName { get; set; }

        public virtual MetaCuboBi CdCuboNavigation { get; set; }
        public virtual ICollection<MetaClienteVistaCuboBi> MetaClienteVistaCuboBi { get; set; }
    }
}
