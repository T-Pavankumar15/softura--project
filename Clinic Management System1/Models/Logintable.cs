using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_System.Models
{
    public class Logintable
    {
        [Required (ErrorMessage = "Please Enter the Username")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public string Username { get; set; }
        [Required]
        public string firstname { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required(ErrorMessage = "Please Enter correct the Password")]
        public string Passwrd { get; set; }
    }
}
