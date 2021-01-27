using System;
using System.Collections.Generic;

namespace Domain.Identity.Model
{
    public partial class UserInfo
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public bool Bloqueado { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
