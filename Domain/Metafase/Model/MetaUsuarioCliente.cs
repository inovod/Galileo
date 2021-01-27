using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class MetaUsuarioCliente
    {
        public string UserName { get; set; }
        public int CdCliente { get; set; }
        public string DsNombre { get; set; }
        public string DsApellido1 { get; set; }
        public string DsApellido2 { get; set; }
        public string DsPuesto { get; set; }
        public int Idenid { get; set; }
    }
}
