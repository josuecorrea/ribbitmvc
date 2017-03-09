using System;

namespace RibbitMVC.Data
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IRibbitRepository Ribbits { get; }

        int SaveChanges();
    }
}
