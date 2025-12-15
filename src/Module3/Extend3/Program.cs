using MyLib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend3 {
	public class MyList<T> : List<T> {
		public void Display() {
			foreach (T value in this)
				Console.WriteLine(value);
		}
	}

	public class DecimalList : MyList<decimal> {
		public decimal Sum() {
			decimal total = 0;
			foreach (decimal value in this)
				total += value;
			return total;
		}
	}

	class Program {
		static void Main(string[] args) {
			MyList<int> l1 = new MyList<int>();
			DecimalList l2 = new DecimalList();
			l1.Add(100); l1.Add(200); l1.Add(300);
			l2.Add(100.1m); l2.Add(200.2m); l2.Add(300.3m);
			l1.Display(); l2.Display();
			Console.WriteLine(l2.Sum());

			Time t1 = new Time(10, 20, 30);
			var i1 = t1 as ICloneable<Time>;
			var i2 = t1 as ICloneable;
			Time o2 = i1.Clone();
			object o3 = i2.Clone();
			// Time o3 = (Time)i2.Clone();


		}
	}
}
