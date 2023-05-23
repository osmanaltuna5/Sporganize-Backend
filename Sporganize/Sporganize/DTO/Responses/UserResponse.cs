using Sporganize.Enumerations;
namespace Sporganize.DTO.Responses
{
    public class UserResponse
    {
        public int Id { get; set; }
        public FileResponse Profile { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }

    }

}
