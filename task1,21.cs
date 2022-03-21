using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Cfile3
    {
        public static void Main()
        {
            FileStream fs = new FileStream("F:\\softura\\day11\\employ.txt",
            FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("Empolyee Details\n");
            bw.Write("Empoy id:1234\n");
            bw.Write("Name:pavankumar\n");
            bw.Write("Gender:male\n");
            bw.Write("Age:22\n");
            bw.Flush();
            fs.Close();
            FileStream fs1 = new FileStream("F:\\softura\\day11\\employ.txt",
          FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            string str = br.ReadString();
            Console.WriteLine(str);
           string str1 = br.ReadString();
            Console.WriteLine(str1);
            string str4 = br.ReadString();
            Console.WriteLine(str4);
            string str2 = br.ReadString();
            Console.WriteLine(str2);
            string str3 = br.ReadString();
            Console.WriteLine(str3);
            fs1.Close();
            Console.Read();

        }
    }
}
