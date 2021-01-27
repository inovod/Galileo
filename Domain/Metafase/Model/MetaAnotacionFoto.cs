using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaAnotacionFoto
    {
        public Guid CdAnotacionFoto { get; set; }
        public Guid CdAnotacion { get; set; }
        public int CdTipoObservacion { get; set; }
        public byte ItFtp { get; set; }
        public bool? ItRelAntDesp { get; set; }
        public bool? ItRelAmpliacion { get; set; }
        public bool ItDestacado { get; set; }
        public byte ItEstado { get; set; }

        public virtual MetaAnotacionTipo Cd { get; set; }
        public virtual MetaFotografiaFoto MetaFotografiaFoto { get; set; }
    }
}
