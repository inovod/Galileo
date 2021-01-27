using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.User.DTO;
using Domain.Identity;
using Domain.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Repository.Identity.interfaces;

namespace ApiGalileo.Features.User.Services
{
    public class UserServices : IUserServices
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IIdentityUnitOfWork _identityUnitOfWork;
        private readonly ILog _log;
        public UserServices(UserManager<ApplicationUser> userManager,
            IIdentityUnitOfWork identityUnitOfWork ,
            ILog log)
        {
            _userManager = userManager;
            _identityUnitOfWork = identityUnitOfWork;
            _log = log;
        }
        /// <summary>
        /// Añadir usuario a las tablas de indentity y las propieas de la base de datos 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResponseBase> AddUser(UserAddRequest request)
        {
            ResponseBase _response;
            try
            {
                ApplicationUser appUser = new ApplicationUser()
                {
                    UserName = request.UserName,
                    Email = request.Email
                };
                var existeUser = await ExisteUsuario(request.UserName, request.Email);

                if (existeUser)
                    _response = new ResponseBase() { Response = "Usuario existente.", bOK = false };
                else
                {
                    //Creamos el usuario
                    _response = await CrearUserApp(request);
                    //Creamos el rool
                    if (_response.bOK)
                        _response = await AssignUserRole(_response);
                    //Creamos el usuario Informacion
                    if (_response.bOK)
                        _response = await CreateUserInfo(request, _response);

                    if (_response.bOK)
                    {
                        _response = new ResponseBase() { Response = _response.Response, bOK = true };
                        _log.Information("Creacion Usuario UserName = " + request.UserName + " Email = " + request.Email);
                    }
                    else
                    {
                        await DeleteUser(request.UserName);
                        //_response = new ResponseBase() { Response = "No se podido realizar la operacion.", bOK = false };
                    }
                }
            }
            catch (System.Exception)
            {
                await DeleteUser(request.UserName);
                _response = new ResponseBase() { Response = "No se podido realizar la operacion.", bOK = false };
            }
            return _response;
        }

        public async Task<ResponseBase> DeleteUser(Guid request)
        {
            ResponseBase _response;
            UserInfo _userInfo = await _identityUnitOfWork.UserInfoRepository.GetAsync(request);
            if (_userInfo != null)
            {
                ApplicationUser _appUser = await _userManager.FindByIdAsync(_userInfo.UserId.ToString());
                if (_appUser != null)
                    await DeleteUser(_appUser.UserName);
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            }
            else
                _response = new ResponseBase() { Response = "Se ha realizado correctamente la operacion", bOK = true };
            return _response;
        }

        public async Task<List<UserRespose>> GetAllUser()
        {
            MapperAppUser _mapper = new MapperAppUser();
            var _resultado = _identityUnitOfWork.UserInfoRepository.GetAllAsync().Result.ToList();
            var _contenido = _resultado.Select(x => _mapper.Parse(x)).ToAsyncEnumerable();
            return await _contenido.ToList();
        }

        public async Task<List<AppUser>> GetUserByFilter(UserFilterRequest request)
        {
            MapperAppUser _mapper = new MapperAppUser();
            if (string.IsNullOrWhiteSpace(request.Email) && string.IsNullOrWhiteSpace(request.UserName))
            {
                return new List<AppUser>();
            }
            else
            {
                var _resulFilter = _userManager.Users.ToAsyncEnumerable();
                if (!string.IsNullOrWhiteSpace(request.Email))
                    _resulFilter = _resulFilter.Where(x => x.Email.ToUpper().Contains(request.Email.ToUpper()));
                if (!string.IsNullOrWhiteSpace(request.UserName))
                    _resulFilter = _resulFilter.Where(x => x.UserName.ToUpper().Contains(request.UserName.ToUpper()));
                var _response = _resulFilter.Select(x => _mapper.Parse(x)).ToList();
                return await _response;
            }
        }

        public async Task<UserRespose> GetUserById(Guid iduser)
        {
            MapperAppUser _mapper = new MapperAppUser();
            UserInfo _userInfo = await _identityUnitOfWork.UserInfoRepository.GetAsync(iduser);
            if (_userInfo != null)
            {
                var _response = _mapper.Parse(_userInfo);
                return _response;
            }
            else
            {
                return new UserRespose();
            }
        }
        /// <summary>
        /// Modificacion de un usuario.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResponseBase> SetUser(UserSetRequest request)
        {
            bool bOk = false;
            ResponseBase _response;
            UserInfo _userInfo = await _identityUnitOfWork.UserInfoRepository.GetAsync(request.Id);
            if (_userInfo != null)
            {
                //Buscamos el usuario de la aplicacion
                ApplicationUser _appUserSet = await _userManager.FindByIdAsync(_userInfo.UserId);
                if (_appUserSet != null)
                {
                    _appUserSet.Email = string.IsNullOrEmpty(request.Email) ? _appUserSet.UserName : request.Email;
                    _appUserSet.LockoutEnabled = !request.Bloqueado;
                    _appUserSet.UserName = string.IsNullOrEmpty(request.UserLogin) ? _appUserSet.UserName : request.UserLogin;
                    var _result = await _userManager.UpdateAsync(_appUserSet);
                    if (_result.Succeeded)
                    {
                        _userInfo.Nombre = string.IsNullOrEmpty(request.Nombre) ? _userInfo.Nombre : request.Nombre;
                        _userInfo.Apellidos = string.IsNullOrEmpty(request.Apellidos) ? _userInfo.Apellidos : request.Apellidos;
                        _userInfo.Bloqueado = request.Bloqueado;
                        _userInfo.Email = string.IsNullOrEmpty(request.Email) ? _userInfo.Email : request.Email;
                        _userInfo.DateUpdate = DateTime.Now;
                        await _identityUnitOfWork.UserInfoRepository.UpdateAsync(_userInfo);
                        bOk = true;
                    }
                }
            }

            if (bOk)
                return _response = new ResponseBase() { Response = _userInfo, bOK = true };
            else
                return _response = new ResponseBase() { Response = "No se podido realizar la operacion.", bOK = false };
        }

