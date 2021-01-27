using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaPersonalTrato
    {
        public int CdPersona { get; set; }
        public int CdTienda { get; set; }
        public int CdEmpleado { get; set; }
        public string ItTrato { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaTiendaPersonal Cd { get; set; }
        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
    }
}
