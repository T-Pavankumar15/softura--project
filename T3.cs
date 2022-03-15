using System;
class T3
{
public static void Main()
{
Console.WriteLine("enter the package");
string rate=Console.ReadLine();
switch(rate)
{
 case "A":Console.WriteLine("rate of the package is 250");
      break;
  case "B":Console.WriteLine("rate of the package is 450");
      break;
  case "C":Console.WriteLine("rate of the package is 450");
      break;
  default: Console.WriteLine("no package");
		break;
}
}
}
