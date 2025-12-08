using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary2
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "This is a text 긏 string!";
			byte[] a1 = Encoding.ASCII.GetBytes(text);
			byte[] a2 = Encoding.Unicode.GetBytes(text);
			byte[] a3 = Encoding.UTF8.GetBytes(text);
			Console.WriteLine(a1.Length);
			Console.WriteLine(a2.Length);
			Console.WriteLine(a3.Length);

			Console.WriteLine(Encoding.ASCII.GetString(a1));
			Console.WriteLine(Encoding.Unicode.GetString(a2));
			Console.WriteLine(Encoding.UTF8.GetString(a1));
			Console.WriteLine(Encoding.UTF8.GetString(a3));
		}
	}
}
