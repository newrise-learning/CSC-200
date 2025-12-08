using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex1
{
	class Program
	{
		static void Main(string[] args)
		{
			string zip = null;
			bool zipIsValid = false;
			Regex rx = new Regex(@"^\d{5}$");
			do
			{
				Console.Write("Enter zip code: ");
				zip = Console.ReadLine();
				zipIsValid = rx.IsMatch(zip);
				if (!zipIsValid) Console.WriteLine("Invalid zip code.");
			} while (!zipIsValid);
		}
	}
}
