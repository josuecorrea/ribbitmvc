using RibbitMVC.Models;
using System.Collections.Generic;

namespace RibbitMVC.Data
{
    public interface IRibbitRepository : IRepository<Ribbit>
    {
        Ribbit GetBy(int id);
        IEnumerable<Ribbit> GetFor(User user);
        void AddFor(Ribbit ribbit, User user);
    }
}