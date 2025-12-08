using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime2
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d1 = DateTime.Now;	// GMT+8
			DateTime d2 = d1.ToUniversalTime();	//GMT+0
			DateTime d3 = d2.ToLocalTime();	//GMT+8

			Console.WriteLine(d1);
			Console.WriteLine(d2);
			Console.WriteLine(d3);

			Console.WriteLine(d1.AddDays(7));
			Console.WriteLine(d1.AddDays(-7));
			Console.WriteLine(d1.AddMonths(3));
			Console.WriteLine(d1.AddYears(2));
			Console.WriteLine(d1.AddHours(1));
			Console.WriteLine(d1.AddMinutes(10));
			Console.WriteLine(d1.AddSeconds(20));
			Console.WriteLine(d1.AddMilliseconds(50));

			DateTime d4 = new DateTime(1967, 10, 6, 6, 0, 0);
			TimeSpan t1 = new TimeSpan(1, 2, 3, 4);
			TimeSpan t2 = d1.Subtract(d4);

			Console.WriteLine(d1.Add(t1));
			Console.WriteLine(d1.Subtract(t1));

			Console.WriteLine(t2.Days);
			Console.WriteLine(t2.Hours);
			Console.WriteLine(t2.Minutes);
			Console.WriteLine(t2.Seconds);

			Console.WriteLine(t2.TotalDays);
			Console.WriteLine(t2.TotalHours);
			Console.WriteLine(t2.TotalMinutes);
			Console.WriteLine(t2.TotalSeconds);
		}
	}
}
