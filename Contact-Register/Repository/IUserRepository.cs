using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Models;

namespace Contact_Register.Repository
{
    public interface IUserRepository
    {
        List<UserModel> Get();
        UserModel? GetById(int id);
        void Insert(UserModel user);
        void Update(UserModel user);
        bool Remove(UserModel user);
    }
}