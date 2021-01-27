using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.User.DTO
{
    public class AppUser
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public bool bloqueado { get; set; }
    }
}
