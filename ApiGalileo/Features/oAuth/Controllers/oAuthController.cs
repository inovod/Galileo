using System.Threading.Tasks;
using ApiGalileo.Exception;
using ApiGalileo.Features.oAuth.DTO;
using ApiGalileo.Features.oAuth.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiGalileo.Features.Base;
using Business.Interfaces;
using Business.Model.OAuth;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Business.Model.common;
using Business.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiGalileo.Features.oAuth.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/oAuth")]
    [ApiController]
   
    public class oAuthController : Controller
    {
        private IOauth _srvOAuth;
        private ILogTransaction _srvLogTransaction;
        
        /// <summary>
        /// s
        /// </summary>
        /// <param name="srvOAuth"></param>
        /// <param name="srvLogTransaction"></param>
        public oAuthController(IOauth srvOAuth,
            ILogTransaction srvLogTransaction)
        {
            _srvOAuth = srvOAuth;
            _srvLogTransaction = srvLogTransaction;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost("SignIn")]
        [SwaggerOperation(Summary = "Login", Description = "Login", OperationId = "Login")]
        public async Task<IActionResult> Login([FromBody]UserLogin_Dto userInfo)
        {

            try {
                var _response = await _srvOAuth.LoginAsync(new LoginRequest() { 
                    Login = userInfo.Login ,
                    Password = userInfo.Password ,
                    RequestHttp = (string)HttpContext.Items["Request"]
                });
                
                if (_response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(_response);
                    return new BadRequestObjectResult(_response);
                }
                return new OkObjectResult(_response);
            }
            catch(Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Refresh")]
        [SwaggerOperation(Summary = "Refresh", Description = "Refresh", OperationId = "Refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshToken_Dto request)
        {
            try {
                var response = await _srvOAuth.RefresAsync(new RefresTokenModel() { 
                    Token = request.Token,
                    TokenRefres = request.TokenRefres,
                    RequestHttp = (string)HttpContext.Items["Request"]
                });
                if (response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(response);
                    return new BadRequestObjectResult(response);
                }
                return new OkObjectResult(response);
            }
            catch(Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("ResetPassword")]
        [SwaggerOperation(Summary = "ResetPassword", Description = "ResetPassword", OperationId = "ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetLogin request)
        {
            try
            {
                var response = await _srvOAuth.ResetPassword(new ResetLoginModel() {UserName = request.UserName , RequestHttp = (string)HttpContext.Items["Request"] });

                if (response.HasValidationErrors())
                {
                    await _srvLogTransaction.AddLogTransaction(response);
                    return new BadRequestObjectResult(response);
                }
                return new OkObjectResult(response);
            }
            catch (Business.Logs.CError ce)
            {
                await _srvLogTransaction.AddLogTransaction(ce);
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}