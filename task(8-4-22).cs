using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class task
    {
		public static void Main()
		{
			int eyes = 52, Legs = 80;

			int count = 0;
			int count1 = 0;

			count = 2 * (eyes) - (Legs);
			count = count / 2;

			Console.WriteLine("No of Ducks:" + count);

			count1 = (eyes/2) - count;
			Console.WriteLine("No of Goats:" + count1);
		}
	}
}

