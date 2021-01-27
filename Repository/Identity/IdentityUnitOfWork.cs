using System;
using System.Collections.Generic;
using System.Text;
using Domain.Identity;
using Domain.Identity.Model;
using Repository.Identity.interfaces;
using Repository.interfaces;

namespace Repository.Identity
{
    public class IdentityUnitOfWork : IIdentityUnitOfWork
    {
        private ApplicationDbContext _context;
        private IGenericDataRespositoryBase<UserToken, Guid> _userTokenRepository;
        private IGenericDataRespositoryBase<UserInfo, Guid> _userInfoRepository;
        private IGenericDataRespositoryBase<GalLogTransactions, int> _galLogTransactionsRepository;
        private IGenericDataRespositoryBase<GalLogTransactionsErr, int> _galLogTransactionsErrRepository;
        public IdentityUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericDataRespositoryBase<UserToken,Guid> UserTokenRepository
        {
            get
            {
                return _userTokenRepository = _userTokenRepository ?? new IdentityRepository<UserToken, Guid>(_context);
            }
        }

        public IGenericDataRespositoryBase<UserInfo, Guid> UserInfoRepository
        {
            get
            {
                return _userInfoRepository = _userInfoRepository ?? new IdentityRepository<UserInfo, Guid>(_context);
            }
        }

        public IGenericDataRespositoryBase<GalLogTransactions,int> LogTransactionRepository
        {
            get
            {
                return _galLogTransactionsRepository = _galLogTransactionsRepository ?? new IdentityRepository<GalLogTransactions, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<GalLogTransactionsErr, int> LogTransactionErrRepository
        {
            get
            {
                return _galLogTransactionsErrRepository = _galLogTransactionsErrRepository ?? new IdentityRepository<GalLogTransactionsErr, int>(_context);
            }
        }

    }
}
