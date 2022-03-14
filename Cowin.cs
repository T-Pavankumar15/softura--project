using System;
class Covid
{
public static void Main()
{
string s,TH,T,c;
Console.WriteLine("Covid survey");
Console.WriteLine("Enter your name");
s=Console.ReadLine();
Console.WriteLine("Do You Have Travel History");
TH=Console.ReadLine();
if(TH=="yes")
{
Console.WriteLine("Do You Have Temperature?");
T=Console.ReadLine();
if(T=="yes")
{
Console.WriteLine("Do You Have Cough/Snee?");
c=Console.ReadLine();
if(c=="yes")
{
Console.WriteLine("Swab Test");
}
else
{
if(c=="no")
{
Console.WriteLine("Quarantine,Fever Medicine");
}
}
}
else
{
if(T=="no")
{
Console.WriteLine("Home Quarantine for 28 Days");
}
}
}
else
{
if(TH=="No")
{
Console.WriteLine("Safe not COVID-19");
} 
}
}
}
		