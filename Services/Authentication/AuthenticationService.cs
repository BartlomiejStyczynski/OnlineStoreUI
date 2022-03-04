using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace OnlineStoreUI.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }
        public async Task<bool> AuthenticateAsync(UserLoginDto request)
        {
            var response = await _httpClient.LoginAsync(request);

            //Store Token
            await _localStorage.SetItemAsync("accessToken", response.Data);

            //Change auth state of app



            return true;
        }
    }
}
