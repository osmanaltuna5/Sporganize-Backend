namespace Sporganize.DTO.Responses
{
    public class TeamStatusAtTournamentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int NumberOfLoss { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfDraws { get; set; }

    }

}
