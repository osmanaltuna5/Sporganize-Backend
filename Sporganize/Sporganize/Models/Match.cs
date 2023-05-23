namespace Sporganize.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int? TeamAId { get; set; }
        public Team? TeamA { get; set; } 
        public int? TeamBId { get; set; }
        public Team? TeamB { get; set; }
        public DateTime MatchTime { get; set; }
        public string Result { get; set; }
        public int? TournamentId { get; set; }
        public Tournament? Tournament { get; set; }

    }

}
