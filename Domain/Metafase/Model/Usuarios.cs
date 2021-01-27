using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class Usuarios
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
