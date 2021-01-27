using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.OAuth
{
    public class UserModel
    {
        public string Id { get; set; }
        public bool LockOutEnabled { get; set; }
    }
}
