using Business.Logs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISRBase
    {
        Task<int> AddLogTransaction(CError cError);
    }
}
