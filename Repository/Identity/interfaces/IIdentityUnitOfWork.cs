using System;
using System.Collections.Generic;
using System.Text;
using Domain.Identity.Model;
using Repository.interfaces;

namespace Repository.Identity.interfaces
{
    public interface IIdentityUnitOfWork
    {
        IGenericDataRespositoryBase<UserToken, Guid> UserTokenRepository { get; }
        IGenericDataRespositoryBase<UserInfo, Guid> UserInfoRepository { get; }
        IGenericDataRespositoryBase<GalLogTransactions, int> LogTransactionRepository { get; }
        IGenericDataRespositoryBase<GalLogTransactionsErr, int> LogTransactionErrRepository { get; }

    }
}
