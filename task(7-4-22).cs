using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;


namespace ConsoleApp1
{
    class task1
    {
       
        public static void Main()
        {
            IList<book> bookdata = new List<book>()
        {
                new book(){bookId=1,Title="whispers of time ",Author="krishna",price=350},
                new book(){bookId=2,Title="My Journey",Author="abdual kalam",price=200},
                new book(){bookId=3,Title="making of new india",Author="Bibek Debroy",price=320},
               new book(){bookId=4,Title="The Bench",Author="Meghan Markle",price=400},
               new book(){bookId=5,Title="Home in the World",Author="Amartya Sen",price=250},
        };
            var bqry = from b1 in bookdata
                       select b1;
            foreach (var q in bqry)
                Console.WriteLine(q.bookId + " "+q.Title+ " "+q.Author+" "+q.price);
            Console.WriteLine("-------------------------------");
            //ASCENDING ORDER
            var bqry1 = bookdata.OrderBy(s => s.Author);
            foreach (var s in bqry1)
                Console.WriteLine(s.Author +" "+ s.Title);
            Console.WriteLine("-------------------------------");
            var bqry2 = bookdata.OrderBy(s => s.price);
            foreach (var s in bqry2)
                Console.WriteLine(s.price +" "+s.Title);
            Console.WriteLine("-------------------------------");
           var bqry3 = from b2 in bookdata
                       where b2.Author.Contains("krishna")
                      select b2;
            foreach (var q in bqry3)
                Console.WriteLine(q.Title);
                




        }
        class book
        {
            public int bookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int price { get; set; }
        }
    }
}
