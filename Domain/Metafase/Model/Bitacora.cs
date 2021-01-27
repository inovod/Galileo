using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class Bitacora
    {
        public Guid Rowguid { get; set; }
        public DateTime FcFecha { get; set; }
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string EventType { get; set; }
        public int Status { get; set; }
        public string EventInfo { get; set; }
        public bool ItHistorico { get; set; }
    }
}
