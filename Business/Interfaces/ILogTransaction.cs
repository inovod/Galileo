using Business.Logs;
using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ILogTransaction
    {
        Task<int> AddLogTransaction(CError cError);

        Task<int> AddLogTransaction(ValidationModel validationModel);

    }
}
