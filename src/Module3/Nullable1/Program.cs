using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable1 {
	class Program {
		static void Show(string v = null) {
			if (v == null) v = "Hello!";
			Console.WriteLine(v);
		}

		static void Show2(int? v = null) {
			if (v == null) v = 123;
			Console.WriteLine(v);
		}

		static void Main(string[] args) {
			Show(); // Hello!
			Show("Goodbye!"); // Goodbye!
			Show2();		// 123
			Show2(456);		// 456

			Nullable<int> n1 = new Nullable<int>(10);
			Nullable<int> n2 = new Nullable<int>();
			Console.WriteLine(n1.HasValue); // true
			Console.WriteLine(n1.HasValue); // false
			if (n1.HasValue) Console.WriteLine(n1);
			if (n2.HasValue) Console.WriteLine(n2);

			int? n3 = 10;
			int? n4 = null;
			Console.WriteLine(n3 != null);
			Console.WriteLine(n4 != null);
			if (n3 != null) Console.WriteLine(n3);
			if (n4 != null) Console.WriteLine(n4);
			int n5 = n3 == null ? (int)n3 : 0;
			int n6 = n4 != null ? (int)n4 : 0;


		}
	}
}
