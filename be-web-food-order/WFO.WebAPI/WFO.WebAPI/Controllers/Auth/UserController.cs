using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WFO.Auth.ApplicationService.UserModule.Abstracts;
using WFO.Auth.Dtos.UserModule;

namespace WFO.WebAPI.Controllers.Auth
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Thêm user
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult CreateUser(CreateUserDto input)
        {
            _userService.CreateUser(input);
            return Ok("Thêm tài khoản thành công");
        }
    }
}
