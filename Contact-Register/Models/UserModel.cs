using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Contact_Register.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Register.Models
{
    public class UserModel
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "Name is required!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Login is required!")]
        [StringLength(25, ErrorMessage = "Login must have at least five digits!")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "You must enter a valid email!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Profile is required!")]
        public Profile Profile { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(25, ErrorMessage = "Password must have at least five digits!")]
        public string? Password { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}