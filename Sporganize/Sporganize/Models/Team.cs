using Sporganize.Enumerations;

namespace Sporganize.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? LogoId { get; set; }
        public File? Logo { get; set; }
        public Branch Branch { get; set; }
        public int? CaptainId { get; set; }
        public User? Captain { get; set; }
        public int? StreetId { get; set; }
        public Street? Street { get; set; }
        public ICollection<Match> TeamsA { get; set; }
        public ICollection<Match> TeamsB { get; set; }
        public ICollection<TeamTournament> Tournaments { get; set; }
        public ICollection<UserTeams> Users { get; set; }

    }

}
