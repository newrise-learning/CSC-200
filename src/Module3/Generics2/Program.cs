using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2 {

	class Program {
		static void Proc1<A, B>(A v1, B v2) {
			Console.WriteLine("A={0},B={1}",
				v1.GetType().FullName,
				v2.GetType().FullName);
		}

		static void Proc2<T>(T v1) where T : struct {
			Console.WriteLine("{0} is a value!", v1);
		}

		static void Proc3<T>(T v1) where T : class {
			Console.WriteLine("{0} is an object!", v1);
		}

		static int Proc4<T>(T v1, T v2) where T : IComparable {
			return v1.CompareTo(v2);
		}

		static int Proc5<T>(T v1, T v2) where T : IComparable<T> {
			return v1.CompareTo(v2);
		}

		static T Proc6<T>(T v1) where T :ICloneable, IDisposable {
			T copy = (T)v1.Clone();
			v1.Dispose(); return copy;
		}

		static T Proc7<T>() where T : new() { return new T(); }

		static void Proc8<T>(ref T v1) {
			v1 = default(T);
		}




		static void Main(string[] args) {
			Proc1('A', 66);
			Proc1(9.1, 199.99f);
			Proc1("Hello!", 9999.99m);
			Proc1(true, false);
			Proc2(123);
			Proc2(DateTime.Now);
			Proc3("Hello!");
			DateTime dt = Proc7<DateTime>();
			int a = 123; Proc8(ref a);
			Console.WriteLine(a);	// 0
		}
	}
}
