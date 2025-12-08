using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInary1
{
	class Program
	{
		static void Main(string[] args)
		{
			int v1 = 123;
			double v2 = 99.1;
			bool v3 = false;

			byte[] a1 = BitConverter.GetBytes(v1);
			byte[] a2 = BitConverter.GetBytes(v2);
			byte[] a3 = BitConverter.GetBytes(v3);

			Console.WriteLine(BitConverter.ToInt32(a1, 0));
			Console.WriteLine(BitConverter.ToDouble(a2, 0));
			Console.WriteLine(BitConverter.ToBoolean(a3, 0));
		}
	}
}
