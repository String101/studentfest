using studentfest.Data;
using studentfest.Interface;
using studentfest.Models;

namespace studentfest.Repositories
{
    public class UserRepo : Repository<User>, IUser
    {
        public UserRepo(SqlContext context) : base(context)
        {
        }
    }
}
