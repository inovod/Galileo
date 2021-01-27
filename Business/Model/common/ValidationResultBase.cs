using System.ComponentModel.DataAnnotations;

namespace Business.Model.common
{
    public class ValidationResultBase : ValidationResult
    {
        internal int IDTR { get; set; }
        internal int iStatusError { get; set; }
        public ValidationResultBase(ValidationResult validationResult, int statusError , int idtr) : base(validationResult)
        {
            iStatusError = statusError;
            IDTR = idtr;
        }

        public int GetStatusCode() { return iStatusError; }

        public int GetIdTr() { return IDTR; }
    }
}
