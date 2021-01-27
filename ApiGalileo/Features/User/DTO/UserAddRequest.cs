using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.User.DTO
{
    public class UserAddRequest
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }
    }
}
