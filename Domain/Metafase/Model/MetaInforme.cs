using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaInforme
    {
        public MetaInforme()
        {
            MetaInformeCliente = new HashSet<MetaInformeCliente>();
            MetaInformeClienteWeb = new HashSet<MetaInformeClienteWeb>();
            MetaInformeQuery = new HashSet<MetaInformeQuery>();
            MetaPermisosInforme = new HashSet<MetaPermisosInforme>();
            MetaVistaInforme = new HashSet<MetaVistaInforme>();
        }

        public int CdInforme { get; set; }
        public string DsDescripcion { get; set; }
        public int? CdCategoria { get; set; }
        public bool ItSistema { get; set; }

        public virtual MetaCCategoriaExplotacion CdCategoriaNavigation { get; set; }
        public virtual MetaInformePlantilla MetaInformePlantilla { get; set; }
        public virtual ICollection<MetaInformeCliente> MetaInformeCliente { get; set; }
        public virtual ICollection<MetaInformeClienteWeb> MetaInformeClienteWeb { get; set; }
        public virtual ICollection<MetaInformeQuery> MetaInformeQuery { get; set; }
        public virtual ICollection<MetaPermisosInforme> MetaPermisosInforme { get; set; }
        public virtual ICollection<MetaVistaInforme> MetaVistaInforme { get; set; }
    }
}
