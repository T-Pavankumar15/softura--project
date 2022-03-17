using System;
abstract class Calculator
{
public abstract void cal(int n1, int n2);

}
class t1:Calculator
{
public  override void cal(int n1, int n2)
{
Console.WriteLine("Add" +(n1+n2));
}
}
class t2:Calculator
{
public override void cal(int n1, int n2)
{
Console.WriteLine("sub" +(n1-n2));
}
}
class t3:Calculator
{
public override void cal(int n1, int n2)
{
Console.WriteLine("mul" +(n1*n2));
}
}
class t4:Calculator
{
public override void cal(int n1,int n2)
{
 double m= (double)n1/n2;
Console.WriteLine("div" +m);
}
}
class main
{
public static void Main()
{
t1 obj =new t1();
obj.cal(12,13);
t2 obj1 =new t2();
obj1.cal(12,20);
t3 obj2 =new t3();
obj2.cal(13,25);
t4 obj3 =new t4();
obj3.cal(12,544);
}
}

