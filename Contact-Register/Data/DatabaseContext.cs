using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact_Register.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<ContactModel> Contacts => Set<ContactModel>();
    }

}