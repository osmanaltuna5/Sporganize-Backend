using Sporganize.Enumerations;

namespace Sporganize.Models
{
    public class UserAppointment
    {
        public int Id { get; set; }
        public int? AcceptedUserId { get; set; }
        public User? AcceptedUser { get; set; }
        public int? AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
        public AppointmentStatus Status { get; set; }

    }

}
