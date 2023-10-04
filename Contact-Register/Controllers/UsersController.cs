using Microsoft.AspNetCore.Mvc;

namespace Contact_Register.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}