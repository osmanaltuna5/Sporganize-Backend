using Microsoft.EntityFrameworkCore;
using Sporganize.Configurations;
using Sporganize.DTO.Responses;
using Sporganize.Generics;
using Sporganize.Models;

namespace Sporganize.Repositories
{
    public class TournamentRepository : GenericRepository<Tournament>, ITournamentRepository
    {
        private readonly DataContext _dataContext;
        public TournamentRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<TeamTournament> GetLeagueById(int id)
        {
            return _dataContext.teamTournaments.
                Where(tt => tt.TournamentId == id).
                Include(tt => tt.Tournament).
                Include(tt => tt.Team).
                ToList();
        }
    }
}
