using Business.Interfaces;
using Business.Model.common;
using Business.Model.OAuth;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repository.Identity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Linq;
using Domain.Identity.Model;
using Business.Logs;
using Newtonsoft.Json;
using System.Xml.Xsl;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using Business.Enums;
using System.Net;

namespace Business.Services
{
    public class SROauth : SRBase, IOauth
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IIdentityUnitOfWork _indentityOfWork;
        public SROauth(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            IIdentityUnitOfWork indentityOfWork) : base (indentityOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _indentityOfWork = indentityOfWork;
        }
        public async Task<ValidationModel> LoginAsync(LoginRequest loginRequest)
        {
            try
            {

                
                await InitOperation(OperationEnum.LoginGalileo, loginRequest.RequestHttp);

                #region Valdation
                var validationResult = loginRequest.Validate(new ValidationContext(loginRequest)).ToList();
                if(validationResult.Count != 0)
                {
                    return new ValidationModel(validationResult);
                }
                #endregion


                TokenModel _tokenLogin = new TokenModel();
                var result = await _signInManager.PasswordSignInAsync(loginRequest.Login, loginRequest.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _tokenLogin =  await ModifyAccessData(loginRequest.Login);
                }
                else
                {
                    /// _tokenLogin.ValidationResults.Add(new ValidationResult("10001", new[] { Errores._10001_SROauth_Login_Incorrecto }));
                    _tokenLogin.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10001", new[] { Errores._10001_SROauth_Login_Incorrecto }), (int)HttpStatusCode.BadRequest, IdTransaction));
                }

                return _tokenLogin;
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(loginRequest);
                throw AddError(IdTransaction,Errores._10003_SROauth_Error_Generio,10003, e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(loginRequest);
                throw AddError(IdTransaction, Errores._10003_SROauth_Error_Generio, 10003, ex, MethodBase.GetCurrentMethod(), jsonModel);
            }


        }

        public async Task<ValidationModel> RefresAsync(RefresTokenModel refresToken)
        {
            TokenModel _tokenModel = new TokenModel();
            try
            {
                await InitOperation(OperationEnum.Refresh, refresToken.RequestHttp);

                var principal = GetPrincipalFromExpiredToken(refresToken.Token);
                var userId = principal.Identity.Name;
                bool _UsuarioBloqueado = await IsBloquedUser(principal.Identity.Name);
                if (!_UsuarioBloqueado)
                {
                    var savedRefreshToken = GetRefreshToken(userId);
                    if (savedRefreshToken != refresToken.TokenRefres)
                    {
                        // _tokenModel.ValidationResults.Add(new ValidationResult("10010", new[] { Errores._10010_SROauth_Refresh_Token_Invalido }));
                        _tokenModel.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10010", new[] { Errores._10010_SROauth_Refresh_Token_Invalido }), (int)HttpStatusCode.BadRequest, IdTransaction));
                    }
                    else
                    {
                        var newJwtToken = GenerateToken(principal.Claims);
                        var newRefreshToken = GenerateRefreshToken();
                        _tokenModel.token = refresToken.Token;
                        _tokenModel.refresh_token = newRefreshToken;
                        await SaveTokenRefres(_tokenModel, userId);
                    }
                    return _tokenModel;
                }
                else
                {
                    // _tokenModel.ValidationResults.Add(new ValidationResult("10002", new[] { Errores._10002_SROauth_Usuario_Bloqueado }));
                    _tokenModel.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10002", new[] { Errores._10002_SROauth_Usuario_Bloqueado }), (int)HttpStatusCode.BadRequest, IdTransaction));
                }
                return _tokenModel;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction,Errores._10009_SROauth_RefresToken, 10009, e, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(refresToken));
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10009_SROauth_RefresToken, 10009, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(refresToken));
            }
        }

        public async Task<ValidationModel> ResetPassword(ResetLoginModel resetLogin) {
            try {
                await InitOperation(OperationEnum.ResetPassword, resetLogin.RequestHttp);
                TokenModel _tokenLogin = new TokenModel();

                ApplicationUser appUser = await _userManager.FindByNameAsync(resetLogin.UserName);
                if (appUser != null)
                {
                    await _userManager.RemovePasswordAsync(appUser);
                    await _userManager.AddPasswordAsync(appUser, "Temporal123@");
                    _tokenLogin = await ModifyAccessData(resetLogin.UserName);
                }
                else
                {
                    _tokenLogin.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10001"), (int)HttpStatusCode.BadRequest, IdTransaction));
                }
                return _tokenLogin;
            }
            catch(CError ce)
            {
                throw AddError(IdTransaction,Errores._10015_SROauth_ResetPassword, 10015, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(resetLogin.UserName));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10015_SROauth_ResetPassword, 10015, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(resetLogin.UserName));
            }
        }

        #region Functions Private
        private async Task<UserModel> GetInfoUserAsync(string userlogin)
        {
            try
            {
                UserModel _userModel = new UserModel();
                ApplicationUser _userApp = await _userManager.FindByNameAsync(userlogin);
                if (_userApp != null)
                {
                    _userModel.Id = _userApp.Id.ToString();
                    _userModel.LockOutEnabled = _userApp.LockoutEnabled;
                }
                return _userModel;
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(userlogin);
                throw AddError(IdTransaction,Errores._10004_SROauth_Info_User, 10004, e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(userlogin);
                throw AddError(IdTransaction,Errores._10004_SROauth_Info_User, 10004, ex, MethodBase.GetCurrentMethod(), jsonModel);
            }


        }
        private IEnumerable<Claim> CrearClaisUsuario(UserModel usermodel)
        {
            try
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, usermodel.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                return claims;
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(usermodel);
                throw AddError(IdTransaction,Errores._10005_SROauth_Clais, 10005, e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(usermodel);
                throw AddError(IdTransaction,Errores._10005_SROauth_Clais, 10005, ex, MethodBase.GetCurrentMethod(), jsonModel);
            }


        }

        private TokenModel GenerateToken(IEnumerable<Claim> claims)
        {
            try
            {
                TokenModel token = new TokenModel();

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var jwt = new JwtSecurityToken(issuer: "Blinkingcaret",
                    audience: "Everyone",
                    claims: claims, //the user's claims, for example new Claim[] { new Claim(ClaimTypes.Name, "The username"), //... 
                    notBefore: DateTime.UtcNow,
                    expires: DateTime.UtcNow.AddMinutes(5),
                    signingCredentials: creds
                );
                return new TokenModel()
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwt),
                    ValidateToken = jwt.ValidFrom.ToString()
                };
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(claims);
                throw AddError(IdTransaction,Errores._10006_SROauth_GeneraToken, 10006, e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(claims);
                throw AddError(IdTransaction,Errores._10006_SROauth_GeneraToken, 10006, ex, MethodBase.GetCurrentMethod(), jsonModel);
            }


        }
        private string GenerateRefreshToken()
        {
            try
            {
                var randomNumber = new byte[32];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomNumber);
                    return Convert.ToBase64String(randomNumber);
                }
            }
            catch (CError e)
            {
                throw AddError(IdTransaction,Errores._10007_SROauth_GenerateRefreshToken, 10007, e, MethodBase.GetCurrentMethod(), "");
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10007_SROauth_GenerateRefreshToken, 10007, ex, MethodBase.GetCurrentMethod(), "");
            }

        }

        private async Task<UserToken> SaveTokenRefres(TokenModel token, string idUser)
        {
            try
            {
                //Buscamos existe un registro para ese usuario con ese token refres en la base de datos
                //si existe tendremos que actualizar ese registro si no existe lo creamos
                //.FindAllAsync(x => x.CdEmpleado == itemTienda.CD_EMPLEADO).Result.FirstOrDefault();
                var _userTokenEntity = _indentityOfWork.UserTokenRepository.FindAllAsync(x => x.UserId == idUser).Result.FirstOrDefault();
                UserToken _userToken = new UserToken();
                _userToken.Id = Guid.NewGuid();
                _userToken.UserId = idUser;
                _userToken.RefresToken = token.refresh_token;
                if (_userTokenEntity != null)
                    await _indentityOfWork.UserTokenRepository.DeleteAsync(_userTokenEntity.Id);

                await _indentityOfWork.UserTokenRepository.CreateAsync(_userToken);
                return _userToken;
            }
            catch (CError e)
            {
                throw AddError(IdTransaction,Errores._10008_SROauth_SaveToken, 10008, e, MethodBase.GetCurrentMethod(), "");
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10008_SROauth_SaveToken, 10008, ex, MethodBase.GetCurrentMethod(), "");
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            try
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
                {
                    throw AddError(IdTransaction,Errores._10011_SROauth_Token_Valido, 10011, MethodBase.GetCurrentMethod(), "");
                }
                return principal;
            }
            catch (CError ce)
            {

                throw AddError(IdTransaction,Errores._10012_SROauth_GetPrincipalFromExpiredToken, 10012, ce, MethodBase.GetCurrentMethod(), "");
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10012_SROauth_GetPrincipalFromExpiredToken, 10012, ex, MethodBase.GetCurrentMethod(), "");
            }
        }

        private async Task<bool> IsBloquedUser(string idUser)
        {
            try
            {
                ApplicationUser _appUser = await _userManager.FindByIdAsync(idUser);
                if (_appUser != null)
                    return _appUser.LockoutEnabled;
                else
                    return true;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction,Errores._10013_SROauth_IsBloquedUser, 10013, ce, MethodBase.GetCurrentMethod(), "");
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10013_SROauth_IsBloquedUser, 10013, ex, MethodBase.GetCurrentMethod(), "");
            }


        }
        private string GetRefreshToken(string idUser)
        {
            try
            {
                string _refresToken = "";
                var _userIdentity = _indentityOfWork.UserTokenRepository.FindAllAsync(x => x.UserId == idUser).Result.FirstOrDefault();
                if (_userIdentity != null)
                    _refresToken = _userIdentity.RefresToken;
                return _refresToken;
            }
            catch (CError ce)
            {
                throw AddError(IdTransaction,Errores._10014_SROauth_GetRefreshToken, 10014, ce, MethodBase.GetCurrentMethod(), "");
            }
            catch (System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10014_SROauth_GetRefreshToken, 10014, ex, MethodBase.GetCurrentMethod(), "");
            }

        }

        private async Task<TokenModel> ModifyAccessData(string userName)
        {
            try {
                TokenModel _tokenLogin = new TokenModel();
                var _userInfo = await GetInfoUserAsync(userName);
                if (_userInfo.LockOutEnabled)
                {
                    var _clains = CrearClaisUsuario(_userInfo);
                    _tokenLogin = GenerateToken(_clains);
                    var _RefresToken = GenerateRefreshToken();
                    _tokenLogin.refresh_token = _RefresToken;
                    UserToken _userToken = await SaveTokenRefres(_tokenLogin, _userInfo.Id);
                }
                else
                {
                    /// _tokenLogin.ValidationResults.Add(new ValidationResult("10002", new[] { Errores._10002_SROauth_Usuario_Bloqueado }));
                    _tokenLogin.ValidationResultsBase.Add(new ValidationResultBase(new ValidationResult("10002"), (int)HttpStatusCode.BadRequest, IdTransaction));
                    // throw _errorManager.AddError(Errores._10002_SROauth_Usuario_Bloqueado, "10002", MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(userName));
                }
                return _tokenLogin;
            }
            catch(CError ce)
            {
                throw AddError(IdTransaction,Errores._10016_SROauth_ModifyAccessData, 10016, ce, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(userName));
            }
            catch(System.Exception ex)
            {
                throw AddError(IdTransaction,Errores._10016_SROauth_ModifyAccessData, 10016, ex, MethodBase.GetCurrentMethod(), JsonConvert.SerializeObject(userName));
            }
        }
        #endregion




    }
}
