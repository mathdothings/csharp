using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Models;

namespace Contact_Register.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> Get();
        ContactModel? GetById(int id);
        ContactModel Insert(ContactModel contact);
        ContactModel Update(ContactModel contact);
    }
}