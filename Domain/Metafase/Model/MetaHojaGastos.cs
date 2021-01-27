using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaHojaGastos
    {
        public MetaHojaGastos()
        {
            MetaHojaGastosFecha = new HashSet<MetaHojaGastosFecha>();
        }

        public Guid CdHoja { get; set; }
        public int CdEmpleado { get; set; }
        public int? NmHoja { get; set; }
        public int CdEstado { get; set; }
        public DateTime FcInicio { get; set; }
        public DateTime FcFin { get; set; }
        public string DsObservaciones { get; set; }
        public decimal? NmKmMensual { get; set; }
        public decimal? NmGastoVisa { get; set; }
        public decimal? NmGastoSolred { get; set; }
        public decimal? NmOtrosAjustes { get; set; }
        public string DsOtrosAjustes { get; set; }
        public decimal? NmAnticipo { get; set; }
        public decimal? NmPieA { get; set; }
        public decimal? NmPieB { get; set; }
        public DateTime? FcAltaSistema { get; set; }
        public string DsUseralta { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }

        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaCEstadoHojaGastos CdEstadoNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual MetaHojaGastosInforme MetaHojaGastosInforme { get; set; }
        public virtual ICollection<MetaHojaGastosFecha> MetaHojaGastosFecha { get; set; }
    }
}
