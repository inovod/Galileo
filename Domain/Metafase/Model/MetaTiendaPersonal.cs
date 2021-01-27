using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTiendaPersonal
    {
        public MetaTiendaPersonal()
        {
            MetaTiendaPersonalTrato = new HashSet<MetaTiendaPersonalTrato>();
        }

        public int CdPersona { get; set; }
        public int CdTienda { get; set; }
        public string DsNombre { get; set; }
        public string DsPuesto { get; set; }
        public string DsTelefono { get; set; }
        public string DsObservaciones { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual ICollection<MetaTiendaPersonalTrato> MetaTiendaPersonalTrato { get; set; }
    }
}
