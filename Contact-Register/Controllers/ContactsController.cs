using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Contact_Register.Models;
using Contact_Register.Repository;

namespace Contact_Register.Controllers;

public class ContactsController : Controller
{
    readonly IContactRepository _contactRepository;
    public ContactsController(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(ContactModel contact) {
        _contactRepository.Insert(contact);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}