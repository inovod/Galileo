using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaDocumento
    {
        public MetaDocumento()
        {
            MetaCartaVentasDocumentos = new HashSet<MetaCartaVentasDocumentos>();
        }

        public int CdDocumento { get; set; }
        public string DsDocumento { get; set; }
        public string DsDescripcion { get; set; }
        public string DsRutaDocumento { get; set; }
        public int CdTipoDocumento { get; set; }
        public string UserName { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaCTipoDocumento CdTipoDocumentoNavigation { get; set; }
        public virtual AspnetUsers UserNameNavigation { get; set; }
        public virtual ICollection<MetaCartaVentasDocumentos> MetaCartaVentasDocumentos { get; set; }
    }
}
