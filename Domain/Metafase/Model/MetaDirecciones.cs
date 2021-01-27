using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaDirecciones
    {
        public MetaDirecciones()
        {
            MetaEmpleado = new HashSet<MetaEmpleado>();
            MetaTienda = new HashSet<MetaTienda>();
        }

        public int CdDir { get; set; }
        public string CdPais { get; set; }
        public string DsLindir1 { get; set; }
        public string DsLindir2 { get; set; }
        public string DsLindir3 { get; set; }
        public string CdTvia { get; set; }
        public string DsVia { get; set; }
        public string DsNumvia { get; set; }
        public string DsEscalera { get; set; }
        public string DsPiso { get; set; }
        public string DsPuerta { get; set; }
        public string CdCpostal { get; set; }
        public string CdProv { get; set; }
        public string CdMuni { get; set; }
        public string UserName { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCMunicipio Cd { get; set; }
        public virtual MetaCPais CdPaisNavigation { get; set; }
        public virtual MetaCProvincia CdProvNavigation { get; set; }
        public virtual MetaCTvias CdTviaNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
        public virtual ICollection<MetaEmpleado> MetaEmpleado { get; set; }
        public virtual ICollection<MetaTienda> MetaTienda { get; set; }
    }
}
