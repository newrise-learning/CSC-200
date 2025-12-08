using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime3
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "Oct 6 1967";
			var d1 = DateTime.Parse(s1);
			Console.WriteLine(d1.ToShortDateString());
			Console.WriteLine(d1.ToShortTimeString());
			Console.WriteLine(d1.ToLongDateString());
			Console.WriteLine(d1.ToLongTimeString());
			Console.WriteLine("{0:ddd dd MMMM yyyy}", d1);
		}
	}
}
