using Sporganize.DTO.Responses;
using Sporganize.Models;

namespace Sporganize.Services
{
    public interface ITournamentService
    {
        public List<TournamentResponse> GetAllTournaments();
        public TournamentResponse GetTournamentById(int id);
        public LeagueResponse GetLeagueById(int id);

    }
}
