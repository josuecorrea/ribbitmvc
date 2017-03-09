using RibbitMVC.Data;
using RibbitMVC.Models;
using RibbitMVC.Services;
using System.Web.Mvc;

namespace RibbitMVC.Controllers
{
    public class RibbitControllerBase : Controller
    {
        public User CurrentUser { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }

        public RibbitControllerBase()
        {
            Users = new UserService(new Context());
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
        }
    }
}