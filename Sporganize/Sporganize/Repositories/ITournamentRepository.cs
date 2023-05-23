using Sporganize.DTO.Responses;
using Sporganize.Generics;
using Sporganize.Models;

namespace Sporganize.Repositories
{
    public interface ITournamentRepository : IGenericRepository<Tournament>
    {
        public List<TeamTournament> GetLeagueById(int id);

    }

}
