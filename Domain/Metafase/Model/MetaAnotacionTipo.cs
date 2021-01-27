using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaAnotacionTipo
    {
        public MetaAnotacionTipo()
        {
            MetaAnotacionFoto = new HashSet<MetaAnotacionFoto>();
        }

        public Guid CdAnotacion { get; set; }
        public int CdTipoObservacion { get; set; }
        public string DsObservacion { get; set; }
        public string DsObservacionDef { get; set; }
        public string DsComentario { get; set; }
        public byte ItValoracion { get; set; }
        public bool ItDestacado { get; set; }
        public byte ItEstado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MetaAnotacion CdAnotacionNavigation { get; set; }
        public virtual MetaCTipoObservacion CdTipoObservacionNavigation { get; set; }
        public virtual ICollection<MetaAnotacionFoto> MetaAnotacionFoto { get; set; }
    }
}
