namespace Sporganize.Models
{
    public class UserTeams
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? TeamId { get; set; }
        public Team? Team { get; set; }

    }

}
