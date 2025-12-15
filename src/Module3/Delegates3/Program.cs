using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates3 {
	class Program {
		static void Show(int x) {
			Console.WriteLine(x);
		}

		static void Main(string[] args) {
			Action a1 = () => Console.WriteLine("Hello!");
			Action<string> a2 = x => Console.WriteLine(x);
			Action<int, int, int> a3 = (x, y, z) => {
				DateTime dt = new DateTime(x, y, z);
				Console.WriteLine(dt);
			};

			a1();
			a2("Goodbye!");
			a2("Sayonara!");
			a3(2025, 12, 10);

			Func<int, int, int, DateTime> f1 = (x, y, z) =>
				   new DateTime(x, y, z);
			Console.WriteLine(f1(1967, 10, 6));
			Console.WriteLine(f1(2010, 2, 14));

			var values = new List<int> {
				66, 91, 13, 80, 42, 72, 35 };


			Predicate<int> Odd = x => (x % 2) == 1;
			Predicate<int> Even = x => (x % 2) == 0;

		//	var list1 = values.FindAll(Odd);     // list of Odd values
		//	var list2 = values.FindAll(Even);   // list of Even values

			var list1 = values.FindAll(x => (x % 2) == 1);     // list of Odd values
			var list2 = values.FindAll(x => (x % 2) == 0);   // list of Even values

			//Action<int> show = x => Console.WriteLine(x);
			//list1.ForEach(show);
			//list2.ForEach(show);

			//list1.ForEach(x => Console.WriteLine(x));
			//list2.ForEach(x => Console.WriteLine(x));

			list1.ForEach(Show);
			list2.ForEach(Show);

			values.RemoveAll(Odd);

		}
	}
}
