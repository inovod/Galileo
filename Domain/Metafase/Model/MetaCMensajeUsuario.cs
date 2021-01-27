using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaCMensajeUsuario
    {
        public int CdCMensajeUsuario { get; set; }
        public string DsCMensajeUsuario { get; set; }
        public byte ItTipoMensaje { get; set; }
        public Guid Rowguid { get; set; }
    }
}
