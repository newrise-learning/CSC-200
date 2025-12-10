using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1 {
	class Program {
		//static void Swap(ref int v1, ref int v2) {
		//	int vt = v1;
		//	v1 = v2;
		//	v2 = vt;
		//}
		//static void Swap(ref double v1, ref double v2) {
		//	double vt = v1;
		//	v1 = v2;
		//	v2 = vt;
		//}

		//static void Swap(ref object v1, ref object v2) {
		//	object vt = v1;
		//	v1 = v2;
		//	v2 = vt;
		//}

		static void Swap<T>(ref T v1, ref T v2) {
			T vt = v1;
			v1 = v2;
			v2 = vt;
		}

		static void Main(string[] args) {
			int n1 = 66;
			int n2 = 99;
			//	Swap<int>(ref n1, ref n2);
			Swap(ref n1, ref n2);
			Console.WriteLine("{0},{1}", n1, n2);

			double d1 = 1.99;
			double d2 = 99.1;
			//	Swap<double>(ref d1, ref d2);
			Swap(ref d1, ref d2);
			Console.WriteLine("{0},{1}", d1, d2);

			decimal m1 = 123.99m;
			decimal m2 = 321.99m;
		//	Swap<decimal>(ref m1, ref m2);
			Swap(ref m1, ref m2);
			Console.WriteLine("{0},{1}", m1, m2);

			string s1 = "Hello!";
			string s2 = "Goodbye!";
		//	Swap<string>(ref s1, ref s2);
			Swap(ref s1, ref s2);
			Console.WriteLine("{0},{1}", s1, s2);
			



		}
	}
}