        public async Task<ResponseBase> ChangePasswordUser(string userEmail)
        {
            ApplicationUser _appUser = await _userManager.FindByEmailAsync(userEmail);
            await _userManager.RemovePasswordAsync(_appUser);
            await _userManager.AddPasswordAsync(_appUser, "temporal123@");
            return null;
        }

        #region function private 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        private async Task<Boolean> ExisteUsuario(string username, string email)
        {
            try
            {
                var _userLogin = await _userManager.FindByNameAsync(username);
                var _userEmail = await _userManager.FindByEmailAsync(email);

                if (_userLogin == null && _userEmail == null)
                    return false;
                else
                    return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private async Task<ResponseBase> CrearUserApp(UserAddRequest dto)
        {
            ResponseBase _responseBase = new ResponseBase();
            ApplicationUser appUser = new ApplicationUser()
            {
                UserName = dto.UserName,
                Email = dto.Email
            };
            var _result = await _userManager.CreateAsync(appUser, dto.Password);
            _responseBase.bOK = _result.Succeeded;
            if (_result.Succeeded)
            {
                _responseBase.Response = appUser;
            }
            else
            {
                foreach (var error in _result.Errors)
                {
                    if (error.Code == "PasswordRequiresNonAlphanumeric")
                        _responseBase.Response = "Las contraseñas deben tener al menos un carácter no alfanumérico.";
                    if (error.Code == "PasswordTooShort")
                        _responseBase.Response = "Las contraseñas deben tener al menos 6 caracteres.";
                    if (error.Code == "PasswordRequiresDigit")
                        _responseBase.Response = "Las contraseñas deben tener al menos un dígito ('0' - '9')";
                }
            }
            return _responseBase;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private async Task<ResponseBase> AssignUserRole(ResponseBase response)
        {
            ResponseBase _responseBase = new ResponseBase();
            if (response.bOK)
            {
                ApplicationUser AppUser = (ApplicationUser)response.Response;
                var _result = await _userManager.AddToRoleAsync(AppUser, "Oficina");
                _responseBase.bOK = _result.Succeeded;
                _responseBase.Response = response.Response;
            }
            return _responseBase;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        private async Task<ResponseBase> CreateUserInfo(UserAddRequest dto, ResponseBase response)
        {
            ResponseBase responseBase = new ResponseBase();
            MapperAppUser _mapper = new MapperAppUser();
            try
            {
                if (response.bOK)
                {
                    ApplicationUser appUser = (ApplicationUser)response.Response;
                    UserInfo _userInfo =
                        _mapper.NewUserInfo(dto.Nombre, dto.Apellidos, appUser.Id, appUser.Email, appUser.LockoutEnabled);
                    await _identityUnitOfWork.UserInfoRepository.CreateAsync(_userInfo);
                    UserRespose userDto = _mapper.Parse(_userInfo);
                    responseBase.bOK = true;
                    responseBase.Response = userDto;
                }
            }
            catch (System.Exception)
            {
                responseBase.bOK = false;
                responseBase.Response = "No se ha podido relizar la operacion";
            }

            return responseBase;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private async Task<string> DeleteUser(string username)
        {
            ApplicationUser _appUser = await _userManager.FindByNameAsync(username);
            if (_appUser != null)
            {
                _log.Information("Elimina usuario " + username);
                //Buscamos el usuario dentro de la tabla UserInfo
                UserInfo _UserInf = await _identityUnitOfWork.UserInfoRepository.FindAsync(x => x.UserId == _appUser.Id);
                if (_UserInf != null)
                    await _identityUnitOfWork.UserInfoRepository.DeleteAsync(_UserInf.Id);
                //Elminamos los registros UserToke
                UserToken _UserToke = await _identityUnitOfWork.UserTokenRepository.FindAsync(x => x.UserId == _appUser.Id);
                if (_UserToke != null)
                    await _identityUnitOfWork.UserTokenRepository.DeleteAsync(_UserToke.Id);
                //Eliminamos los registros de AspNetUsers
                try { await _userManager.DeleteAsync(_appUser); }
                catch (System.Exception ex)
                {
                    var contenido = ex.Message;
                }

            }
            return "";
        }
        #endregion
    }
    public class MapperAppUser
    {
        public AppUser Parse(ApplicationUser entity)
        {
            AppUser _dto = new AppUser()
            {
                UserName = entity.UserName,
                bloqueado = entity.LockoutEnabled,
                Email = entity.Email
            };
            return _dto;
        }

        public UserRespose Parse(UserInfo entity)
        {
            UserRespose _dto = new UserRespose()
            {
                Id = entity.Id,
                AppUserId = entity.UserId,
                email = entity.Email,
                Nombre = entity.Nombre,
                Apellidos = entity.Apellidos,
                bloqueado = entity.Bloqueado
            };
            return _dto;
        }



        public UserInfo NewUserInfo(string nombre, string apellidos, string userId, string email, bool bloqueado)
        {
            UserInfo dto = new UserInfo()
            {
                Id = Guid.NewGuid(),
                Nombre = nombre,
                Apellidos = apellidos,
                UserId = userId,
                Email = email,
                Bloqueado = !bloqueado,
                DateInsert = DateTime.Now,
                DateUpdate = DateTime.Now
            };
            return dto;

        }
    }
}
