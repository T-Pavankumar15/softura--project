using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Clinic_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Clinic_Management_System.Dal;


namespace Clinic_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           
                return View();
           
        }
        public IActionResult Validate(Logintable us)
        {


        if (ModelState.IsValid)
        {
            ClinicDal obj = new ClinicDal();
                int Result = obj.Verify(us);
                if (Result == 1)
                    return View("HomePage");
                else
                    return Content("wrong entery of UserName and Password");
            }
            return View("HomePage");

        }
        public IActionResult Success()
        {
            return View("Success");
        }
        public IActionResult HomePage()
        {
            return View();
        }
       
        public IActionResult Doctor()
        {
            

            return View();
        }

        public IActionResult addoc(Doctor A)
        {
            if (ModelState.IsValid)
            {
                ClinicDal obj = new ClinicDal();
                int Result = obj.addoc(A);
                if (Result == 1)
                    return RedirectToAction("HomePage");
                else
                    return View("Doctor");
            }
            return View("Doctor");
        }
        public IActionResult GetDoctor()
        {
            ClinicDal dal = new ClinicDal();
            List<Doctor> doc = new List<Doctor>();
            doc = dal.getdoc();
            return View(doc);

        }
        //public IActionResult GetDoctor()
        //{
        //    ClinicDal dal = new ClinicDal();
        //    List<Doctor> doc = new List<Doctor>();
        //    doc = dal.getdoc1();
        //    return View(doc);

        //}

        public IActionResult Patient()
        {

            return View();
        }

        public IActionResult adpat(Patient B)
        {
            if (ModelState.IsValid)
            {
                ClinicDal obj = new ClinicDal();
                int Result = obj.adpat(B);
                if (Result == 1)
                    return RedirectToAction("HomePage");
                else
                    return View("Patient");
            }
            return View("Patient");
        }
        public IActionResult GetPatient()
        {
            ClinicDal dal = new ClinicDal();
            List<Patient> pat = new List<Patient>();
            pat = dal.getpat();
            return View(pat);

        }
        public IActionResult ScheduleAppointment()
        {
            return View();
        }
        public IActionResult Schpro(ScheduleAppointment C)
        {
            ClinicDal obj = new ClinicDal();
            int Result = obj.schpro(C);
            if (Result == 1)
                return View("HomePage");
            else
                return View("ScheduleAppointment");

        }
        public IActionResult DelAppointment()
        {
            ClinicDal dal = new ClinicDal();
            List<ScheduleAppointment> appointments = new List<ScheduleAppointment>();
            appointments = dal.GetAppointments();
            return View(appointments);

        }
        public IActionResult Delapp(int id)
        {
            ClinicDal obj = new ClinicDal();
            int Result = obj.Delapp(id);
            if (Result == 1)
                return View("HomePage");
            else
            return View("DelAppointment");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
