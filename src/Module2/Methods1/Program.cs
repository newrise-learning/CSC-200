using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1 {
	class Program {
		// input parameter
		static void Proc1(int value) {
			Console.WriteLine("Proc1({0})", value);
			value = 99;
		}
		static void Proc2(out int value) {
			Console.WriteLine("Proc2()");
			value = 99;
		}
		static void Proc3(ref int value) {
			Console.WriteLine("Proc3({0})", value);
			value = 98;
		}
		static int Proc4() {
			Console.WriteLine("Proc4()");
			return 97;
		}

		static void Main(string[] args) {
			int n = 100;
			Proc1(n);	// input parameter
			Console.WriteLine(n);	// 100
			Proc2(out n);	// output parameter
			Console.WriteLine(n);   // 99
			Proc3(ref n);	// input output parameter
			Console.WriteLine(n);   // 98
			n = Proc4();	// return value
			Console.WriteLine(n);   // 97
			Console.WriteLine(Proc4());	// 97
		}
	}
}
