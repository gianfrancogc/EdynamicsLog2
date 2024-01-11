using EdynamicsLog.Application.DTOs.Account;
using EdynamicsLog.Application.Wrappers;
using System.Threading.Tasks;

namespace EdynamicsLog.Application.Interfaces
{
    public interface IAccountService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);
        Task<AuthenticationResponse> CheckAuthenticateAsync(string userId, string ipAddress);
        Task<UserSingleResponse> GetUserById(string userId);
    }
}
