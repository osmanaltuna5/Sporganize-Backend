using Microsoft.EntityFrameworkCore;
using Sporganize.Models;

namespace Sporganize.Configurations
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Street> streets { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Match> matches { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Tournament> tournaments { get; set; }
        public DbSet<TeamTournament> teamTournaments { get; set; }
        public DbSet<UserTeams> userTeams { get; set; }
        public DbSet<UserFriends> userFriends { get; set; }
        public DbSet<UserAppointment> userAppointments { get; set; }
        public DbSet<SportFacility> sportFacilities { get; set; }
        public DbSet<SportFacilityBranch> sportFacilityBranches { get; set; }
        public DbSet<SportFacilityWorkingHours> sportFacilityWorkingHours { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Models.File> files { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Street>().
                HasOne(s => s.District).
                WithMany(d => d.Streets).
                HasForeignKey(s => s.DistrictId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<District>().
                HasOne(d => d.Province).
                WithMany(p => p.Districts).
                HasForeignKey(d => d.ProvinceId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().
                HasOne(u => u.Profile).
                WithOne(f => f.User).
                HasForeignKey<User>(u => u.ProfileId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>().
                HasOne(u => u.Street).
                WithMany(s => s.Users).
                HasForeignKey(u => u.StreetId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Match>().
                HasOne(m => m.TeamA).
                WithMany(t => t.TeamsA).
                HasForeignKey(m => m.TeamAId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>().
                HasOne(m => m.TeamB).
                WithMany(t => t.TeamsB).
                HasForeignKey(m => m.TeamBId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>().
                HasOne(m => m.Tournament).
                WithMany(t => t.Matches).
                HasForeignKey(m => m.TournamentId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Appointment>().
                HasOne(a => a.User).
                WithMany(u => u.Posts).
                HasForeignKey(a => a.UserId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>().
                HasOne(a => a.Street).
                WithMany(s => s.Appointments).
                HasForeignKey(a => a.StreetId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>().
                HasOne(t => t.Captain).
                WithMany(u => u.TeamsToBeCaptain).
                HasForeignKey(t => t.CaptainId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>().
                HasOne(t => t.Street).
                WithMany(s => s.Teams).
                HasForeignKey(t => t.StreetId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>().
                HasOne(t => t.Logo).
                WithOne(f => f.Team).
                HasForeignKey<Team>(t => t.LogoId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Tournament>().
                HasOne(t => t.SportFacility).
                WithMany(s => s.Tournaments).
                HasForeignKey(t => t.SportFacilityId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<TeamTournament>().
                HasOne(tt => tt.Team).
                WithMany(t => t.Tournaments).
                HasForeignKey(tt => tt.TeamId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<TeamTournament>().
                HasOne(tt => tt.Tournament).
                WithMany(t => t.Teams).
                HasForeignKey(tt => tt.TournamentId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserTeams>().
                HasOne(ut => ut.User).
                WithMany(u => u.Teams).
                HasForeignKey(ut => ut.UserId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserTeams>().
                HasOne(ut => ut.Team).
                WithMany(t => t.Users).
                HasForeignKey(ut => ut.TeamId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserFriends>().
                HasOne(uf => uf.FirstFriend).
                WithMany(u => u.FirstFriends).
                HasForeignKey(uf => uf.FirstFriendId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserFriends>().
                HasOne(uf => uf.SecondFriend).
                WithMany(u => u.SecondFriends).
                HasForeignKey(uf => uf.SecondFriendId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserAppointment>().
                HasOne(ua => ua.AcceptedUser).
                WithMany(u => u.Appointments).
                HasForeignKey(ua => ua.AcceptedUserId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserAppointment>().
                HasOne(ua => ua.Appointment).
                WithMany(a => a.Users).
                HasForeignKey(ua => ua.AppointmentId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SportFacility>().
                HasOne(sf => sf.Owner).
                WithMany(u => u.SportFacilities).
                HasForeignKey(sf => sf.OwnerId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SportFacility>().
                HasOne(sf => sf.Street).
                WithMany(s => s.SportFacilities).
                HasForeignKey(sf => sf.StreetId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SportFacilityBranch>().
                HasOne(sfb => sfb.SportFacility).
                WithMany(sf => sf.Branches).
                HasForeignKey(sfb => sfb.SportFacilityId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SportFacilityWorkingHours>().
                HasOne(sfw => sfw.SportFacility).
                WithMany(sf => sf.WorkingHours).
                HasForeignKey(sfw => sfw.SportFacilityId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>().
                HasOne(r => r.User).
                WithMany(u => u.Reservations).
                HasForeignKey(r => r.UserId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Reservation>().
                HasOne(r => r.SportFacilityWorkingHours).
                WithMany(sfw => sfw.Reservations).
                HasForeignKey(r => r.SportFacilityWorkingHoursId).
                OnDelete(DeleteBehavior.SetNull);

        }

    }

}
