using System;

namespace String3
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "ABCDEF";
			string s2 = s1.Insert(1, "XYZ");	// makes a new string
			Console.WriteLine(s1);	// old object still exists
			Console.WriteLine(s2);  // new object
			s2 = null;
			s1 = s1.Insert(1,"XYZ");	// replace old reference
			Console.WriteLine(s1);
			s1 = "ABCDEF";  // point back to old object
			Console.WriteLine(s1);

			s1 = "   Can of Coke  ";
			Console.WriteLine(s1.Length);   // length property
			Console.WriteLine(s1.ToUpper());
			Console.WriteLine(s1.ToLower());
			Console.WriteLine(s1.PadLeft(30));
			Console.WriteLine(s1.PadRight(30));
			Console.WriteLine(s1.PadLeft(30,'*'));
			Console.WriteLine(s1.PadRight(30,'*'));
			Console.WriteLine(s1.TrimStart());
			Console.WriteLine(s1.TrimEnd());
			Console.WriteLine(s1.TrimStart());
			Console.WriteLine(s1.TrimStart().TrimEnd());
			Console.WriteLine(s1.Trim());
			Console.WriteLine(s1.Trim().Substring(0, 3));
			Console.WriteLine(s1.Trim().Substring(4));
			Console.WriteLine(s1.Replace("Coke", "Pepsi"));
			Console.WriteLine(s1.IndexOf("of"));
			Console.WriteLine(s1.LastIndexOf('o'));
			Console.WriteLine(s1.Contains("Coke"));
			Console.WriteLine(s1.Trim().StartsWith("Can"));
			Console.WriteLine(s1.Trim().EndsWith("Coke"));
			Console.WriteLine(s1.Remove(4, 3));
			Console.WriteLine(s1.Trim().Equals("Can of Coke"));
			Console.WriteLine("Anne".CompareTo("Mary"));
			Console.WriteLine("Anne".CompareTo("Anna"));
			Console.WriteLine("Anne".CompareTo("Anne"));
			string s3 = string.Format(
				"Price of {0} is {1}", s1, 1.20);
			Console.WriteLine(s3);
			s3 = $"Price of {s1} is {1.20}";
			Console.WriteLine(s3);

			foreach (char c in s3) Console.WriteLine(c);
		}
	}
}
