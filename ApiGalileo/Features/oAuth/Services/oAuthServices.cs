using ApiGalileo.Features.oAuth.DTO;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Repository.Identity.interfaces;
using Domain.Identity.Model;
namespace ApiGalileo.Features.oAuth.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class oAuthServices : IoAuthServices
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IIdentityUnitOfWork _indentityOfWork;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        /// <param name="configuration"></param>
        /// <param name="indentityOfWork"></param>
        public oAuthServices(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            IIdentityUnitOfWork indentityOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _indentityOfWork = indentityOfWork;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        public async Task<TokenResponse_Dto> LoginAsync(UserLogin_Dto userLogin)
        {
            TokenResponse_Dto _responseToken;
            var result = await _signInManager.PasswordSignInAsync(userLogin.Login, userLogin.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var _userInfo = await GetInfoUserAsync(userLogin.Login);
                if (_userInfo.LockOutEnabled)
                {
                    var _clains = CrearClaisUsuario(_userInfo);
                    var _token = GenerateToken(_clains);
                    var _RefresToken = GenerateRefreshToken();

                    _responseToken = new TokenResponse_Dto()
                    {
                        token = _token.Token,
                        refresh_token = _RefresToken,
                        ValidateToken = _token.ValidateToken.ToString(),
                        invalid_request = ""
                    };
                    await SaveTokenRefres(_responseToken, _userInfo.Id);

                    return _responseToken;
                }
                else
                {
                    _responseToken = new TokenResponse_Dto()
                    {
                        token = "",
                        refresh_token = "",
                        invalid_request = "Usuario Bloqueado"
                    };
                }
                
            }
            else
            {
                _responseToken = new TokenResponse_Dto()
                {
                    token = "",
                    refresh_token = "",
                    invalid_request = "Login Incorrecto"
                };
            }
            return _responseToken;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="refresToken"></param>
        /// <returns></returns>
        public async Task<TokenResponse_Dto> RefresAsync(RefreshToken_Dto refresToken)
        {
            TokenResponse_Dto _responseToken;
            try
            {
                var principal = GetPrincipalFromExpiredToken(refresToken.Token);
                var userId = principal.Identity.Name;
                bool _UsuarioBloqueado = await IsBloquedUser(principal.Identity.Name);
                if (!_UsuarioBloqueado)
                {
                    var savedRefreshToken = GetRefreshToken(userId);
                    if (savedRefreshToken != refresToken.TokenRefres)
                        throw new SecurityTokenException("Invalid refresh token");
                    var newJwtToken = GenerateToken(principal.Claims);
                    var newRefreshToken = GenerateRefreshToken();

                    TokenResponse_Dto _token = new TokenResponse_Dto()
                    {
                        token = refresToken.Token,
                        refresh_token = newRefreshToken
                    };

                    await SaveTokenRefres(_token, userId);

                    _responseToken = new TokenResponse_Dto()
                    {
                        token = refresToken.Token,
                        refresh_token = newRefreshToken,
                        invalid_request = ""
                    };
                }
                else
                {
                    _responseToken = new TokenResponse_Dto()
                    {
                        token = "",
                        refresh_token = "",
                        invalid_request = "Usuario Bloqueado"
                    };
                }

               
                return _responseToken;
            }
            catch (System.Exception)
            {
                _responseToken = new TokenResponse_Dto()
                {
                    token = "",
                    refresh_token = "",
                    invalid_request = "No se ha podido realizar la operacion"
                };
                return _responseToken;
            }
        }
        /// <summary>
        /// s
        /// </summary>
        /// <param name="token"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public async Task<string> SaveTokenRefres(TokenResponse_Dto token, string idUser)
        {
            try
            {
                //Buscamos existe un registro para ese usuario con ese token refres en la base de datos
                //si existe tendremos que actualizar ese registro si no existe lo creamos
                //.FindAllAsync(x => x.CdEmpleado == itemTienda.CD_EMPLEADO).Result.FirstOrDefault();
                var _userTokenEntity = _indentityOfWork.UserTokenRepository.FindAllAsync(x => x.UserId == idUser).Result.FirstOrDefault();
                if (_userTokenEntity != null)
                {
                    await _indentityOfWork.UserTokenRepository.DeleteAsync(_userTokenEntity.Id);
                    await _indentityOfWork.UserTokenRepository.CreateAsync(new UserToken()
                    {
                        Id = Guid.NewGuid(),
                        UserId = idUser,
                        RefresToken = token.refresh_token
                    });
                }
                else
                {
                    await _indentityOfWork.UserTokenRepository.CreateAsync(new UserToken()
                    {
                        Id = Guid.NewGuid(),
                        UserId = idUser,
                        RefresToken = token.refresh_token
                    });
                }

            }
            catch (System.Exception e)
            {
                var excpetion = e;
            }

            return "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public IEnumerable<Claim> CrearClaisUsuario(UserInfo_Dto userInfo)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            return claims;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        public Token_Dto GenerateToken(IEnumerable<Claim> claims)
        {
            Token_Dto token = new Token_Dto();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            
            var jwt = new JwtSecurityToken(issuer: "Blinkingcaret",
                audience: "Everyone",
                claims: claims, //the user's claims, for example new Claim[] { new Claim(ClaimTypes.Name, "The username"), //... 
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: creds
            );
            return new Token_Dto()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(jwt),
                ValidateToken = jwt.ValidFrom.ToString()
            };

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userlogin"></param>
        /// <returns></returns>
        public async Task<UserInfo_Dto> GetInfoUserAsync(string userlogin)
        {
            UserInfo_Dto _userInfor;
            ApplicationUser _userApp = await _userManager.FindByNameAsync(userlogin);
            if (_userApp != null)
            {
                _userInfor = new UserInfo_Dto(_userApp.Id.ToString() ,_userApp.LockoutEnabled);
                return _userInfor;
            }
            else { return null; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"])),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string GetRefreshToken(string idUser)
        {
            var _userIdentity = _indentityOfWork.UserTokenRepository.FindAllAsync(x => x.UserId == idUser).Result.FirstOrDefault();
            if (_userIdentity != null)
                return _userIdentity.RefresToken;
            else
                return "";
        }

        private async Task<bool> IsBloquedUser(string idUser)
        {

            //_userManager.GetLockoutEnabledAsync()
            ApplicationUser _appUser = await _userManager.FindByIdAsync(idUser);
            if (_appUser != null)
                return _appUser.LockoutEnabled;
            else
                return true;
        }
    }
}
