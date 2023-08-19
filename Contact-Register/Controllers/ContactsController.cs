using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Contact_Register.Models;

namespace Contact_Register.Controllers;

public class ContactsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}