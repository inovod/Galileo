using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaClienteFtp
    {
        public int CdCliente { get; set; }
        public string DsFtp { get; set; }
        public string DsUsuario { get; set; }
        public string DsPassword { get; set; }
        public string DsEmail { get; set; }
        public string DsMascaraFoto { get; set; }
        public int NmDuracion { get; set; }
        public string DsRutaLog { get; set; }

        public virtual MetaCliente CdClienteNavigation { get; set; }
    }
}
