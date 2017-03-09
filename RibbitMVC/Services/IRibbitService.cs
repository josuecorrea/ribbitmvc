using RibbitMVC.Models;
using System;

namespace RibbitMVC.Services
{
    public interface IRibbitService
    {
        Ribbit GetBy(int id);
        Ribbit Create(User user, string status, DateTime? created = null);
    }
}
