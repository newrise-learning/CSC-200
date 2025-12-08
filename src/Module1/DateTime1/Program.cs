using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d1 = new DateTime();
			DateTime d2 = new DateTime(2002, 10, 16);
			DateTime d3 = new DateTime(2002, 10, 16, 18, 30, 25);
			DateTime d4 = DateTime.Now;
			DateTime d5 = DateTime.Today;
			DateTime d6 = DateTime.UtcNow;
			Console.WriteLine(d1);
			Console.WriteLine(d2);
			Console.WriteLine(d3);
			Console.WriteLine(d4);
			Console.WriteLine(d5);
			Console.WriteLine(d6);


			Console.WriteLine(d4.Day);
			Console.WriteLine(d4.Month);
			Console.WriteLine(d4.Year);
			Console.WriteLine(d4.DayOfWeek);
			Console.WriteLine((int)d4.DayOfWeek);
			Console.WriteLine(d4.DayOfYear);

			Console.WriteLine(d4.Hour);
			Console.WriteLine(d4.Minute);
			Console.WriteLine(d4.Second);
			Console.WriteLine(d4.Millisecond);

			Console.WriteLine(DateTime.DaysInMonth(d4.Year, d4.Month));
			Console.WriteLine(DateTime.IsLeapYear(d4.Year));

			Console.WriteLine(string.Format("{0:MMMM}", d4));
			Console.WriteLine(string.Format("{0:MMM}", d4));
		}
	}
}
