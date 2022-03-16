using System;
class Vat{
public virtual void Price(int amount)
{
 float vat;
 vat=(float)(amount*(1+.02));
 Console.WriteLine("VAT: "+vat);
}
}
class Gst:Vat
{
 public override void Price(int amount)
{
   float gst;
   gst=(float)(amount*12)/100;
   Console.WriteLine("GST: "+gst);
}
}
class tax
{
public static void Main()
{
  Gst obj= new Gst();
  
  obj.Price(200);
Vat obj1=new Vat();
 obj1.Price(2000);
  
}
}