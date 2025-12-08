using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
	class Program
	{
		static void Main(string[] args)
		{
			double amount = 32500.90;
			string text1 = amount.ToString();
			string text2 = amount.ToString("###,##0.00");
			string text3 = String.Format("{0:###,##0.00}", amount);
			string text4 = $"{amount:###,##0.00}";
			string text5 = $"{amount}";
			Console.WriteLine(text1);
			Console.WriteLine(text2);
			Console.WriteLine(text3);
			Console.WriteLine(text4);
			Console.WriteLine(text5);
		}
	}
}
