using Business.Interfaces;
using Business.Logs;
using Business.Model.common;
using Domain.Identity.Model;
using Microsoft.Extensions.Logging.Abstractions;
using Repository.Identity.interfaces;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Transactions;
using ErrorManager = Business.Logs.ErrorManager;
namespace Business.Services
{
    public class SRLogTransaction : ErrorManager , ILogTransaction
    {
        private readonly IIdentityUnitOfWork _indentityOfWork;
        public SRLogTransaction(IIdentityUnitOfWork indentityOfWork)
        {
            _indentityOfWork = indentityOfWork;
        }

        public async Task<int> AddLogTransaction(CError cError )
        {
            try
            {
                int _idtransaction = 0;
                foreach (var errorDet in cError.ErrorDetails)
                {
                    await _indentityOfWork.LogTransactionErrRepository.InsertEntity(new GalLogTransactionsErr()
                    {
                        Idtr = errorDet.IdTransaction,
                        Ierror = errorDet.IdError.ToString(),
                        Verror = errorDet.Error + " - Modelo: " + errorDet.ModelInformation ,
                        Dinserted = DateTime.Now,
                    });
                    await _indentityOfWork.LogTransactionErrRepository.SaverChangeAsyc();
                    _idtransaction = errorDet.IdTransaction;
                }
                GalLogTransactions logTransaction =  await _indentityOfWork.LogTransactionRepository.GetAsync(_idtransaction);
                if(logTransaction != null)
                {
                    logTransaction.Idstatuscode = (int)HttpStatusCode.InternalServerError;
                    await _indentityOfWork.LogTransactionRepository.UpdateAsync(logTransaction);
                }
                return 0;
            }
            catch (CError ce)
            {
                throw AddError(0, Errores._10021_SRBase_AddLogTransaction, 10021, ce, MethodBase.GetCurrentMethod());
            }
            catch (Exception e)
            {
                throw AddError(0, Errores._10021_SRBase_AddLogTransaction, 10021, e, MethodBase.GetCurrentMethod());
            }
        }
        public async Task<int> AddLogTransaction(ValidationModel validationModel)
        {
            try {
                GalLogTransactionsErr logTransactionErr;
                int _idTransaction = 0;
                var validationResults = validationModel.GetValidationsErrors();
                foreach(var iResult in validationResults)
                {

                    logTransactionErr = new GalLogTransactionsErr();
                    logTransactionErr.Idtr = iResult.IDTR;
                    logTransactionErr.Ierror = iResult.ErrorMessage;
                    logTransactionErr.Verror = iResult.MemberNames.Single();
                    logTransactionErr.Dinserted = DateTime.Now;
                    await _indentityOfWork.LogTransactionErrRepository.InsertEntity(logTransactionErr);
                    await _indentityOfWork.LogTransactionErrRepository.SaverChangeAsyc();
                    _idTransaction = iResult.IDTR;

                }
                GalLogTransactions logTransaction = await _indentityOfWork.LogTransactionRepository.GetAsync(_idTransaction);
                if (logTransaction != null)
                {
                    logTransaction.Idstatuscode = (int)HttpStatusCode.BadRequest;
                    await _indentityOfWork.LogTransactionRepository.UpdateAsync(logTransaction);
                }

                var errorDetails = new ErrorDetail(validationResults);
                return 0;
            }
            catch (CError ce)
            {
                throw AddError(0, Errores._10021_SRBase_AddLogTransaction, 10021, ce, MethodBase.GetCurrentMethod());
            }
            catch (Exception e)
            {
                throw AddError(0, Errores._10021_SRBase_AddLogTransaction, 10021, e, MethodBase.GetCurrentMethod());
            }
            
        }
    }
}
