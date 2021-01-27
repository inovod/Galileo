using Business.Logs;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Business.Model.common
{
    public class ErrorManager : IErrorManager
    {
        public CError AddError(int idTransaction, string mensajeError, int idMensajeError, MethodBase methodBase, string jsonModel = null)
        {
            var errorDet = new CErrorDet
            {
                IdTransaction = idTransaction,
                Error = mensajeError + " - En la clase: " + methodBase.ReflectedType.Name + " - En el método: " + methodBase.Name,
                IdError = idMensajeError,
                ModelInformation = jsonModel,
                
            };
            var ce = new CError();
            ce.ErrorDetails.Add(errorDet);
            return ce;
        }

        public CError AddError(int idTransaction, string mensajeError, int idMensajeError, CError error, MethodBase methodBase, string jsonModel = null)
        {
            var errorDet = new CErrorDet(error)
            {
                Error = mensajeError + " - En la clase: " + methodBase.ReflectedType.Name + " - En el método: " + methodBase.Name,
                IdError = idMensajeError,
                IdTransaction = idTransaction,
                ModelInformation = jsonModel
            };

            error.ErrorDetails.Add(errorDet);
            return error;
        }

        public CError AddError(int idTransaction, string mensajeError, int idMensajeError, Exception exception, MethodBase methodBase, string jsonModel = null)
        {
            var errorDet = new CErrorDet(exception)
            {
                Error = mensajeError + " - En la clase: " + methodBase.ReflectedType.Name + " - En el método: " + methodBase.Name + " - " + exception.Message + " - " + exception.StackTrace,
                IdError = idMensajeError,
                IdTransaction = idTransaction,
                ModelInformation = jsonModel
            };

            var ce = new CError();
            ce.ErrorDetails.Add(errorDet);
            return ce;
        }
    }
}
