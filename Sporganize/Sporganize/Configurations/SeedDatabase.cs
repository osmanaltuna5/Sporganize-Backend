using Microsoft.EntityFrameworkCore;
using Sporganize.Enumerations;
using Sporganize.Models;

namespace Sporganize.Configurations
{
    public class SeedDatabase
    {

        public static void Seed(DataContext dataContext)
        {
            if (dataContext.Database.GetPendingMigrations().Count() == 0)
            {
                if (dataContext.users.Count() == 0)
                {
                    dataContext.provinces.AddRange(provinces);
                    dataContext.districts.AddRange(districts);
                    dataContext.streets.AddRange(streets);
                    dataContext.users.AddRange(users);
                    dataContext.sportFacilities.AddRange(sportFacilities);
                    dataContext.sportFacilityBranches.AddRange(sportFacilityBranches);
                    dataContext.sportFacilityWorkingHours.AddRange(sportFacilityWorkingHours);
                    dataContext.tournaments.AddRange(tournaments);
                    dataContext.teams.AddRange(teams);
                    dataContext.userTeams.AddRange(userTeams);
                    dataContext.userFriends.AddRange(userFriends);
                    dataContext.matches.AddRange(matches);
                    dataContext.teamTournaments.AddRange(teamTournaments);
                    dataContext.appointments.AddRange(appointments);
                    dataContext.userAppointments.AddRange(userAppointments);
                    dataContext.reservations.AddRange(reservations);
                }

                dataContext.SaveChanges();
            }
        }

        private static Province[] provinces =
        {
            new Province()
            {
                Name = "Istanbul",
            }
        };

        private static District[] districts =
        {
            new District()
            {
                Name = "Kadikoy",
                Province = provinces[0]
            },
            new District()
            {
                Name = "Esenler",
                Province = provinces[0]
            }
        };

        private static Street[] streets =
        {
            new Street()
            {
                Name = "Acibadem",
                District = districts[0]
            },
            new Street()
            {
                Name = "Bostanci",
                District = districts[0]
            },
            new Street()
            {
                Name = "Fatih",
                District = districts[1]
            },
            new Street()
            {
                Name = "Davutpasa",
                District = districts[1]
            }
        };

        private static User[] users =
        {
            new User()
            {
                Username = "emreyelboga",
                Password = "emre123",
                FirstName = "Emre",
                LastName = "YELBOGA",
                Email = "emreyelboga@gmail.com",
                Phone = "+90-545-361-57-50",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.ADMIN
            },
            new User()
            {
                Username = "fatihyelboga",
                Password = "fatih123",
                FirstName = "Fatih",
                LastName = "YELBOGA",
                Email = "fatihyelboga@gmail.com",
                Phone = "+90-541-361-57-50",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.OWNER
            },
            new User()
            {
                Username = "enesdemirel",
                Password = "enes123",
                FirstName = "Enes",
                LastName = "DEMIREL",
                Email = "enesdemirel@gmail.com",
                Phone = "+90-545-840-50-08",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.USER
            },
            new User()
            {  
                Username = "osmanaltunay",
                Password = "osman123",
                FirstName = "Osman",
                LastName = "ALTUNAY",
                Email = "osmanaltunay@gmail.com",
                Phone = "+90-542-970-50-40",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.USER
            },
            new User()
            {
                Username = "mervenurozan",
                Password = "merve123",
                FirstName = "Merve",
                MiddleName = "Nur",
                LastName = "OZAN",
                Email = "mervenurozan@gmail.com",
                Phone = "+90-535-742-08-32",
                Gender = Gender.FEMALE,
                Street = streets[0],
                Role = Role.USER
            },
            new User()
            {
                Username = "zaferakman",
                Password = "zafer123",
                FirstName = "Zafer",
                LastName = "AKMAN",
                Email = "zaferakman@gmail.com",
                Phone = "+90-536-080-42-07",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.USER
            },
            new User()
            {
                Username = "celalbiyikli",
                Password = "celal123",
                FirstName = "Celal",
                LastName = "BIYIKLI",
                Email = "celalbiyikli@gmail.com",
                Phone = "+90-536-850-08-44",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.USER
            },
            new User()
            {
                Username = "berkay",
                Password = "berkay123",
                FirstName = "Berkay",
                LastName = "BAYRAK",
                Email = "beyrakbayrak@gmail.com",
                Phone = "+90-535-840-42-42",
                Gender = Gender.MALE,
                Street = streets[0],
                Role = Role.USER
            }
        };

        private static SportFacility[] sportFacilities =
        {
            new SportFacility() 
            {
                Name = "YELBOGA HALI SAHA",
                Owner = users[0],
                Street= streets[0],
                Phone = "242-865-08-42"
            }
        };

