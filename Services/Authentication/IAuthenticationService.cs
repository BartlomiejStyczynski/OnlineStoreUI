using System.Threading.Tasks;

namespace OnlineStoreUI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(UserLoginDto request);
    }
}
