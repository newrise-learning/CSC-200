using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] a;
			a = new int[3][];
			a[0] = new int[] { 10, 20, 30 };
			a[1] = new int[] { 30, 40 };
			a[2] = new int[] { 40, 50, 60, 70 };
			Console.WriteLine(a[0][0]); // 10
			Console.WriteLine(a[2][3]); // 70

			int[][] b;
			b = new int[][]
			{
				new int [] { 10, 20, 30 },
				new int [] { 30, 40 },
				new int [] { 40, 50, 60, 70 }
			};
			Console.WriteLine(b[0][0]); // 10
			Console.WriteLine(b[2][3]); // 70

			int[,] p = {
				{ 100, 160 },
				{ 220, 140 },
				{ 115, 270 }
			};

			Console.WriteLine(p.Length);
			Console.WriteLine(p.GetLength(0));
			Console.WriteLine(p.GetLength(1));
			Console.WriteLine(p.Rank);
			Console.WriteLine(p.GetLowerBound(0));	// 0
			Console.WriteLine(p.GetLowerBound(1));	// 0
			Console.WriteLine(p.GetUpperBound(0));	// 2
			Console.WriteLine(p.GetUpperBound(1));  // 1

			Console.WriteLine(a.Length);
			Console.WriteLine(a[0].Length);
			Console.WriteLine(a[1].Length);
			Console.WriteLine(a[2].Length);
		}
	}
}
