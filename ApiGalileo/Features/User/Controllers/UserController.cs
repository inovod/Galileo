using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGalileo.Features.Base;
using ApiGalileo.Features.User.DTO;
using ApiGalileo.Features.User.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiGalileo.Features.User.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;
        public UserController(IUserServices userService)
        {
            _userService = userService;

        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody]UserAddRequest request)
        {
            try
            {
                ResponseBase _response = await _userService.AddUser(request);
                if (_response.bOK)
                {
                    return Ok(new ApiOkResponse(_response));
                }
                else
                {
                    string error = (string)_response.Response;
                    return NotFound(new ApiResponseNoOk(error));
                }
            }
            catch (System.Exception)
            {
                return NotFound(new ApiResponseNoOk("No se ha podido realizar la operación."));
            }
        }

        [HttpPut]
        public async Task<IActionResult> SetUser(UserSetRequest request)
        {
            ResponseBase _response = await _userService.SetUser(request);
            if (_response.bOK)
                return Ok(new ApiOkResponse(_response));
            else
                return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid UserId)
        {
            ResponseBase _response = await _userService.DeleteUser(UserId);
            if (_response.bOK)
                return Ok(new ApiOkResponse(_response));
            else
                return NotFound(new ApiResponse(404, $"No se ha podido realizar la operacion"));

        }

        [HttpGet("GetAllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            var _response = await _userService.GetAllUser();
            return Ok(new ApiOkResponse(_response));
        }

        [HttpGet("GetUserFilter")]
        public async Task<IActionResult> GetUserFilter(UserFilterRequest request)
        {
            var _response = await _userService.GetUserByFilter(request);
            return Ok(new ApiOkResponse(_response));

        }

        [HttpGet("GetUserById")]
        public async Task<ActionResult<ApiResponse>> GetUserById(Guid id)
        {
            var _response = await _userService.GetUserById(id);
            return Ok(new ApiOkResponse(_response));
        }
    }
}