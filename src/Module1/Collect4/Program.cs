using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect4
{
	class Program
	{
		static void Main(string[] args)
		{
		//	Dictionary<string, string> t = new Dictionary<string, string>();
			var t = new Dictionary<string, string>();
			t.Add("John", "john_lee@axn.com");
			t.Add("Anne", "anne688@hotmail.com");
			t.Add("Mary", "mary22@yahoo.com");
			var s1 = t["John"];	// string
			var s2 = t["Anne"]; // string
			var s3 = t["Mary"]; // string
			Console.WriteLine(s1);
			Console.WriteLine(s2);
			Console.WriteLine(s3);
		}
	}
}
