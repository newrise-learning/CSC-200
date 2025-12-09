using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect3
{
	class Program
	{
		static void Main(string[] args)
		{
		//	ArrayList list = new ArrayList();
		//	List<int> list = new List<int>();
			var list = new List<int>();

			//list.Add(10);	// boxing
			//list.Add(20);   // boxing
			//list.Add(30);   // boxing
			list.Add(10);
			list.Add(20);
			list.Add(30);

			//var v1 = (int)list[0]; // unboxing
			//var v2 = (int)list[1]; // unboxing
			//var v3 = (int)list[2]; // unboxing
			var v1 = list[0];
			var v2 = list[1];
			var v3 = list[2];

			Console.WriteLine(v1);
			Console.WriteLine(v2);
			Console.WriteLine(v3);

		}
	}
}
