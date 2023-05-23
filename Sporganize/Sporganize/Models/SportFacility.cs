namespace Sporganize.Models
{
    public class SportFacility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OwnerId { get; set; }
        public User? Owner { get; set; }
        public string Phone { get; set; }
        public int? StreetId { get; set; }
        public Street? Street { get; set; }
        public ICollection<Tournament> Tournaments { get; set; }
        public ICollection<SportFacilityBranch> Branches { get; set; }
        public ICollection<SportFacilityWorkingHours> WorkingHours { get; set; }

    }

}
