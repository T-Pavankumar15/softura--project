using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_System.Models
{
    public class ScheduleAppointment
    {
        [Required(ErrorMessage = "Please Enter the PatientId")]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Please Select the Specialization")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please Enter the Doctor")]
        public string Doctor { get; set; }
        [Required(ErrorMessage = "Please Enter the Visiting")]
        public string VisitDate { get; set; }
        [Required(ErrorMessage = "Please select the AppointmentTime ")]
        public string AppointmentTime { get; set; }
    }
}
