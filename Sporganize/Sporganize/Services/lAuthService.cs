using Sporganize.DTO.Requests;
using Sporganize.DTO.Responses;

namespace Sporganize.Services
{
    public interface IAuthService
    {
        public LoginResponse Login(LoginRequest loginRequest);
        public UserResponse Register(RegisterRequest registerRequest);

    }

}
