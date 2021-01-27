using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaUsuarioEquipo
    {
        public string UserName { get; set; }
        public string DsNombreEquipo { get; set; }
        public Guid Rowguid { get; set; }
        public int CdEmpleado { get; set; }

        public virtual AspnetUsers UserNameNavigation { get; set; }
    }
}
