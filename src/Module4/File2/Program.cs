using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File2 {
	class Program {
		static void Main(string[] args) {
			using (var writer = new StreamWriter("C:\\Abc.txt", true)) {
				Console.WriteLine(writer is IDisposable);
				writer.WriteLine("Hello System.IO.File!");
				writer.WriteLine("Hello System.IO.StreamWriter!");
			}

			Console.WriteLine("Read line in line:");
			var reader = new StreamReader("C:\\Abc.txt");
			var line = reader.ReadLine();
		//	while (!reader.EndOfStream) { 
			while (line != null) {
				Console.WriteLine(line);
				line = reader.ReadLine();
			}
			reader.Close();

			Console.WriteLine("Read all contents:");
			reader = new StreamReader("C:\\Abc.txt");
			string data = reader.ReadToEnd();
			reader.Close();
			Console.WriteLine(data);

			string[] lines = data.Split('\n');
			foreach (var line2 in lines)
				Console.WriteLine(line2);


			string[] lines2 = {
				"This is line1.",
				"This is line2.",
				"This is line3."
			};

			File.WriteAllLines(@"C:\File1.txt", lines2);
			File.AppendAllLines(@"C:\Files1.txt", lines2);

			lines2 = File.ReadAllLines(@"C:\File1.txt");
			foreach (var line2 in lines2)
				Console.WriteLine(line2);

			string text = "This is line 1.\r\n" +
				"This is line 2.\r\n" +
				"This is line 3.\r\n";
			File.WriteAllText(@"C:\File2.txt", text);
			text = File.ReadAllText(@"C:\File2.txt");
			Console.WriteLine(text);


		}
	}
}
