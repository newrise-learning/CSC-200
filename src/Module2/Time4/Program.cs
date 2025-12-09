using MyLib1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time4 {
	class Program {
		static void Main(string[] args) {
			//	ArrayList list = new ArrayList();
			List<Time> list = new List<Time>();
			list.Add(new Time(11, 22, 33));
			list.Add(new Time(22, 33, 44));
			list.Add(new Time(10, 20, 30));
			list.Sort();
			foreach (Time item in list)
				Console.WriteLine(item);

			Time t1 = (Time)37230;
			Time t2 = (Time)37231;
			Console.WriteLine(t1.CompareTo(t2));
			Console.WriteLine(t1.CompareTo(37230));

			Time.Midnight.Hour = 1;

			Console.WriteLine(Time.Midnight);
			Console.WriteLine(Time.Afternoon);
			Time t5 = Time.Midnight;
			t5.Hour = 1;
			Console.WriteLine(Time.Midnight);

			Console.WriteLine(Time.MinHour);
			Console.WriteLine(Time.MaxHour);

			Console.WriteLine(int.MinValue);
			Console.WriteLine(int.MaxValue);
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);
			Console.WriteLine(double.MinValue);
			Console.WriteLine(double.MaxValue);
		}

	}
}
