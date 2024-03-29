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
        try
        {
            if (ModelState.IsValid)
            {
                _contactRepository.Insert(contact);
                TempData["SuccessAlert"] = "Contact registered successfully!";
                return RedirectToAction("Index");
            }

            return View(contact);
        }
        catch (Exception error)
        {
            TempData["DangerAlert"] = $"Unable to register contact! Error:{error.Message}";
            return RedirectToAction("Index");
        }
    }

    [HttpPost]
    public IActionResult Update(ContactModel contact)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _contactRepository.Update(contact);
                TempData["SuccessAlert"] = "Contact edited successfully!";
                return RedirectToAction("Index");
            }

            return View(contact);
        }
        catch (Exception error)
        {
            TempData["DangerAlert"] = $"Unable to edit this contact! Error:{error.Message}";
            return RedirectToAction("Index");
        }
    }

    public IActionResult Remove(ContactModel contact)
    {
        try
        {
            if (_contactRepository.Remove(contact)) TempData["SuccessAlert"] = "Contact removed successfully!";
            return RedirectToAction("Index");
        }
        catch (Exception error)
        {
            TempData["SuccessAlert"] = $"Unable do remove this contact! {error.Message}";
            return RedirectToAction("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}