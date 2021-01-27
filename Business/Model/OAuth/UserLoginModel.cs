using Business.Model.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.OAuth
{
    public class UserLoginModel : ValidationModel
    {
        public string token { get; set; }
        public string refresh_token { get; set; }
        public string invalid_request { get; set; }
        public string ValidateToken { get; set; }

        public  override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }
}
