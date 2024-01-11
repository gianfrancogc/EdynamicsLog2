using EdynamicsLog.Application.DTOs.Account;
using EdynamicsLog.Application.Interfaces;
using EdynamicsLog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EdynamicsLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IAuthenticatedUserService _authenticatedUser;

        public AccountController(IAccountService accountService, IAuthenticatedUserService authenticatedUser)
        {
            _accountService = accountService;
            _authenticatedUser = authenticatedUser;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            var result = await _accountService.AuthenticateAsync(request, GenerateIPAddress());

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            var origin = Request.Headers["origin"];
            return Ok(await _accountService.RegisterAsync(request, origin));
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            var origin = Request.Headers["origin"];
            return Ok(await _accountService.ConfirmEmailAsync(userId, code));
        }

        [Authorize]
        [HttpGet("auth/check-status")]
        public async Task<IActionResult> CheckAuth()
        {
            var userid = _authenticatedUser.UserId;
            return Ok(await _accountService.CheckAuthenticateAsync(userid, GenerateIPAddress()));
        }


        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest model)
        {
            return Ok(await _accountService.ResetPassword(model));
        }

        [Authorize]
        [HttpGet("identity/get-user")]
        public async Task<IActionResult> GetUser()
        {
            var userid = _authenticatedUser.UserId;
            return Ok(await _accountService.GetUserById(userid));
        }

        private string GenerateIPAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }


    }
}