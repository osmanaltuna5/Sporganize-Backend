using Sporganize.Enumerations;
using Sporganize.Models;

namespace Sporganize.DTO.Responses
{
    public class AppointmentResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostTime { get; set; }
        public UserResponse User { get; set; }
        public Branch Branch { get; set; }
        public AppointmentReason AppointmentReason { get; set; }
        public LocationResponse Location { get; set; }

    }

}
