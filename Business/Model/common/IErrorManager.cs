using Business.Logs;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Business.Model.common
{
   public interface IErrorManager
    {
        ///
        CError AddError(int idTransaction, string mensajeError, int idMensajeError, MethodBase methodBase, string jsonModel = null);
        ///
        CError AddError(int idTransaction, string mensajeError, int idMensajeError, CError error, MethodBase methodBase, string jsonModel = null);
        ///
        CError AddError(int idTransaction, string mensajeError, int idMensajeError, Exception exception, MethodBase methodBase, string jsonModel = null);
    }
}
