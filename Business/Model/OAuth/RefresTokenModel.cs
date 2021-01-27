using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.OAuth
{
    public class RefresTokenModel : BaseModel
    {
        public string TokenRefres { get; set; }
        public string Token { get; set; }

        
    }
}
