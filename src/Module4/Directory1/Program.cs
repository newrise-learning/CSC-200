using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory1 {
	class Program {
		static void Main(string[] args) {
			var path = @"C:\Windows";
			var files = Directory.GetFiles(path);
			var directories = Directory.GetDirectories(path);
			foreach (var item in files) Console.WriteLine(item);
			foreach (var item in directories) Console.WriteLine(item);
			var source = @"C:\Temp\ABC";
			var target = @"C:\ABC";
			Directory.CreateDirectory(source);
			if (Directory.Exists(target))
				Directory.Delete(target, true);
			Directory.Move(source, target);
			Directory.SetCurrentDirectory(target);
			Console.WriteLine(Directory.GetCurrentDirectory());
			DirectoryInfo di = new DirectoryInfo(target);
			di.Delete();
		}
	}
}
