using RibbitMVC.Models;

namespace RibbitMVC.Data
{
    public interface IUserRepository : IRepository<User>
    {
        User GetBy(int id);
        User GetBy(string username);
    }
}
