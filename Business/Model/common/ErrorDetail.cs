using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;

namespace Business.Model.common
{
    public class ErrorDetail
    {
        #region properties
        public int StatusCode { get; set; }

        public int IdTransaction { get; set; }
        ///
        //public List<ItemError> Errores { get; set; }
        ///
        public string Error { get; set; }
        #endregion

        ///
        public ErrorDetail()
        {

        }
        ///
        public ErrorDetail(IEnumerable<ValidationResult> validationResults)
        {
            StatusCode = (int)HttpStatusCode.BadRequest;
            //Errores = new List<ItemError>();
            foreach (var validationResult in validationResults)
            {
                Error += validationResult.MemberNames.Single();
            }
        }
        ///
        private ErrorDetail(int statusCode, string message)
        {
            this.StatusCode = statusCode;
            this.Error = message;
        }
        ///
       
    }
    public class ItemError
    {
        ///
        public string Codigo { get; set; }
        ///
        public string Message { get; set; }
    }
}
