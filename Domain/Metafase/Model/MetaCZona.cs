using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCZona
    {
        public MetaCZona()
        {
            MetaAviso = new HashSet<MetaAviso>();
            MetaCuestionario = new HashSet<MetaCuestionario>();
            MetaMaterialVisibilidad = new HashSet<MetaMaterialVisibilidad>();
            MetaPromocion = new HashSet<MetaPromocion>();
            MetaSurtido = new HashSet<MetaSurtido>();
            MetaUsuarioClienteZona = new HashSet<MetaUsuarioClienteZona>();
            MetaZonaMunicipios = new HashSet<MetaZonaMunicipios>();
        }

        public int CdZona { get; set; }
        public string DsZona { get; set; }
        public int? CdCliente { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual ICollection<MetaAviso> MetaAviso { get; set; }
        public virtual ICollection<MetaCuestionario> MetaCuestionario { get; set; }
        public virtual ICollection<MetaMaterialVisibilidad> MetaMaterialVisibilidad { get; set; }
        public virtual ICollection<MetaPromocion> MetaPromocion { get; set; }
        public virtual ICollection<MetaSurtido> MetaSurtido { get; set; }
        public virtual ICollection<MetaUsuarioClienteZona> MetaUsuarioClienteZona { get; set; }
        public virtual ICollection<MetaZonaMunicipios> MetaZonaMunicipios { get; set; }
    }
}
