using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model.common
{
   public  interface IValidationModel
    {
        IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext);

        IEnumerable<ValidationResultBase> GetValidationsErrors();

        bool HasValidationErrors();
    }
}
