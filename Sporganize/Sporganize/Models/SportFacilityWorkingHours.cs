namespace Sporganize.Models
{
    public class SportFacilityWorkingHours
    {
        public int Id { get; set; }
        public int? SportFacilityId { get; set; }
        public SportFacility? SportFacility { get; set; }
        public string Day { get; set; }
        public string BetweenWorkingHours { get; set; }
        public int Price { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }

}
