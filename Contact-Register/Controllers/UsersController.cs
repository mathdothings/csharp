using System.Diagnostics;
using Contact_Register.Models;
using Contact_Register.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Register.Controllers;

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

    [HttpPost]
    public IActionResult Insert(UserModel user)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _userRepository.Insert(user);
                TempData["SuccessAlert"] = "User registered successfully!";
                return RedirectToAction("Index");
            }

            return View(user);
        }
        catch (Exception error)
        {
            TempData["DangerAlert"] = $"Unable to register user! Error:{error.Message}";
            return RedirectToAction("Index");
        }
    }

    [HttpPost]
    public IActionResult Update(UserModel user)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _userRepository.Update(user);
                TempData["SuccessAlert"] = "User edited successfully!";
                return RedirectToAction("Index");
            }

            return View(user);
        }
        catch (Exception error)
        {
            TempData["DangerAlert"] = $"Unable to edit this user! {error.Message}";
            return RedirectToAction("Index");
        }
    }

    public IActionResult Remove(UserModel user)
    {
        try
        {
            if (_userRepository.Remove(user)) TempData["SuccessAlert"] = "User removed successfully!";
            return RedirectToAction("Index");
        }
        catch (Exception error)
        {
            TempData["SuccessAlert"] = $"Unable do remove this user! {error.Message}";
            return RedirectToAction("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
