using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaVisitaDisponible
    {
        public Guid Rowguid { get; set; }
        public int? CdTienda { get; set; }
        public int? ItEstado { get; set; }
        public DateTime? FcPeticion { get; set; }
        public Guid? CdTarea { get; set; }
        public int? CdEmpleado { get; set; }

        public virtual MetaTarea Cd { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
    }
}
