using RibbitMVC.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RibbitMVC.Data
{
    public class RibbitRepository : EfRepository<Ribbit>, IRibbitRepository
    {

        public RibbitRepository(DbContext context, bool shareContext)
            :base(context, shareContext)
        {

        }

        public void AddFor(Ribbit ribbit, User user)
        {
            user.Ribbits.Add(ribbit);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }

        public Ribbit GetBy(int id)
        {
            return Find(r => r.Id == id);
        }

        public IEnumerable<Ribbit> GetFor(User user)
        {
            return user.Ribbits.OrderByDescending(r => r.DateCreated);
        }
    }
}