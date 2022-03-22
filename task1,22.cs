using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp2
{

    class task2
    {
        public static void Main()
        {

            FileStream fs = new FileStream("F:\\softura\\Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Tea");
            str.Add("Coffee");
            str.Add("Dosa");
            str.Add("vada");
            str.Add("Lichi Mousse");
            foreach (string d in str)
            {
                bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("F:\\Softura\\Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
           
            DirectoryInfo di = new DirectoryInfo(@"F:\Softura\Dessert.txt");
            Console.WriteLine("Fullname:" + di.FullName);
            Console.WriteLine("Creation time" + di.CreationTime);
            Console.WriteLine("Last Acess" + di.LastAccessTime);
            
            Console.Read();
        }
    }

}

