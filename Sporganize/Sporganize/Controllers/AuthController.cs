using Microsoft.AspNetCore.Mvc;
using Sporganize.DTO.Requests;
using Sporganize.DTO.Responses;
using Sporganize.Services;

namespace Sporganize.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("/login")]
        public LoginResponse Login(LoginRequest loginRequest)
        {
            return _authService.Login(loginRequest);
        }

        [HttpPost("/register")]
        public UserResponse Regist(RegisterRequest registerRequest)
        {
            return _authService.Register(registerRequest);
        }

    }

}
