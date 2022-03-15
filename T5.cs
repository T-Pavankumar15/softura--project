using System;
class Task5
{
public static void Main()
{
string[][]product=new string[3][];
product[0]=new string[]{"BISCUITS","BISCUITS","BISCUITS","BISCUITS"};
product[1]=new string[]{"CHOCOLATES","CHOCOLATES","CHOCOLATES","CHOCOLATES","CHOCOLATES"};
product[2]=new string[]{"DRINKS","DRINKS","DRINKS","DRINKS","DRINKS","DRINKS"};
 for(int i=0;i<product.Length;i++)
 {
  for(int j=0;j<product[i].Length;j++)
  Console.Write(product[i][j]+"\t");
  Console.WriteLine();
}
}
}