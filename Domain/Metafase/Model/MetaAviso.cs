using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaAviso
    {
        public Guid CdAviso { get; set; }
        public string DsTitulo { get; set; }
        public string DsDescripcion { get; set; }
        public bool ItArchivado { get; set; }
        public DateTime? FcInicio { get; set; }
        public DateTime? FcFin { get; set; }
        public int? CdCliente { get; set; }
        public int? CdCanal { get; set; }
        public int? CdEnsena { get; set; }
        public int? CdCadena { get; set; }
        public int? CdZona { get; set; }
        public int? CdTienda { get; set; }
        public int? CdEmpRemitente { get; set; }
        public int? CdEmpDestinatario { get; set; }
        public string ItEmail { get; set; }
        public int? CdAvisoManual { get; set; }
        public int? CdTipoAviso { get; set; }

        public virtual MetaCEnsena Cd { get; set; }
        public virtual MetaCCanal CdCanalNavigation { get; set; }
        public virtual MetaCliente CdClienteNavigation { get; set; }
        public virtual MetaEmpleado CdEmpDestinatarioNavigation { get; set; }
        public virtual MetaEmpleado CdEmpRemitenteNavigation { get; set; }
        public virtual MetaTienda CdTiendaNavigation { get; set; }
        public virtual MetaCTipoAviso CdTipoAvisoNavigation { get; set; }
        public virtual MetaCZona CdZonaNavigation { get; set; }
    }
}
