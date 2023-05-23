using Sporganize.Enumerations;

namespace Sporganize.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostTime { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public Branch Branch { get; set; }
        public int? StreetId { get; set; }
        public Street? Street { get; set; }
        public AppointmentReason AppointmentReason { get; set; }
        public ICollection<UserAppointment> Users { get; set; }

    }

}
