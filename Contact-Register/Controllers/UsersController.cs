using Contact_Register.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Register.Controllers
{
    public class UsersController : Controller
    {
        readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View(_userRepository.Get());
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View(_userRepository.GetById(id));
        }

        public IActionResult Delete(int id)
        {
            return View(_userRepository.GetById(id));
        }
    }
}