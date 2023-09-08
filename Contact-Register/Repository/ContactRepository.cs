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

        public List<ContactModel> Get()
        {
            return _databaseContext.Contacts.ToList();
        }

        public ContactModel? GetById(int id) {
            return _databaseContext.Contacts.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(ContactModel contact)
        {
            _databaseContext.Contacts.Add(contact);
            _databaseContext.SaveChanges();
        }

        public void Update(ContactModel contact)
        {
            _databaseContext.Contacts.Update(contact);
            _databaseContext.SaveChanges();
        }
    }
}