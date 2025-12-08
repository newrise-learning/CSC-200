using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] a = { "John", "Anne", "Mary", "Lilo" };
			Array.Sort(a);
			Console.WriteLine(a[0]);
			Console.WriteLine(a[3]);

			int pos1 = Array.BinarySearch(a, "Lilo");
			int pos2 = Array.BinarySearch(a, "Jack");
			Console.WriteLine(pos1);
			Console.WriteLine(pos2);

			string[] b = a; // copy reference
			string[] c = (string[])a.Clone();   // clone the array
			a[3] = "Stitch";
			Console.WriteLine(b[3]);    // value changed
			Console.WriteLine(c[3]);    // value not changed

			a = null;
			b = null;
			c = null;

			b = new string[3];
			c = new string[5];
			Array.Copy(a, b, 3); // b[0] = a[0]; b[1] = a[1]; b[2] = a[2];
			a.CopyTo(c, 1);	// c[1] = a[0]; c[2] = a[1]; c[3] = a[2]; c[4] = a[3];
			c[0] = "Sarah";
			Array.Clear(a, 0, 4); // a[0] to a[4] will set to 0

		}
	}
}
