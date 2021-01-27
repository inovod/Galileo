using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AlturaCdm
    {
        public DateTime? Mes { get; set; }
        public string DsPregunta { get; set; }
        public string Altura { get; set; }
        public int? CdCliente { get; set; }
        public Guid Clave { get; set; }
        public int? CdUsuario { get; set; }
        public int? Cantidad { get; set; }
        public int? Pdv { get; set; }
    }
}
