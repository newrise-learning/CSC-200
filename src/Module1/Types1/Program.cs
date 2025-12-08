using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 123; // using C# type
			Int32 b = 321;	// using .NET type
			a = b;	// int same as Int32
			b = a;  // Int32 as as int
			Console.WriteLine(a);
			Console.WriteLine(b);

			byte v1 = 255;
			char v2 = '긋';
			System.Windows.Forms.MessageBox.Show("" + v2);
			bool v3 = true;
			float v4 = 9.999999f;
			double v5 = 999999999.999999d;
			decimal v6 = 792281625142643.37593543950335m;
			Console.WriteLine(v1);
			Console.WriteLine(v2);
			Console.WriteLine(v3);
			Console.WriteLine(v4);
			Console.WriteLine(v5);
			Console.WriteLine(v6);

			var a1 = 100ul;	// ulong
			var a2 = 'A';
			var a3 = 99.99f;
			var a4 = 9.9999;
			var a5 = 999.9m;
			var a6 = true;
			Console.WriteLine(a1);
			Console.WriteLine(a2);
			Console.WriteLine(a3);
			Console.WriteLine(a4);
			Console.WriteLine(a5);
			Console.WriteLine(a6);

			var a7 = 0xa910d72a;    // base 16 (0-19,A-F)
			var a8 = 0b110111000001001; // base 2 (0-1)
			var a9 = 0b1100_1110_0000_1001; // use underscore for separator
			Console.WriteLine(a7);
			Console.WriteLine(a8);
			Console.WriteLine(a9);

		}
	}
}
