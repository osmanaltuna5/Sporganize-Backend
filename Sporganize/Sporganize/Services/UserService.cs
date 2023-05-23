using Sporganize.DTO;
using Sporganize.DTO.Responses;
using Sporganize.Models;
using Sporganize.Repositories;

namespace Sporganize.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserResponse> GetUsersWithoutDetails()
        {
            List<UserResponse> userResponses = new List<UserResponse>();
            foreach (var user in _userRepository.GetAll())
            {
                userResponses.Add(ConvertToDto.ToUserResponse(user));
            }

            return userResponses;
        }

        public UserResponse GetUserById(int id)
        {
            return ConvertToDto.ToUserResponse(_userRepository.GetById(id));
        }

        public List<UserResponse> GetFriendsOfUser(int id)
        {
            List<UserResponse> userResponses = new List<UserResponse>();
            foreach (var user in _userRepository.GetFriends(id))
            {
                userResponses.Add(ConvertToDto.ToUserResponse(user));
            }

            return userResponses;
        }

        public List<TeamResponse> GetTeamsOfUser(int id)
        {
            List<TeamResponse> teamResponses = new List<TeamResponse>();
            foreach (var ut in _userRepository.GetTeams(id))
            {
                teamResponses.Add(ConvertToDto.ToTeamResponse(ut.Team));
            }

            return teamResponses;
        }

    }
}
