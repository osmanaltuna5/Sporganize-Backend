namespace Sporganize.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set;}
        public int? SportFacilityId { get; set; }
        public SportFacility? SportFacility { get; set; }
        public ICollection<Match> Matches { get; set; }
        public ICollection<TeamTournament> Teams { get; set; }

    }

}
