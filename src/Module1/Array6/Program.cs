using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array6
{
	class Program
	{
		static double Sum(params double[] values)
		{
			double total = 0;
			foreach (double value in values)
				total += value;
			return total;
		}

		static void Main(string[] args)
		{
			double[] v1 = { 1.1, 2.2, 3.3, 4.4 };
			Console.WriteLine(Sum(v1));
			Console.WriteLine(Sum());   // empty array
			Console.WriteLine(Sum(1.1));   // 1 element
			Console.WriteLine(Sum(1.1,2.2));   // 2 elements
			Console.WriteLine(Sum(1.1,2.2,3.3));   // 3 elements
			Console.WriteLine(Sum(1.1,2.2,3.3,4.4));   // 4 elements
			Console.WriteLine(Sum(1.1,2.2,3.3,4.4,5.5));   // 5 elements

		}
	}
}
