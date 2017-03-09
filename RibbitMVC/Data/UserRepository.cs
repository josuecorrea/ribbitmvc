using RibbitMVC.Models;
using System.Data.Entity;

namespace RibbitMVC.Data
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context, bool sharedContext)
            : base(context, sharedContext)
        {

        }

        public User GetBy(string username)
        {
            return Find(u => u.Username == username);
        }

        public User GetBy(int id)
        {
            return Find(u => u.Id == id);
        }
    }
}