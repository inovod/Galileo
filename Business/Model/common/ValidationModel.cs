using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;

namespace Business.Model.common
{
   public  class ValidationModel : IValidationModel
    {
        //protected List<DictionaryEntry> _dictionary;

        internal List<ValidationResultBase> ValidationResultsBase { get; set; } = new List<ValidationResultBase>();

        public ValidationModel() { }

        public ValidationModel(List<ValidationResultBase> validationResults)
        {
            ValidationResultsBase = validationResults;
        }

        public virtual IEnumerable<ValidationResultBase> Validate(ValidationContext validationContext)
        {
            return ValidationResultsBase;
        }

        //public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext, List<DictionaryEntry> dictionary)
        //{
        //    _dictionary = dictionary;
        //    return ValidationResults;
        //}

        public IEnumerable<ValidationResultBase> GetValidationsErrors()
        {
            return ValidationResultsBase;
        }

        public bool HasValidationErrors()
        {
            return ValidationResultsBase.Count > 0;
        }
    }
}
