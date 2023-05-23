using Sporganize.DTO;
using Sporganize.DTO.Responses;
using Sporganize.Models;
using Sporganize.Repositories;

namespace Sporganize.Services
{
    public class TournamentService : ITournamentService
    {
        private readonly ITournamentRepository _tournamentRepository;
        public TournamentService(ITournamentRepository tournamentRepository) { 
            _tournamentRepository = tournamentRepository;
        }

        public List<TournamentResponse> GetAllTournaments()
        {
            List<TournamentResponse> tournaments = new List<TournamentResponse>();
            foreach(var t in _tournamentRepository.GetAll())
            {
                tournaments.Add(ConvertToDto.ToTournamentResponse(t));
            }

            return tournaments;
        }
        public TournamentResponse GetTournamentById(int id)
        {
            return ConvertToDto.ToTournamentResponse(_tournamentRepository.GetById(id));
        }

        public LeagueResponse GetLeagueById(int id)
        {
            return ConvertToDto.ToLeagueResponse(_tournamentRepository.GetLeagueById(id));
        }
    }

}
