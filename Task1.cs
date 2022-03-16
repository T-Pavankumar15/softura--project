using System;
class T1
{

public  void Add( int n1,int n2)
{
int res;
res=n1+n2;
Console.WriteLine("Sum "+res);
}
public  void sub(int n1,int n2)
{
int res;
res=n1-n2;
Console.WriteLine("Sub "+res);
}
}
class T2:T1
{
public  void mul( int n1,int n2)
{
int res;
res=n1*n2;
Console.WriteLine("Multiple "+res);
}
public  void div(int n1,int n2)
{
int res;
res=n1/n2;
Console.WriteLine("Divide "+res);
}
}
class Arithmetic
{
public static void Main()
{
 T2 obj=new T2();
 obj.Add(23,24);
 obj.sub(23,25);
 obj.mul(24,25);
 obj.div(52,20);
}
}
