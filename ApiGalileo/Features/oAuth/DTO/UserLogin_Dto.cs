using Business.Model.common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace ApiGalileo.Features.oAuth.DTO
{
    public class UserLogin_Dto : ValidationModel
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }
}
