using Sporganize.DTO.Responses;
using Sporganize.Models;

namespace Sporganize.Services
{
    public interface IUserService
    {
        public List<UserResponse> GetUsersWithoutDetails();
        public UserResponse GetUserById(int id);
        public List<UserResponse> GetFriendsOfUser(int id);
        public List<TeamResponse> GetTeamsOfUser(int id);

    }

}
