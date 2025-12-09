using MyLib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time2 {
	class Program {
		static void Show(int v) {
			Console.WriteLine(v);
		}
		static void ShowTime(Time t) {
			Console.WriteLine("{0:00}:{1:00}:{2:00}",
				t.Hour, t.Minute, t.Second);
		}

		static void Main(string[] args) {
			var t1 = new Time(10, 20, 30);
			var t2 = new Time(20, 30, 40);
			Console.WriteLine(t1.Value);
			Console.WriteLine(t2.Value);
			t1 += 100; Console.WriteLine(t1.Value);
			t2 -= 200; Console.WriteLine(t2.Value);
			Console.WriteLine(t1 - t2);
			Console.WriteLine(t2 - t1);

			t1 = new Time(10, 20, 30);
			t2 = new Time(10, 20, 30);
			Console.WriteLine(t1 == t2);
			Console.WriteLine(t1 == 37230);
			Console.WriteLine(t1 != t2);
			Console.WriteLine(t1 != 37230);

			int d = (int)t1;
			Show((int)t1);

			Time e = (Time)32730;
			ShowTime((Time)32730);

			Console.WriteLine((int)t1 < 30000);
			Console.WriteLine((int)t1 > 30000);

			t1[0] = 10;
			t1[1] = 20;
			t1[2] = 30;
			Console.WriteLine(t1[0]);
			Console.WriteLine(t1[1]);
			Console.WriteLine(t2[2]);

			t1['h'] = 11;
			t1['m'] = 22;
			t1['s'] = 33;
			Console.WriteLine(t1['h']);
			Console.WriteLine(t1['m']);
			Console.WriteLine(t1['s']);
		}
	}
}
