using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaRuta
    {
        public MetaRuta()
        {
            InverseCdRutaSiguienteNavigation = new HashSet<MetaRuta>();
            MetaTarea = new HashSet<MetaTarea>();
            MetaTiendasRuta = new HashSet<MetaTiendasRuta>();
        }

        public int CdRuta { get; set; }
        public string DsRuta { get; set; }
        public byte CdPeriodicidad { get; set; }
        public string ItTipoJornada { get; set; }
        public int? CdRutaSiguiente { get; set; }
        public string DsLugarPernoctacion { get; set; }
        public int? CdEmpleado { get; set; }
        public int CdCliente { get; set; }
        public DateTime FcAlta { get; set; }
        public DateTime? FcBaja { get; set; }
        public DateTime? FcUltmodif { get; set; }
        public DateTime FcAltaSistema { get; set; }
        public string DsUseralta { get; set; }
        public string DsUsermodif { get; set; }
        public string DsUserbaja { get; set; }
        public Guid Rowguid { get; set; }
        public bool ItHistorico { get; set; }
        public string DsNombreEquipo { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaEmpleado CdEmpleadoNavigation { get; set; }
        public virtual MetaCPeriodicidad CdPeriodicidadNavigation { get; set; }
        public virtual MetaRuta CdRutaSiguienteNavigation { get; set; }
        public virtual AspnetUsers DsUseraltaNavigation { get; set; }
        public virtual AspnetUsers DsUserbajaNavigation { get; set; }
        public virtual AspnetUsers DsUsermodifNavigation { get; set; }
        public virtual ICollection<MetaRuta> InverseCdRutaSiguienteNavigation { get; set; }
        public virtual ICollection<MetaTarea> MetaTarea { get; set; }
        public virtual ICollection<MetaTiendasRuta> MetaTiendasRuta { get; set; }
    }
}
