namespace Sporganize.Models
{
    public class UserFriends
    {
        public int Id { get; set; }
        public int? FirstFriendId { get; set; }
        public User? FirstFriend { get; set; }
        public int? SecondFriendId { get; set; }
        public User? SecondFriend { get; set; }

    }
}
