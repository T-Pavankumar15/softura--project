using System;
class T2
{
public static void Main()
{
int N;
Console.WriteLine("Give the Number :");
N =Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=20;i++)
{
int A;
A= N * i;
Console.WriteLine("{0} * {1} = {2}",N,i,A);
}
}
}