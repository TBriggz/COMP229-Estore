using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class CustomerDetails
    {
        [Required(ErrorMessage ="Please a phone number")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter a Firstname")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a Lastname")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please Budget")]
        public int Amount { get; set; }

    }
}
