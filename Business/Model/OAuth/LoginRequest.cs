using Business.Model.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.OAuth
{
   public class LoginRequest : ValidationModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RequestHttp { get; set; }

        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }
}
