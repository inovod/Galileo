using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaConfiguracionUsuario
    {
        public int CdConfiguracionUsuario { get; set; }
        public string CdClave { get; set; }
        public string DsValorDefecto { get; set; }
        public string DsDescripcion { get; set; }
        public bool ItMantenible { get; set; }
        public byte? ItAplicacion { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetApplications Application { get; set; }
    }
}
