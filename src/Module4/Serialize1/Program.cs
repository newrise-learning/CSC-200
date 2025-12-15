using MyLib1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialize1 {
	class Program {
		static void Main(string[] args) {
			Time t1 = new Time(10, 20, 30);
			FileStream stream1 = new FileStream("Time.xml", FileMode.Create);
			//	BinaryFormatter formatter1 = new BinaryFormatter();
			//	SoapFormatter formatter1 = new SoapFormatter();
			XmlSerializer formatter1 = new XmlSerializer(typeof(Time));
			formatter1.Serialize(stream1, t1);
			stream1.Close();

			FileStream stream2 = new FileStream("Time.xml", FileMode.Open);
			//	BinaryFormatter formatter2 = new BinaryFormatter();
			//	SoapFormatter formatter2 = new SoapFormatter();
			XmlSerializer formatter2 = new XmlSerializer(typeof(Time));
			Time t2 = (Time)formatter2.Deserialize(stream2);
			stream2.Close();
			Console.WriteLine(t2);
		}
	}
}
