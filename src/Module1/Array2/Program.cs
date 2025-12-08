using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] a =
			{
				{ 10, 20, 30 },
				{ 30, 40, 50 },
				{ 50, 60, 70 },
				{ 70, 80, 90 }
			};

			int[,] b;
			b = new int[4, 3]
			{
				{ 10, 20, 30 },
				{ 30, 40, 50 },
				{ 50, 60, 70 },
				{ 70, 80, 90 }
			};

			Console.WriteLine(a[0, 0]); // 10
			Console.WriteLine(b[3, 2]);	// 90
		}
	}
}
