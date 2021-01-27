using System;
using System.Collections.Generic;

namespace Domain.Identity.Model
{
    public partial class UserToken
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string RefresToken { get; set; }
    }
}
