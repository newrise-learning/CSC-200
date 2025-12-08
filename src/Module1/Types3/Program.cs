using MyLib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types3
{
	class Program
	{
		static void Main(string[] args)
		{
			Point1 p1;
			p1.X = 10;
			p1.Y = 20;
			Console.WriteLine(p1.X);
			Console.WriteLine(p1.Y);

			Point2 p2;
			p2 = new Point2();	// create object and return reference
			p2.X = 11;			// storing X in object
			p2.Y = 22;          // storing Y in object
			Console.WriteLine(p2.X);
			Console.WriteLine(p2.Y);
		//	p2 = new Point2();
			p2 = null;			// release object as soon as possible
		//	GC.Collect();	// may hang up your program
		}
	}
}
