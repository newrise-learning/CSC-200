using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String4
{
	class Program
	{
		static void Main(string[] args)
		{
			int id = 100;
			string name = "Can of Coke";
			double price = 1.20;
			string s1 = "ID=" + id + ",Name=" + name + ",Price=" + price;
			string s2 = string.Concat("ID=", id, ",Name=", name, ",Price=", price);
			string s3 = string.Format("ID={0},Name={1},Price={2:C2}", id, name, price);
			string s4 = $"ID={id},Name={name},Price={price:C2}";
			Console.WriteLine(s1);
			Console.WriteLine(s2);
			Console.WriteLine(s3);
			Console.WriteLine(s4);

			StringBuilder sb = new StringBuilder();
			sb.
				Append("ID=").Append(id).
				Append(",Name=").Append(name).
				AppendFormat(",Price={0:C}", price);
			string s5 = sb.ToString();
			Console.WriteLine(s5);
			sb = null;
		}
	}
}
