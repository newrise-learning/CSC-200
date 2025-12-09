using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous1 {


	class Program {
		static dynamic Add(dynamic a, dynamic b) { return a + b; }

		static void ShowAccount(dynamic obj) {
			Console.WriteLine(obj.ID);
			Console.WriteLine(obj.Name);
			Console.WriteLine(obj.Balance);
		}
		static void Main(string[] args) {
			var a = new {
				ID = 100,
				Name = "ABC Trading",
				Balance = 10000m
			};
			ShowAccount(a);

			Console.WriteLine(Add(10, 20));
			Console.WriteLine(Add(1.99, 99.1));
			Console.WriteLine(Add("Hello!", "Goodbye!"));
			Console.WriteLine(Add(DateTime.Now,TimeSpan.FromDays(7)));
			Console.WriteLine(Add("Hello!", 999));
			Console.WriteLine(Add(999, 9.99));
		//	Console.WriteLine(Add(DateTime.Now, 9.99));
		//	Console.WriteLine(Add(true, false));
		}
	}
}

