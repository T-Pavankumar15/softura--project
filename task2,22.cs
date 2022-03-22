using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace ConsoleApp2
{
    [Serializable]
    public class Employee
    {
        public int ID =123;
        public string Name="Pavankumar";
        public string Gender="M";
        public int Age=22;
    }
    class task1
    {
        public void Ser()
        {
            Employee emplo = new Employee();
            FileStream fs = new FileStream("Employee", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter Sf1 = new SoapFormatter();
            Sf1.Serialize(fs, emplo);
            fs.Close();
        }
        public void DeSer2Data()
        {
            Employee emplo = new Employee();
            FileStream fs = new FileStream("Employee", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            Employee emp = (Employee)sf.Deserialize(fs);
            Console.WriteLine(emp.ID);
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Gender);
            Console.WriteLine(emp.Age);

        }
        public static void Main()
        {
            task1 sobj = new task1();
            sobj.Ser();
            sobj.DeSer2Data();
            Console.Read();
        }
    }
}
