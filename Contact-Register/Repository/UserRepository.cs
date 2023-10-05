using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Data;
using Contact_Register.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact_Register.Repository
{
    public class UserRepository : IUserRepository
    {
        readonly DatabaseContext _databaseContext;
        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<UserModel> Get()
        {
            return _databaseContext.Users.ToList();
        }

        public UserModel? GetById(int id) {
            return _databaseContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(UserModel contact)
        {
            _databaseContext.Users.Add(contact);
            _databaseContext.SaveChanges();
        }

        public void Update(UserModel contact)
        {
            _databaseContext.Users.Update(contact);
            _databaseContext.SaveChanges();
        }

        public bool Remove(UserModel contact)
        {
            try
            {
                _databaseContext.Users.Remove(contact);
                _databaseContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
                throw new Exception();
            }
        }
    }
}