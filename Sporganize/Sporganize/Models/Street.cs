namespace Sporganize.Models
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DistrictId { get; set; }
        public District? District { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<SportFacility> SportFacilities { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }

}
