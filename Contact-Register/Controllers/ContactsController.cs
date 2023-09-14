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
        return View(_contactRepository.Get());
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Update(int id)
    {
        return View(_contactRepository.GetById(id));
    }

    public IActionResult Delete(int id)
    {
        return View(_contactRepository.GetById(id));
    }

    [HttpPost]
    public IActionResult Insert(ContactModel contact)
    {
        if (ModelState.IsValid)
        {
            _contactRepository.Insert(contact);
            return RedirectToAction("Index");
        }

        return View(contact); 
    }

    [HttpPost]
    public IActionResult Update(ContactModel contact)
    {
        _contactRepository.Update(contact);
        return RedirectToAction("Index");
    }

    public IActionResult Remove(ContactModel contact)
    {
        _contactRepository.Remove(contact);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}