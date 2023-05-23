
using Sporganize.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace Sporganize.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int? ProfileId { get; set; }
        public File? Profile { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
        public int? StreetId { get; set; }
        public Street? Street { get; set; }
        public ICollection<UserFriends> FirstFriends { get; set; }
        public ICollection<UserFriends> SecondFriends { get; set; }
        public ICollection<UserTeams> Teams { get; set; }
        public ICollection<Team> TeamsToBeCaptain { get; set; }
        public ICollection<Appointment> Posts { get; set; }
        public ICollection<UserAppointment> Appointments { get; set; }
        public ICollection<SportFacility> SportFacilities { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }

}
