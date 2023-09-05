using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Models;

namespace Contact_Register.Repository
{
    public interface IContactRepository
    {
        ContactModel Insert(ContactModel contact);
    }
}