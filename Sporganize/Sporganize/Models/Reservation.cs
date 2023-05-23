using Sporganize.Enumerations;

namespace Sporganize.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? SportFacilityWorkingHoursId { get; set; }
        public SportFacilityWorkingHours? SportFacilityWorkingHours { get; set; }
        public DateTime ReservationTime { get; set; }
        public bool ReservationStatus { get; set; }

    }

}
