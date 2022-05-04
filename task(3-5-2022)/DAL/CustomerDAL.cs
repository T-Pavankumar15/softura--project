using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using WebApplication6.Models;
using System.Data;

namespace WebApplication6.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";


        public CustomerDAL()
        {
            var builder = new  ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;
                    }

                }
            }
            return listCustomer;
        }

        public int InCustomer(Customer cust)
        {
            
            SqlConnection con = new SqlConnection(cnn);

            SqlCommand cmd = new SqlCommand("InCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", cust.CustomerID);
            cmd.Parameters.AddWithValue("@Cname", cust.CustomerName);
            cmd.Parameters.AddWithValue("@Email", cust.EmailID);
            cmd.Parameters.AddWithValue("@num", cust.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();

            con.Close();
            return result;
        }





    }
}
