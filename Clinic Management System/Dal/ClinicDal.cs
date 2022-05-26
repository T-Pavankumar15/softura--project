using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clinic_Management_System.Models;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Clinic_Management_System.Dal
{
    public class ClinicDal
    {
        public string cnn = "";


        public ClinicDal()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }
        public int Verify(Logintable ch)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Inlog", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User", ch.Username);
            cmd.Parameters.AddWithValue("@Pass", ch.Passwrd);
            con.Open();
            IDataReader reader = cmd.ExecuteReader();
           if(reader.Read())
            {
                return (1);
            }
           
            con.Close();
            return (0);
        }
        public int addoc(Doctor A)
        {
            int result;
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("addoc", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@n", A.FirstName);
            cmd.Parameters.AddWithValue("@n1", A.LastName);
            cmd.Parameters.AddWithValue("@s", A.Sex);
            cmd.Parameters.AddWithValue("@spe", A.Specialization);
            cmd.Parameters.AddWithValue("@vi", A.Visiting_Hours);
            conn.Open();
            result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public int adpat(Patient B)
        {
            int result1;
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("adpat", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", B.FirstName);
            cmd.Parameters.AddWithValue("@name", B.LastName);
            cmd.Parameters.AddWithValue("@sex", B.Sex);
            cmd.Parameters.AddWithValue("@age", B.Age);
            cmd.Parameters.AddWithValue("@date", B.Date_of_birth);
            conn.Open();
            result1 = cmd.ExecuteNonQuery();
            conn.Close();
            return result1;
        }

        public int schpro(ScheduleAppointment C)
        {
            int result1;
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Schpro", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sp", C.Specialization);
            cmd.Parameters.AddWithValue("@name", C.Doctor);
            cmd.Parameters.AddWithValue("@date", C.VisitDate);
            cmd.Parameters.AddWithValue("@t", C.AppointmentTime);
          
            conn.Open();
            result1 = cmd.ExecuteNonQuery();
            conn.Close();
            return result1;
        }
        public List<ScheduleAppointment> GetAppointments()
        {
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("GetApp", conn);
            conn.Open();
            IDataReader read = cmd.ExecuteReader();
            List<ScheduleAppointment> appointments = new List<ScheduleAppointment>();
            while(read.Read())
            {
                appointments.Add(new ScheduleAppointment()
                {
                  PatientId=int.Parse(read["PatientId"].ToString()),
                  Doctor=read["Doctor"].ToString(),
                  Specialization=read["Specialization"].ToString(),
                  VisitDate=read["VisitDate"].ToString(),
                  AppointmentTime=read["AppointmentTime"].ToString(),

                });
            }
            return appointments;

        }
        public List<Doctor> getdoc()
        {
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("getdoc", conn);
            conn.Open();
            IDataReader read = cmd.ExecuteReader();
            List<Doctor> doc = new List<Doctor>();
            while(read.Read())
            {
                doc.Add(new Doctor()
                {
                    DoctorId= int.Parse(read["DoctorId"].ToString()),
                    FirstName=read["FirstName"].ToString(),
                    LastName=read["LastName"].ToString(),
                    Sex=read["Sex"].ToString(),
                    Specialization=read["Specialization"].ToString(),
                    Visiting_Hours=read["Visiting_Hours"].ToString(),
                });
            }
            return doc;

        }

        public int Delapp(int id)
        {
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Delapp", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;

        }
    }
}
