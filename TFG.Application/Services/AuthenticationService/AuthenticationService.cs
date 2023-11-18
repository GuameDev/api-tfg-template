using TFG.Application.Services.AuthenticationService.UserLoginService;

namespace TFG.Application.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserLogin _userLogin;

        public AuthenticationService(IUserLogin userLogin)
        {
            _userLogin = userLogin;
        }


    }
}
