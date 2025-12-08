using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array5
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] values = {
				{1,2,3},
				{3,4,5},
				{5,6,7},
				{7,8,9}
			};

			foreach (int value in values)
				Console.WriteLine(value);

			int my = values.GetUpperBound(0);
			int mx = values.GetUpperBound(1);

			for (int y = 0; y <= my; y++)
				for (int x = 0; x <= mx; x++)
				{
					int value = values[y, x];
					Console.WriteLine(value);
				}

		}
	}
}
