using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File3 {
	class Program {
		static void Main(string[] args) {
			int id = 123;
			string name = "Can of Coke";
			double price = 1.20;
			var stream = new FileStream("C:\\ABC.bin", FileMode.Create);
			var writer = new BinaryWriter(stream);
			//var b1 = BitConverter.GetBytes(id);
			//stream.Write(b1,0,b1.Length);
			writer.Write(id);
			writer.Write(name);
			writer.Write(price);
			writer.Close();
			stream.Close();

			stream = new FileStream("C:\\ABC.bin", FileMode.Open);
			var reader = new BinaryReader(stream);
			var id2 = reader.ReadInt32();
			var name2 = reader.ReadString();
			var price2 = reader.ReadDouble();
			reader.Close();
			stream.Close();
			Console.WriteLine(id2);
			Console.WriteLine(name2);
			Console.WriteLine(price2);

			id = 220;
			stream = new FileStream("C:\\ABC.bin", FileMode.Open);
			reader = new BinaryReader(stream);
			writer = new BinaryWriter(stream);
			Console.WriteLine(stream.Length);   // size of file
			stream.Seek(4, SeekOrigin.Begin);	// position of name
			Console.WriteLine(reader.ReadString()); // name
			stream.Seek(0, SeekOrigin.Begin);   // position of id
			writer.Write(id);                   // write new id
			reader.Close();
			writer.Close();
			stream.Close();
		}
	}
}
