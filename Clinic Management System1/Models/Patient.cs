using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_System.Models
{
    public class Patient
    {
        [Required]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Please Enter the First Name")]
        
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter the Last Name")]
        
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Select the Gender")]
        
        public string Sex { get; set; }
       

        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter the Date_of_birth")]
        public DateTime Date_of_birth { get; set; }
    }
}
