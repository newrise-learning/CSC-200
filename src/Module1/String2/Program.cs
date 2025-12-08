using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter account id:");
			//	var id = int.Parse(Console.ReadLine());
			var id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter amount to deposit:");
			// var amount = decimal.Parse(Console.ReadLine());
			var amount = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine(id);
			Console.WriteLine(amount);
		}
	}
}
