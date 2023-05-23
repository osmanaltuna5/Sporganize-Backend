using Sporganize.DTO.Responses;
using Sporganize.Models;

namespace Sporganize.DTO
{
    public static class ConvertToDto
    {
        public static UserResponse ToUserResponse(User user)
        {
            if(user != null)
            {
                FileResponse profile = null;
                if (user.Profile != null)
                {
                    profile = new FileResponse()
                    {
                        Id = user.Profile.Id,
                        Name = user.Profile.Name,
                        Extension = user.Profile.Extension,
                        Type = user.Profile.Type,
                        Content = user.Profile.Content,
                    };
                }

                return new UserResponse()
                {
                    Id = user.Id,
                    Profile = profile,
                    Username = user.Username,
                    Role = user.Role,
                    Email = user.Email,
                    Phone = user.Phone,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    Gender = user.Gender
                };
            }

            return null;
        }

        public static LocationResponse ToLocationResponse(Street street)
        {
            return new LocationResponse()
            {
                Id = street.Id,
                Street = street.Name,
                District = street.District.Name,
                Province = street.District.Province.Name
            };
        }

        public static TeamResponse ToTeamResponse(Team team)
        {
            FileResponse logo = null;
            if(team.Logo != null)
            {
                logo = new FileResponse()
                {
                    Id = team.Logo.Id,
                    Name = team.Logo.Name,
                    Extension = team.Logo.Extension,
                    Type = team.Logo.Type,
                    Content = team.Logo.Content,
                };
            }

            List<UserResponse> players = new List<UserResponse>();
            foreach (var user in team.Users)
            {
                players.Add(ToUserResponse(user.User));
            }

            return new TeamResponse()
            {
                Id = team.Id,
                Name = team.Name,
                Logo = logo,
                Branch = team.Branch,
                Captain = ToUserResponse(team.Captain),
                Location = ToLocationResponse(team.Street),
                Players = players
            };
        }

        public static TournamentResponse ToTournamentResponse(Tournament tournament)
        {
            return new TournamentResponse()
            {
                Id = tournament.Id,
                Title= tournament.Title,
                Description = tournament.Description,
                StartingDate = tournament.StartingDate,
                EndingDate = tournament.EndingDate
            };

        }

        public static LeagueResponse ToLeagueResponse(List<TeamTournament> teamTournament)
        {
            LeagueResponse leagueResponse = new LeagueResponse();
            List<TeamStatusAtTournamentResponse> teamStatues = new List<TeamStatusAtTournamentResponse>();

            bool done = true;
            foreach (var tt in teamTournament)
            {
                if (done)
                {
                    leagueResponse.Id = tt.Id;
                    leagueResponse.Name = tt.Tournament.Name;
                    done = false;
                }

                teamStatues.Add(new TeamStatusAtTournamentResponse()
                {
                    Id = tt.Team.Id,
                    Name = tt.Team.Name,
                    Points = tt.Points,
                    NumberOfWins = tt.NumberOfWins,
                    NumberOfLoss = tt.NumberOfLoss,
                    NumberOfDraws = tt.NumberOfDraws
                });
            }

            leagueResponse.TeamStatues = teamStatues;

            return leagueResponse;
        }

        public static AppointmentResponse ToAppointmentResponse(Appointment appointment)
        {
            return new AppointmentResponse()
            {
                Id = appointment.Id,
                Title = appointment.Title,
                Description = appointment.Description,
                PostTime = appointment.PostTime,
                User = ToUserResponse(appointment.User),
                Branch = appointment.Branch,
                AppointmentReason = appointment.AppointmentReason,
                Location = ToLocationResponse(appointment.Street)
            };
        }
    }
}
