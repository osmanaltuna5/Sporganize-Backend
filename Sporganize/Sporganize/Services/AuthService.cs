using Sporganize.DTO;
using Sporganize.DTO.Requests;
using Sporganize.DTO.Responses;
using Sporganize.Models;
using Sporganize.Repositories;

namespace Sporganize.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public LoginResponse Login(LoginRequest loginRequest)
        {
            foreach (var user in _userRepository.GetAll())
            {
                if (user.Username.Equals(loginRequest.UserName) && user.Password.Equals(loginRequest.Password))
                {
                    return new LoginResponse(user.Id);
                }
            }

            return new LoginResponse(0);
        }

        public UserResponse Register(RegisterRequest registerRequest)
        {
            User newUser = new User()
            {
                Username = registerRequest.Username,
                Password = registerRequest.Password,
                Role = Enumerations.Role.USER,
                FirstName = registerRequest.FirstName,
                MiddleName = registerRequest.MiddleName,
                LastName = registerRequest.LastName
            };

            return ConvertToDto.ToUserResponse(_userRepository.Add(newUser));
        }

    }

}
