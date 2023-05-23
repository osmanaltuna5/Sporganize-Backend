using Microsoft.EntityFrameworkCore;
using Sporganize.Configurations;
using Sporganize.Generics;
using Sporganize.Models;

namespace Sporganize.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<User> GetFriends(int userId)
        {
            User? user = _dataContext.users.
                         Where(u => u.Id == userId).
                         Include(u => u.FirstFriends).
                            ThenInclude(uf => uf.SecondFriend).
                         Include(u => u.SecondFriends).
                            ThenInclude(uf => uf.FirstFriend).
                         FirstOrDefault();

            List<User> friendsOfUser = new List<User>();
            if(user != null)
            {
                foreach (var u in user.FirstFriends)
                {
                    friendsOfUser.Add(u.SecondFriend);
                }
                foreach (var u in user.SecondFriends)
                {
                    friendsOfUser.Add(u.FirstFriend);
                }
            }

            return friendsOfUser;
        }

        public List<UserTeams> GetTeams(int userId)
        {
            return _dataContext.userTeams.
                Where(u => u.UserId == userId).
                Include(ut => ut.Team).
                    ThenInclude(t => t.Logo).
                Include(ut => ut.Team).
                    ThenInclude(t => t.Street).
                    ThenInclude(s => s.District).
                    ThenInclude(d => d.Province).
                Include(ut => ut.Team).
                    ThenInclude(t => t.Captain).
                Include(ut => ut.Team).
                    ThenInclude(t => t.Users)
                    .ThenInclude(ut => ut.User).
                ToList();
        }

    }
}
