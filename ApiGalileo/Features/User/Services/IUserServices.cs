using ApiGalileo.Features.Base;
using ApiGalileo.Features.User.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.User.Services
{
    public interface IUserServices
    {
        Task<ResponseBase> AddUser(UserAddRequest request);

        Task<List<UserRespose>> GetAllUser();

        Task<List<AppUser>> GetUserByFilter(UserFilterRequest request);

        Task<UserRespose> GetUserById(Guid iduser);

        Task<ResponseBase> SetUser(UserSetRequest request);

        Task<ResponseBase> DeleteUser(Guid request);
    }
}
