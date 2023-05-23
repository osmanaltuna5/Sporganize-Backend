using Sporganize.Generics;
using Sporganize.Models;

namespace Sporganize.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public List<User> GetFriends(int userId);
        public List<UserTeams> GetTeams(int userId);

    }

}
