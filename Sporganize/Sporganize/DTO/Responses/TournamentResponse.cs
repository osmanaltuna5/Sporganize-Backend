using Sporganize.Models;

namespace Sporganize.DTO.Responses
{
    public class TournamentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

    }

}
