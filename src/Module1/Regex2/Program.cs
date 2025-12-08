using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex2
{
	class Program
	{
		static void Main(string[] args)
		{
			Match m = null;
			Regex rx = new Regex(@"^(\d{2})/(\d{2})/(\d{4})$");
			do
			{
				Console.Write("Enter date (dd/mm/yyyy): ");
				string text = Console.ReadLine();
				m = rx.Match(text);
				if (!m.Success) Console.WriteLine("Invalid date.");
			} while (!m.Success);
			Console.WriteLine(m.Value); /* dd/mm/yy */
			Console.WriteLine(m.Groups[0].Value);   /* dd/mm/yy */
			Console.WriteLine(m.Groups[1].Value);	// dd
			Console.WriteLine(m.Groups[2].Value);	// mm	
			Console.WriteLine(m.Groups[3].Value);	// yyyy
		}
	}
}
