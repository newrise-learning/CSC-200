using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect2
{
	class Program
	{
		static void Main(string[] args)
		{
			Hashtable t = new Hashtable();
			t.Add("John", "john_lee@axn.com");
			t.Add("Anne", "anne688@hotmail.com");
			t.Add("Mary", "mary22@yahoo.com");
			Console.WriteLine(t.Count); // 3
			Console.WriteLine(t["John"]);
			Console.WriteLine(t["Anne"]);
			Console.WriteLine(t["Mary"]);
			Console.WriteLine(t["Jack"]);   //  null

			foreach (string value in t.Values)
				Console.WriteLine(value);

			foreach (string key in t.Keys)
			{
				string value = (string)t[key];
				Console.WriteLine("{0} -> {1}", key, value);
			}

		}
	}
}
