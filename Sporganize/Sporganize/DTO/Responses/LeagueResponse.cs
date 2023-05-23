namespace Sporganize.DTO.Responses
{
    public class LeagueResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeamStatusAtTournamentResponse> TeamStatues { get; set; }

    }

}
