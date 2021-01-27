using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCuboBi
    {
        public MetaCuboBi()
        {
            MetaCuboBiCliente = new HashSet<MetaCuboBiCliente>();
            MetaCuboBiMedida = new HashSet<MetaCuboBiMedida>();
            MetaPermisosCuboBi = new HashSet<MetaPermisosCuboBi>();
            MetaVistaCuboBi = new HashSet<MetaVistaCuboBi>();
        }

        public int CdCubo { get; set; }
        public string DsDescripcion { get; set; }
        public int? CdCategoria { get; set; }
        public bool ItSistema { get; set; }
        public byte NmCuboOrigen { get; set; }

        public virtual MetaCCategoriaExplotacion CdCategoriaNavigation { get; set; }
        public virtual ICollection<MetaCuboBiCliente> MetaCuboBiCliente { get; set; }
        public virtual ICollection<MetaCuboBiMedida> MetaCuboBiMedida { get; set; }
        public virtual ICollection<MetaPermisosCuboBi> MetaPermisosCuboBi { get; set; }
        public virtual ICollection<MetaVistaCuboBi> MetaVistaCuboBi { get; set; }
    }
}
