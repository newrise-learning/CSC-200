using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend2 {
	class ClassA {
		private int v1;
		protected int v2;
		public int Value1 {  get { return v1; } }
		public int Value2 {  get { return v2; } }
		//public ClassA() {
		//	v1 = 1; v2 = 2;
		//	Console.WriteLine("ClassA() called!");
		//}
		public ClassA(int v) {
			//	v1 = v2 = v;
			v2 = (v1 = v) * 2;
			Console.WriteLine("ClassA(int) called!");
		}
	}

	class ClassB : ClassA {
		private int v3;
		public ClassB() : base(1) {
			v3 = 3;
			Console.WriteLine("ClassB() called!");
		}
	//	public ClassB(int v) : base(v / 3) { 
		public ClassB(int v) : this(1, v) { 
			v3 = v;
			Console.WriteLine("ClassB(int) called!");
		}
		public ClassB(int a, int b) : base(a) {
			v3 = b;
			Console.WriteLine("ClassB(int,int) called!");
		}
		public void ShowValues() {
			Console.WriteLine(Value1);  // cannot v1 directly
		//	Console.WriteLine(v2);		// because v2 is protected
			Console.WriteLine(Value2);  // because Value2 is public
			Console.WriteLine(v3);		// local access
		}
	}

	class Program {

		static void Main(string[] args) {
		//	var obj = new ClassB(10,30);
			var obj = new ClassB();
			obj.ShowValues();
		}
	}
}
