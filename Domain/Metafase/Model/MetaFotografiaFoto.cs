using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaFotografiaFoto
    {
        public Guid CdAnotacionFoto { get; set; }
        public byte[] FsFotografia { get; set; }
        public byte[] FsMiniatura { get; set; }
        public Guid CdAnotacion { get; set; }

        public virtual MetaAnotacionFoto CdAnotacionFotoNavigation { get; set; }
        public virtual MetaAnotacion CdAnotacionNavigation { get; set; }
    }
}
