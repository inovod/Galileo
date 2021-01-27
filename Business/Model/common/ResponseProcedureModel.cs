using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.common
{
    public class ResponseProcedureModel : ValidationModel
    {
        public string retorno { get; set; } 
        public override IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return base.Validate(validationContext);
        }
    }
}
