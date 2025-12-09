using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect1
{
	class Program
	{
		static void Main(string[] args)
		{
			//	ArrayList a = new ArrayList();
			//var a = new ArrayList();
			//a.Add("John");
			//a.Add("Jane");
			//a.Add("Mary");
			//a.Add("Lilo");
			//a.Add("Anne");

			var a = new ArrayList() {
				"John",
				"Jane",
				"Mary",
				"Lilo",
				"Anne"
			};

			Console.WriteLine(a.Count);
			Console.WriteLine(a[0]);
			Console.WriteLine(a[4]);
			a.Sort();
			Console.WriteLine(a[0]);
			Console.WriteLine(a[4]);
			Console.WriteLine(a.Contains("John"));
			Console.WriteLine(a.IndexOf("Lilo"));
			Console.WriteLine(a.BinarySearch("Jane"));
			a.Remove("Anne");
			Console.WriteLine(a[0]);
			a.RemoveAt(0);
			Console.WriteLine(a[0]);
			a.Clear();
			Console.WriteLine(a.Count);
		}
	}
}
