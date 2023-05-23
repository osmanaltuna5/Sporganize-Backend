using Sporganize.Enumerations;
using Sporganize.Models;

namespace Sporganize.DTO.Responses
{
    public class TeamResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public FileResponse? Logo { get; set; }
        public Branch Branch { get; set; }
        public UserResponse? Captain { get; set; }
        public LocationResponse? Location { get; set; }
        public List<UserResponse>? Players { get; set; }

    }

}
