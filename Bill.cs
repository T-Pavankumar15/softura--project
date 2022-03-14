using System;
class Bill
{
public static void Main()
{
int N,rate,unit;
Console.WriteLine("Enter the units consumed:");
unit=Convert.ToInt32(Console.ReadLine());
if(unit<=200)
{
rate=unit*2;
}
else if(unit>200 && unit<=350)
{
N=unit-200;
rate=400+(N*3);
}
else if(unit>350 && unit<=500)
{
N=unit-350;
rate=850+(N*5);
}
else 
{
N=unit-500;
rate=1600+(N*7);
}
Console.WriteLine("Bill to pay "+rate); 
}
}

 