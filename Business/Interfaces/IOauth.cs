using Business.Logs;
using Business.Model.common;
using Business.Model.OAuth;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IOauth 
    {
        Task<ValidationModel> LoginAsync(LoginRequest userLogin);
        Task<ValidationModel> RefresAsync(RefresTokenModel refresToken);
        Task<ValidationModel> ResetPassword(ResetLoginModel resetLogin);
    }
}
