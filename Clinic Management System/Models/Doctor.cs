using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Clinic_Management_System.Models
{
    public class Doctor
    {
        [Required]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Please Enter the First Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter the Last Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "special characters not allowed")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Please Select the Gender")]
        public String Sex { get; set; }
        [Required(ErrorMessage = "Please Enter the Specialization")]
        public String Specialization { get; set; }
        [Required (ErrorMessage = "Please Enter the Visiting Hour")]
        public String Visiting_Hours { get; set; }
    }
}
