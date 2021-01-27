using System;
using System.Collections.Generic;

namespace Domain.Metafase.Model
{
    public partial class AspnetUsersInRoles
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid Rowguid { get; set; }

        public virtual AspnetRoles Role { get; set; }
        public virtual AspnetUsers User { get; set; }
    }
}
