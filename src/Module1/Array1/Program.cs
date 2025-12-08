using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a1;
			a1 = new int[4];
			a1[0] = 10;
			a1[1] = 20;
			a1[2] = 30;
			a1[3] = 40;
			Console.WriteLine(a1[0]);
			Console.WriteLine(a1[3]);
			a1 = null;

			int[] a2;
			a2 = new int[4] { 10, 20, 30, 40 };
			Console.WriteLine(a2[0]);
			Console.WriteLine(a2[3]);
			a2 = null;

			int[] a3 = { 10, 20, 30, 40 };
			Console.WriteLine(a3[0]);
			Console.WriteLine(a3[3]);
			a3 = null;

		}
	}
}
