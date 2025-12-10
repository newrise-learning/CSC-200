using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1 {
	class Program {
		//static object Copy(ICloneable obj) {
		//	return obj.Clone();
		//}

		//static object Copy(object obj) {
		//	if (obj is ICloneable) {
		//		ICloneable item = (ICloneable)obj;
		//		return item.Clone();
		//	}
		//	return null;
		//}

		static object Copy(object obj) {
			ICloneable item = obj as ICloneable;
		//	return item == null ? null : item.Clone();
			return item ?? item.Clone();
		}

		static void Main(string[] args) {
			object o1 = Copy("ABCDEF");
			ArrayList l1 = new ArrayList() {
				100,200,300
			};
			object o2 = Copy(l1);
			object o3 = Copy(DateTime.Now);
			if (o3 == null) Console.WriteLine(
				"Cannot copy datetime.");
		}
	}
}