        private static SportFacilityBranch[] sportFacilityBranches = 
        {
            new SportFacilityBranch()
            {
                SportFacility = sportFacilities[0],
                Branch = Branch.FOOTBALL
            },
            new SportFacilityBranch()
            {
                SportFacility = sportFacilities[0],
                Branch = Branch.BASKETBALL
            }
        };

        private static SportFacilityWorkingHours[] sportFacilityWorkingHours =
        {
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Pazartesi",
                BetweenWorkingHours = "12-24",
                Price = 200
            },
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Sali",
                BetweenWorkingHours = "12-24",
                Price = 200
            },
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Carsamba",
                BetweenWorkingHours = "12-24",
                Price = 200
            },
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Persembe",
                BetweenWorkingHours = "12-24",
                Price = 200
            },
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Cuma",
                BetweenWorkingHours = "12-24",
                Price = 200
            },
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Cumartesi",
                BetweenWorkingHours = "16-24",
                Price = 200
            },
            new SportFacilityWorkingHours()
            {
                SportFacility= sportFacilities[0],
                Day = "Pazar",
                BetweenWorkingHours = "16-24",
                Price = 200
            },
        };

        private static Tournament[] tournaments =
        {
            new Tournament()
            {
                Name = "KARTAL TURNUVASI",
                Title = "2022 - 2023 KARTAL TURNUVASI KURALLARI",
                Description =
                "1-) Takimlar 5 as ve 2 yedek oyuncu olmak üzere 7 kişiden oluşmaktadır.\n" +
                "2-) Turnuva lig formatinda oynanacaktir.\n" +
                "3-) Katilim için 5000 TL ücret ödenmesi gerekmektedir.",
                StartingDate = new DateTime(2022, 01, 01),
                EndingDate = new DateTime(2022, 06, 01),
                SportFacility = sportFacilities[0],
            }
        };

        private static Team[] teams =
        {
            new Team() 
            {
                Name = "YENILMEZLER",
                Branch = Branch.FOOTBALL,
                Captain = users[1],
                Street = streets[0]
            },
            new Team()
            {
                Name = "KORKUSUZLAR",
                Branch = Branch.FOOTBALL,
                Captain = users[4],
                Street = streets[0]
            }
        };

        private static UserTeams[] userTeams =
        {
            new UserTeams()
            {
                User = users[1],
                Team = teams[0]
            },
            new UserTeams()
            {
                User = users[2],
                Team = teams[0]
            },
            new UserTeams()
            {
                User = users[3],
                Team = teams[0]
            },
            new UserTeams()
            {
                User = users[4],
                Team = teams[1]
            },
            new UserTeams()
            {
                User = users[5],
                Team = teams[1]
            },
            new UserTeams()
            {
                User = users[6],
                Team = teams[1]
            }
        };

        private static UserFriends[] userFriends = 
        {
            new UserFriends()
            {
                FirstFriend = users[1],
                SecondFriend = users[2]
            },
            new UserFriends()
            {
                FirstFriend = users[2],
                SecondFriend = users[3]
            }
        };

        private static Match[] matches =
        {
            new Match()
            {
                TeamA = teams[0],
                TeamB = teams[1],
                MatchTime = new DateTime(2022, 01, 10),
                Result = "4-2",
                Tournament = tournaments[0]
            }
        };

        private static TeamTournament[] teamTournaments =
        {
            new TeamTournament()
            {
                Team = teams[0],
                Tournament = tournaments[0],
                Points = 3,
                NumberOfWins = 1,
                NumberOfLoss = 0,
                NumberOfDraws = 0
            },
            new TeamTournament()
            {
                Team = teams[1],
                Tournament = tournaments[0],
                Points = 0,
                NumberOfWins = 0,
                NumberOfLoss = 1,
                NumberOfDraws = 0
            }
        };

        private static Appointment[] appointments =
        {
            new Appointment()
            {
                Title = "21.00'de tenis",
                Description = "21.00'de tenis oynamak isteyenler bana ulasabilir.",
                User = users[0],
                PostTime = DateTime.Now,
                Branch = Branch.TENNIS,
                AppointmentReason = AppointmentReason.PLAYING,
                Street = streets[0]
            }
        };

        private static UserAppointment[] userAppointments =
        {
            new UserAppointment()
            {
                AcceptedUser = users[1],
                Appointment = appointments[0],
                Status = AppointmentStatus.WAITING
            },
            new UserAppointment()
            {
                AcceptedUser = users[2],
                Appointment = appointments[0],
                Status = AppointmentStatus.WAITING
            }
        };

        private static Reservation[] reservations =
        {
            new Reservation()
            {
                User = users[0],
                SportFacilityWorkingHours = sportFacilityWorkingHours[0],
                ReservationTime = new DateTime(2022, 01, 10),
                ReservationStatus = true
            }
        };

    }
}
