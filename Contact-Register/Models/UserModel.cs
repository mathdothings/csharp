using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Enums;

namespace Contact_Register.Models
{
    public class UserModel
    {
        public int Id {get; set;}
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public Profile Profile { get; set; }
        public string? Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}