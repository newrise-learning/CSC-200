using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types4
{
	class Program
	{
		static void Main(string[] args)
		{
			object o1 = "123";  // no-boxing (string is already object)
			object o2 = 123;    // boxing an int into an object
			string s1 = (string)o1; // check o1 is a string reference
			int v1 = (int)o2;	// unboxing int from object
			
		}
	}
}
