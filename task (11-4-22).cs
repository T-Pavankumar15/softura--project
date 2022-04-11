using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
namespace linq
{
    class task_26
    {
        public static void Main()
        {
            IList<Doctor> DoctorData = new List<Doctor>()
            {
                new Doctor(){DoctorID=1,Doctorname="Usha",DoctorAge=35,SpecialistID=1},
                new Doctor(){DoctorID=2,Doctorname="Rama krishna",DoctorAge=40,SpecialistID=1},
                new Doctor(){DoctorID=3,Doctorname="Muralikrishna",DoctorAge=42,SpecialistID=3},
                new Doctor(){DoctorID=4,Doctorname="Ramamurthy",DoctorAge=38,SpecialistID=2},
                new Doctor(){DoctorID=5,Doctorname="Satya",DoctorAge=35,SpecialistID=1},
                new Doctor(){DoctorID=5,Doctorname="Akhil",DoctorAge=55,SpecialistID=3},
                new Doctor(){DoctorID=5,Doctorname="Das Varma",DoctorAge=45,SpecialistID=2},
                new Doctor(){DoctorID=5,Doctorname="krishna das ",DoctorAge=65,SpecialistID=2}
            };
            IList<Specialization> SpecData = new List<Specialization>
            {
                new Specialization(){SpecialistID=1,Specialist=" Surgeon"},
                new Specialization(){SpecialistID=2,Specialist="Ophthalmologist"},
                new Specialization(){SpecialistID=3,Specialist="Psychiatrist"},

            };
        
        var JoinDoctordata = from spec in SpecData
                          join doc in DoctorData
                          on spec.SpecialistID equals doc.SpecialistID
                          into DocGroup
                          select new
                          {
                              Doctors = DocGroup,
                              SpecialzationName = spec.Specialist
                          };
            foreach (var item in JoinDoctordata)
            {
                Console.WriteLine("\n"+item.SpecialzationName);
                foreach (var doct in item.Doctors)
                    Console.WriteLine("Doctor Name:Dr."+doct.Doctorname);
            }
            Console.WriteLine("***************************");
            var JoinData = DoctorData.Join(
           SpecData,
              doc => doc.SpecialistID,
              spec => spec.SpecialistID,
              (doc, spec) => new
              {
                  DoctorName = doc.Doctorname,
                  SpecailistName = spec.Specialist
              }
              );

            foreach (var v in JoinData)
            {
                Console.WriteLine("Dr." + v.DoctorName + " Specialist in " + v.SpecailistName);
            }


        }
    }
    class Doctor
    {
        public int DoctorID { get; set; }
        public string Doctorname { get; set; }
        public int DoctorAge { get; set; }

        public int SpecialistID { get; set; }
    }
    class Specialization
    {
        public int SpecialistID { get; set; }
        public string Specialist { get; set; }
    }
}
