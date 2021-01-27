using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaVisita
    {
        public MetaVisita()
        {
            MetaAnotacion = new HashSet<MetaAnotacion>();
            MetaVisitaObjeto = new HashSet<MetaVisitaObjeto>();
        }

        public Guid Rowguid { get; set; }
        public int CdTienda { get; set; }
        public DateTime? FcPlanificacionInicial { get; set; }
        public DateTime FcVisita { get; set; }
        public DateTime? FcFinVisita { get; set; }
        public int? CdCausaNoVisita { get; set; }
        public string DsCausaNoVisita { get; set; }
        public Guid CdTarea { get; set; }
        public int CdEmpleado { get; set; }
        public int CdCliente { get; set; }
        public bool ItHistorico { get; set; }

        public virtual MetaTarea Cd { get; set; }
        public virtual MetaCausaNoVisita CdCausaNoVisitaNavigation { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual MetaVisitaVuelta MetaVisitaVuelta { get; set; }
        public virtual ICollection<MetaAnotacion> MetaAnotacion { get; set; }
        public virtual ICollection<MetaVisitaObjeto> MetaVisitaObjeto { get; set; }
    }
}
