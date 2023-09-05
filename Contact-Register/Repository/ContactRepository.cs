using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Data;
using Contact_Register.Models;

namespace Contact_Register.Repository
{
    public class ContactRepository : IContactRepository
    {
        readonly DatabaseContext _databaseContext;
        public ContactRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public ContactModel Insert(ContactModel contact)
        {
            _databaseContext.Contacts.Add(contact);
            _databaseContext.SaveChanges();
            
            return contact;
        }
    }
}