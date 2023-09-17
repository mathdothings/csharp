using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_Register.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "You must enter a valid email!")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "Smartphone number is required!")]
        [Phone(ErrorMessage = "You must enter a valid smartphone number!")]
        public string? Smartphone { get; set; }
    }
}