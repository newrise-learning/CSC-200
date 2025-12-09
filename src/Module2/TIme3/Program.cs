using MyLib1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIme3 {
	class Program {
		static void Main(string[] args) {
			string s1 = "Hello!";
			string s2 = "Goodbye!";

			Console.WriteLine(s1.ToString());
			Console.WriteLine(s2.ToString());
			Console.WriteLine(s1.GetHashCode());
			Console.WriteLine(s2.GetHashCode());

			int n1 = 100;
			int n2 = 200;
			Console.WriteLine(n1.ToString());
			Console.WriteLine(n2.ToString());

			object b1 = true;
			object b2 = 1234m;
			Console.WriteLine(b1.ToString());
			Console.WriteLine(b2.ToString());

			Time t1 = new Time(10, 20, 30);
			Time t2 = new Time(11, 22, 33);
			Console.WriteLine(t1.ToString());
			Console.WriteLine(t2.ToString());
			Console.WriteLine(t1.GetHashCode());
			Console.WriteLine(t2.GetHashCode());
			Time t3 = new Time(10, 20, 30);
			Console.WriteLine(t3.GetHashCode());
			Console.WriteLine(t1.Equals(t2));
			Console.WriteLine(t1.Equals(t3));

			var h = new Dictionary<Time, string>();
			h.Add(t1, "String 1");
			h.Add(t2, "String 2");

			Console.WriteLine(h.Keys.Contains(t3));

			Console.WriteLine(h[t1]);
			Console.WriteLine(h[t2]);
			Console.WriteLine(h[t3]);
		}
	}
}
