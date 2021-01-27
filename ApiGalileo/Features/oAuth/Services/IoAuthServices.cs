using ApiGalileo.Features.oAuth.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiGalileo.Features.oAuth.Services
{
    public interface IoAuthServices
    {
        Task<TokenResponse_Dto> LoginAsync(UserLogin_Dto userLogin);

        Task<TokenResponse_Dto> RefresAsync(RefreshToken_Dto refresToken);

        Task<string> SaveTokenRefres(TokenResponse_Dto token, string idUser);

        IEnumerable<Claim> CrearClaisUsuario(UserInfo_Dto userInfo);

        Token_Dto GenerateToken(IEnumerable<Claim> claims);

        Task<UserInfo_Dto> GetInfoUserAsync(string userlogin);

        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);

        string GetRefreshToken(string idUser);


    }
}
