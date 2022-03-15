using System;
class T4
{
public static void Main()
{
string Name;
int age;
Console.WriteLine("Enter the Name");
Name=Console.ReadLine();
Console.WriteLine("Enter the age");
age=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<=age;i++)
Console.WriteLine(Name);

}
}