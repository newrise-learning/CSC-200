using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File1 {
	class Program {
		static void Main(string[] args) {
			var source = "Original.txt";
			var target = @"C:\Abc.txt";
			var writer = File.CreateText(source);
			writer.WriteLine("Hello System.IO!");
			writer.Close();
			File.Copy(source, "Backup.txt");
			if (File.Exists(target)) File.Delete(target);
			File.Move(source, target);
			FileInfo fi = new FileInfo(target);
			fi.Delete();
		}
	}
}
