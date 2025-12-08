using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex3
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex rx = new Regex(@"\d+");
			string text = "1,99,123,77,2182,22,5";
			MatchCollection mc = rx.Matches(text);
			if (mc.Count == 0)
			{
				Console.WriteLine("No matches found.");
				return;
			}

			foreach (Match m in mc)
				Console.WriteLine(m.Value);

			Console.WriteLine(rx.Replace(text, "0"));

			string[] values = new Regex(@",").Split(text);
			foreach (string value in values)
				Console.WriteLine(value);
		}
	}
}
