using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaTarea
    {
        public MetaTarea()
        {
            MetaVisita = new HashSet<MetaVisita>();
            MetaVisitaDisponible = new HashSet<MetaVisitaDisponible>();
        }

        public Guid CdTarea { get; set; }
        public int CdEmpleado { get; set; }
        public int? CdRuta { get; set; }
        public string DsTitulo { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime FcFin { get; set; }
        public bool? ItDiaCompleto { get; set; }
        public int CdEstadoTarea { get; set; }
        public short CdSituacionTarea { get; set; }
        public int? CdTipoTarea { get; set; }
        public int? CdTipoEvento { get; set; }
        public string DsUbicacion { get; set; }
        public string DsDescripcion { get; set; }
        public string DsObservaciones { get; set; }
        public string DsMotivo { get; set; }
        public string ItPrioritaria { get; set; }
        public string DsReminderInfo { get; set; }
        public string DsRecurrenceInfo { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public DateTime? FcBaja { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUseralta { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public bool ItHistorico { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaCEstadoTarea CdEstadoTareaNavigation { get; set; }
        public virtual MetaRuta CdRutaNavigation { get; set; }
        public virtual MetaCSituacionTarea CdSituacionTareaNavigation { get; set; }
        public virtual MetaCTipoTarea CdTipoTareaNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual ICollection<MetaVisita> MetaVisita { get; set; }
        public virtual ICollection<MetaVisitaDisponible> MetaVisitaDisponible { get; set; }
    }
}
