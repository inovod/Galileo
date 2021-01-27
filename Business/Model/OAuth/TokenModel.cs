using Business.Model.common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections;
namespace Business.Model.OAuth
{
    public class TokenModel : ValidationModel
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
