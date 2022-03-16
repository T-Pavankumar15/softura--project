using System;
class login
{
public void ad(string n1,string n2)
{ 
  Console.WriteLine("Email ID");
  Console.WriteLine("Password");
}
public void ad(string n3,int n4)
{
  Console.WriteLine("Membership ID:");
  Console.WriteLine("Pin");
}
public void ad(long n5,int n6)
{
  Console.WriteLine("Mobile number");
  Console.WriteLine("Pin");
}
class main
{
public static void Main()
{
 login obj=new login();
 obj.ad(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
 obj.ad(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
 obj.ad(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
}
}
}