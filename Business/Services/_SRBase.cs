using Business.Enums;
using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Domain.Identity.Model;
using Repository.Identity.interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ErrorManager = Business.Logs.ErrorManager;

namespace Business.Services
{
    public class SRBase : ErrorManager
    {
        private readonly IIdentityUnitOfWork _indentityOfWork;
        // private readonly IErrorManager _errorManager;
        internal OperationEnum IdOperation;
        internal int IdTransaction;
        protected string _request;

        public SRBase(IIdentityUnitOfWork indentityOfWork)
        {
            _indentityOfWork = indentityOfWork;
        }


        internal async Task<int> InitOperation(OperationEnum operation, string request)
        {
            try
            {
                IdOperation = operation;
                GalLogTransactions logTransaction = new GalLogTransactions();
                logTransaction.Idapp = 1;
                logTransaction.Ioper = (int)operation;
                logTransaction.Voper = request;
                logTransaction.Dinserted = DateTime.Now;
                await _indentityOfWork.LogTransactionRepository.InsertEntity(logTransaction);
                await _indentityOfWork.LogTransactionRepository.SaverChangeAsyc();
                IdTransaction = logTransaction.Idtr;
                return logTransaction.Idtr;
            }
            catch (CError ce)
            {
                // throw AddError(IdTransaction, Errores._10022_SRBase_InitOperation);
                throw AddError(IdTransaction, Errores._10022_SRBase_InitOperation, 10022, MethodBase.GetCurrentMethod());
            }

        }

        //public virtual async Task<int> AddLogTransaction(CError cError)
        //{
        //    try
        //    {
        //        foreach (var errorDet in cError.ErrorDetails)
        //        {
        //            await _indentityOfWork.LogTransactionErrRepository.InsertEntity(new Domain.Identity.Model.GalLogTransactionsErr()
        //            {
        //                Idtr = errorDet.IdTransaction,
        //                Iderror = errorDet.IdError,
        //                Verror = errorDet.Error + " - Modelo: " + errorDet.ModelInformation
        //            });

        //        }
        //        return IdTransaction;
        //    }
        //    catch (CError ce)
        //    {
        //        throw AddError(IdTransaction, Errores._10021_SRBase_AddLogTransaction, 10021, ce, MethodBase.GetCurrentMethod());
        //        // throw _errorManager.AddError(IdTra)
        //    }
        //    catch (Exception e)
        //    {
        //        throw AddError(IdTransaction, Errores._10021_SRBase_AddLogTransaction, 10021, e, MethodBase.GetCurrentMethod());
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="validationModel"></param>
        /// <returns></returns>
        //public virtual async Task<int> AddLogValidationModel(ValidationModel validationModel)
        //{
        //    try
        //    {
        //        return 1;
        //        //foreach (var errorDet in cError.ErrorDetails)
        //        //{
        //        //    await _indentityOfWork.LogTransactionErrRepository.InsertEntity(new Domain.Identity.Model.GalLogTransactionsErr()
        //        //    {
        //        //        Idtr = errorDet.IdTransaction,
        //        //        Iderror = errorDet.IdError,
        //        //        Verror = errorDet.Error + " - Modelo: " + errorDet.ModelInformation
        //        //    });

        //        //}
        //        //return IdTransaction;
        //    }
        //    catch (CError ce)
        //    {
        //        throw AddError(IdTransaction, Errores._10021_SRBase_AddLogTransaction, 10021, ce, MethodBase.GetCurrentMethod());
        //        // throw _errorManager.AddError(IdTra)
        //    }
        //    catch (Exception e)
        //    {
        //        throw AddError(IdTransaction, Errores._10021_SRBase_AddLogTransaction, 10021, e, MethodBase.GetCurrentMethod());
        //    }
        //}






    }
}
