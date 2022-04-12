using System;
using System.Text;
using System.Data;

using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
       

         public static void Main(string[] args)
         {
            //SqlConnection con = new SqlConnection("data source = DESKTOP-PAVAN; database = softura;user id =sa; password=P@ssw0rd");
            //con.Open();
            // SqlCommand cmd = new SqlCommand("create table enrollment (sno int, name varchar(20),Gender char(1),Contactno varchar(10))", con);
            // cmd.ExecuteNonQuery();
            //Console.WriteLine("Completed");
            //con.Close();

            // SqlConnection con = new SqlConnection("data source = DESKTOP-PAVAN;database = softura;user id=sa;password=P@ssw0rd");
            //string sqlqry = "insert enrollment values(1,'pavankumar','m',9876543210)";
            //string sqlqry1 = "insert enrollment values(2,'Satya','m',9876556789)";
            //string sqlqry2 = "insert enrollment values(3,'pavankumar','m',9876123300)";
            //SqlCommand cmd = new SqlCommand(sqlqry, con);
            //SqlCommand cmd1 = new SqlCommand(sqlqry1, con);
            //SqlCommand cmd2 = new SqlCommand(sqlqry2, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //cmd1.ExecuteNonQuery();
            // cmd2.ExecuteNonQuery();
            // con.Close();
            // Console.WriteLine("Row Inserted");




            //SqlConnection con = new SqlConnection("Data source =DESKTOP-PAVAN; database =softura; user id = sa;password = P@ssw0rd");
            //string sqlqry = "Delete from enrollment where sno=2";
            //SqlCommand cmd = new SqlCommand(sqlqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //Console.WriteLine("Row deleted");

            SqlConnection con = new SqlConnection("Data source =DESKTOP-PAVAN; database =softura; user id = sa;password = P@ssw0rd");
             string sqlqry = "update enrollment set  name = 'ram' where sno=3 ";
            string sqlqry1 = "update enrollment set sno=2 where sno=3";
            SqlCommand cmd1 = new SqlCommand(sqlqry, con);
            SqlCommand cmd2 = new SqlCommand(sqlqry1, con);
            con.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row updated");

            
            


        }
    }
}
