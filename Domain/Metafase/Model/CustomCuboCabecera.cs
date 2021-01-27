using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class CustomCuboCabecera
    {
        public Guid Uid { get; set; }
        public string Descripcion { get; set; }
        public string Xml { get; set; }
        public bool? Principal { get; set; }
        public int? Tipo { get; set; }
        public string IdUsuario { get; set; }
        public int? IdCliente { get; set; }
        public string UserName { get; set; }
    }
}
