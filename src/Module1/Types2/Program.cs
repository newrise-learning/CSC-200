using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types2
{
	class Program
	{
		static void Main(string[] args)
		{
			int v1 = 100;
			double v2 = v1; // can fit
			v1 = (int)v2;   // may not fit

			byte v3 = 65;
			char v4 = (char)v3; // different type
			v3 = (byte)v4;      // different type

			bool v5 = true;			// bool is 100% compatible to int
			int v6 = v5 ? 1 : 0;	// typecasing does not work

		}
	}
}
