using Microsoft.AspNetCore.Mvc;
using Sporganize.DTO;
using Sporganize.DTO.Responses;
using Sporganize.Repositories;
using Sporganize.Services;

namespace Sporganize.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/users-without-details")]
        public List<UserResponse> GetUsersWithoutDetails()
        {
            return _userService.GetUsersWithoutDetails();
        }

        [HttpGet("/users/{id}")]
        public UserResponse GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpGet("/users/friends/{id}")]
        public List<UserResponse> GetFriendsOfUser(int id)
        {
            return _userService.GetFriendsOfUser(id);
        }

        [HttpGet("/users/{id}/teams")]
        public List<TeamResponse> GetTeamsOfUser(int id)
        {
            return _userService.GetTeamsOfUser(id);
        }

    }

}
