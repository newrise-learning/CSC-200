using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culture1
{
	class Program
	{
		static void Main(string[] args)
		{
			var d1 = DateTime.Now;
			CultureInfo c1 = CultureInfo.CreateSpecificCulture("fr");
			CultureInfo c2 = CultureInfo.CreateSpecificCulture("ms-MY");
			Console.WriteLine(string.Format(c1, "{0:ddd dd MMMM yyyy}", d1));
			Console.WriteLine(string.Format(c2, "{0:ddd dd MMMM yyyy}", d1));
			Console.WriteLine(c2.NumberFormat.CurrencySymbol);

			string s1 = "6 Oktober 1967";
			Console.WriteLine(DateTime.Parse(s1, c2));

		}
	}
}
